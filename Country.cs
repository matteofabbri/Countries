using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Countries;

public partial struct Country : IEquatable<CountryCode>, IEquatable<CountryCodeISO3>
{
    private static Country[] _all;
    private static Dictionary<CountryCode, Country> _iso2;
    private static Dictionary<CountryCodeISO3, Country> _iso3;

    private static HashSet<(string key, Country country)> _fuzzyIndex;

    static Country()
    {
        _all = typeof(Country)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(p => p.PropertyType == typeof(Country))
            .Select(p => (Country)p.GetValue(null)!)
            .ToArray();

        _iso2 = _all.ToDictionary(c => c.CountryCode);
        _iso3 = _all.ToDictionary(c => c.ISO3);

        _fuzzyIndex = [.. _all
            .SelectMany(c =>
                new[]
                {
                    c.CommonName,
                    c.OfficialName
                }
                .Concat(c.AlternativeSpellings ?? Array.Empty<string>())
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x => (Normalize(x), c))
            )];
    }

    private static string Normalize(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        // Decomposizione Unicode per separare lettere e accenti
        var decomposed = s.Normalize(NormalizationForm.FormD);

        StringBuilder sb = new StringBuilder(decomposed.Length);

        foreach (var c in decomposed)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(c);

            // Rimuove accenti e segni diacritici
            if (category == UnicodeCategory.NonSpacingMark)
                continue;

            // Rimuove hyphen e tutte le varianti Unicode
            if (c == '-' || c == '‐' || c == '‑' || c == '‒' || c == '–' || c == '—' || c == '―')
                continue;

            // Rimuove spazi e punteggiatura non utile
            if (char.IsWhiteSpace(c) || c == '.' || c == ',' || c == ';' || c == ':' || c == '\'' || c == '’' || c == '`')
                continue;

            sb.Append(char.ToLowerInvariant(c));
        }

        return sb.ToString();
    }


    private static int Levenshtein(string a, string b)
    {
        int[,] d = new int[a.Length + 1, b.Length + 1];

        for (int i = 0; i <= a.Length; i++) d[i, 0] = i;
        for (int j = 0; j <= b.Length; j++) d[0, j] = j;

        for (int i = 1; i <= a.Length; i++)
        {
            for (int j = 1; j <= b.Length; j++)
            {
                int cost = a[i - 1] == b[j - 1] ? 0 : 1;

                d[i, j] = Math.Min(
                    Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                    d[i - 1, j - 1] + cost
                );
            }
        }

        return d[a.Length, b.Length];
    }

    public static Country Fuzzy(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Unknown;

        string n = Normalize(value);

        Country best = Unknown;
        int bestScore = int.MaxValue;

        foreach (var (key, country) in _fuzzyIndex)
        {
            int score = Levenshtein(n, key);

            if (score < bestScore)
            {
                bestScore = score;
                best = country;
            }
        }

        // soglia perfetta per nomi di paesi
        return bestScore <= 3 ? best : Unknown;
    }

    // -------------------------
    //  MEMBERS
    // -------------------------

    public string CommonName { get; private set; }
    public string OfficialName { get; private set; }
    public string[] TLD { get; private set; }
    public CountryCode CountryCode { get; private set; }
    public string ISONumeric { get; private set; }
    public CountryCodeISO3 ISO3 { get; private set; }
    public string CIOC { get; private set; }
    public string[] Currencies { get; private set; }
    public string[] CallingCodes { get; private set; }
    public string Capital { get; private set; }
    public string[] AlternativeSpellings { get; private set; }
    public string Region { get; private set; }
    public string SubRegion { get; private set; }
    public CountryCodeISO3[] Borders { get; private set; }
    public bool Landlocked { get; private set; }
    public double Area { get; private set; }

    public static IEnumerable<Country> All => _all;

    public static IEnumerable<Country> Africa   => _all.Where(c => c.Region == "Africa");
    public static IEnumerable<Country> Americas  => _all.Where(c => c.Region == "Americas");
    public static IEnumerable<Country> Asia      => _all.Where(c => c.Region == "Asia");
    public static IEnumerable<Country> Europe    => _all.Where(c => c.Region == "Europe");
    public static IEnumerable<Country> Oceania   => _all.Where(c => c.Region == "Oceania");

    public static Country Unknown
    {
        get
        {
            Country country = new()
            {
                CommonName = "Unknown",
                OfficialName = "Unknown",
                TLD = [".com"],
                CountryCode = CountryCode.Unknown,
                ISONumeric = "",
                ISO3 = CountryCodeISO3.Unknown,
                CIOC = "",
                Currencies = [],
                CallingCodes = [],
                Capital = "",
                AlternativeSpellings = [],
                Region = "",
                SubRegion = "",
                Borders = [],
                Landlocked = false,
                Area = 510072000.0
            };
            return country;
        }
    }

    public override readonly bool Equals(object obj)
    {
        if (obj is not Country country)
        {
            return false;
        }
        return CountryCode == country.CountryCode;
    }

    public override readonly int GetHashCode()
    {
        return (int)CountryCode;
    }

    public override string ToString() => CommonName;

    public static Country Parse(string value)
    {
        if (Enum.TryParse<CountryCode>(value, true, out var cc))
            return FromCode(cc);

        if (Enum.TryParse<CountryCodeISO3>(value, true, out var iso3))
            return FromCode(iso3);

        return Unknown;
    }

    public static Country FromCode(CountryCode cc)
        => _iso2.TryGetValue(cc, out var c) ? c : Unknown;

    public static Country FromCode(CountryCodeISO3 cc)
        => _iso3.TryGetValue(cc, out var c) ? c : Unknown;

    public bool Equals(CountryCode other)
    {
       if(!ReferenceEquals(this, other)) return false;

       return CountryCode == other;
    }

    public bool Equals(CountryCodeISO3 other)
    {
       if(!ReferenceEquals(this, other)) return false;

       return ISO3 == other;
    }
}
