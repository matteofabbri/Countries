using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Countries;

public partial struct Country
{
    private static Country[] _all;
    private static Dictionary<CountryCode, Country> _iso2;
    private static Dictionary<CountryCodeISO3, Country> _iso3;
    private static Dictionary<string, Country> _common;
    private static Dictionary<string, Country> _official;

    static Country()
    {
        var all = typeof(Country)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(p => p.PropertyType == typeof(Country))
            .Select(p => (Country)p.GetValue(null)!)
            .ToArray();

        _iso2 = all.ToDictionary(c => c.CountryCode);
        _iso3 = all.ToDictionary(c => c.ISO3);
        _common = all.ToDictionary(c => c.CommonName);
        _official = all.ToDictionary(c => c.OfficialName);
    }

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

    public override bool Equals(object obj)
    {
        if (!(obj is Country country))
        {
            return false;
        }
        return CountryCode == country.CountryCode;
    }

    public override int GetHashCode()
    {
        return (int)CountryCode;
    }

    public override string ToString()
    {
        return CommonName;
    }

    public static Country Parse(string value)
    {
        if (Enum.TryParse<CountryCode>(value, ignoreCase: true, out var result))
        {
            return FromCode(result);
        }
        if (Enum.TryParse<CountryCodeISO3>(value, ignoreCase: true, out var result2))
        {
            return FromCode(result2);
        }
        return Unknown;
    }

    public static Country FromCode(CountryCode cc)
    {
        return _iso2.TryGetValue(cc, out Country result) ? result! : Unknown;
    }

    public static Country FromCode(CountryCodeISO3 cc)
    {
        return _iso3.TryGetValue(cc, out Country result) ? result! : Unknown;
    }
}
