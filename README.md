# Countries

> A zero-dependency .NET library with strongly-typed, compile-time access to every country in the world.

No JSON files to embed, no HTTP calls, no configuration. Every nation ships as a static property directly on the `Country` struct — intellisense-complete, AOT-friendly, and always available offline.

---

## ✨ Features

- **247 countries and territories** — full UN/ISO dataset baked into the assembly
- **Strongly-typed codes** — `CountryCode` (ISO 3166-1 alpha-2) and `CountryCodeISO3` (alpha-3) enums, no magic strings
- **Rich metadata** per country — common name, official name, capital, TLD, currencies, calling codes, borders, area, landlocked flag, region and sub-region
- **Continent collections** — `Country.Europe`, `Country.Africa`, `Country.Asia`, `Country.Americas`, `Country.Oceania`
- **Fast O(1) lookup** by ISO2 or ISO3 code via dictionary
- **Fuzzy search** — find a country from a misspelled or partial name using Levenshtein distance
- **Value semantics** — `Country` is a `struct`; equality, `GetHashCode` and `ToString` work out of the box, usable as dictionary key
- **netstandard2.0** target — compatible with .NET Framework 4.6.1+, .NET Core, .NET 5+, Unity, Xamarin

---

## 📦 Installation

```bash
dotnet add package Countries
```

---

## 🚀 Quick start

```csharp
using Countries;

// Direct property access — zero allocation, compile-time safe
Country italy = Country.Italy;
Console.WriteLine(italy.Capital);      // Rome
Console.WriteLine(italy.CountryCode);  // IT
Console.WriteLine(italy.ISO3);         // ITA
Console.WriteLine(italy.Region);       // Europe
Console.WriteLine(italy.Area);         // 301336

// Lookup by ISO2 code
Country de = Country.FromCode(CountryCode.DE);

// Lookup by ISO3 code
Country deu = Country.FromCode(CountryCodeISO3.DEU);

// Parse a string (ISO2 or ISO3, case-insensitive)
Country us = Country.Parse("US");
Country usa = Country.Parse("usa");

// Fuzzy search — tolerates typos
Country fr = Country.Fuzzy("Frace");   // → France
Country jp = Country.Fuzzy("Jaapn");   // → Japan
```

---

## 🌍 Continent collections

```csharp
// All countries in a continent
foreach (var c in Country.Europe)
    Console.WriteLine($"{c.CommonName} ({c.Capital})");

// LINQ works naturally
var landlocked = Country.Africa.Where(c => c.Landlocked);
var largest    = Country.Americas.MaxBy(c => c.Area);
var euros      = Country.Europe.Where(c => c.Currencies.Contains("EUR"));
```

Available collections:

| Property           | Countries |
|--------------------|-----------|
| `Country.Africa`   | 54        |
| `Country.Americas` | 55        |
| `Country.Asia`     | 49        |
| `Country.Europe`   | 50        |
| `Country.Oceania`  | 25        |
| `Country.All`      | 247       |

---

## 🔎 Country properties

| Property               | Type                  | Example                          |
|------------------------|-----------------------|----------------------------------|
| `CommonName`           | `string`              | `"Italy"`                        |
| `OfficialName`         | `string`              | `"Italian Republic"`             |
| `CountryCode`          | `CountryCode`         | `CountryCode.IT`                 |
| `ISO3`                 | `CountryCodeISO3`     | `CountryCodeISO3.ITA`            |
| `ISONumeric`           | `string`              | `"380"`                          |
| `CIOC`                 | `string`              | `"ITA"`                          |
| `Capital`              | `string`              | `"Rome"`                         |
| `Region`               | `string`              | `"Europe"`                       |
| `SubRegion`            | `string`              | `"Southern Europe"`              |
| `TLD`                  | `string[]`            | `[".it"]`                        |
| `Currencies`           | `string[]`            | `["EUR"]`                        |
| `CallingCodes`         | `string[]`            | `["39"]`                         |
| `AlternativeSpellings` | `string[]`            | `["IT", "Italian Republic", …]`  |
| `Borders`              | `CountryCodeISO3[]`   | `[AUT, FRA, SMR, SVN, CHE, VAT]` |
| `Landlocked`           | `bool`                | `false`                          |
| `Area`                 | `double`              | `301336.0`                       |

---

## 🧭 Fuzzy search

`Country.Fuzzy(string)` normalises the input (strips accents, diacritics, punctuation) and finds the closest match using Levenshtein distance. Results with distance > 3 return `Country.Unknown`.

```csharp
Country.Fuzzy("Germny")    // → Germany
Country.Fuzzy("BRASIL")    // → Brazil
Country.Fuzzy("Österreich")// → Austria
Country.Fuzzy("zzzzzzzzz") // → Unknown
```

---

## ⚖️ Value semantics

```csharp
Country a = Country.FromCode(CountryCode.JP);
Country b = Country.Parse("JPN");

bool same = a == b;           // true — equality by CountryCode
int hash  = a.GetHashCode();  // stable, based on CountryCode
string s  = a.ToString();     // "Japan"

// Usable as dictionary key
var capitals = new Dictionary<Country, string>
{
    [Country.Italy]  = "Rome",
    [Country.France] = "Paris",
};
```

---

## 🧪 Tests

The solution includes a full NUnit test suite (`Countries.Tests`) with 70 tests covering collections, continent filters, lookup, parse, fuzzy search and equality.

```bash
dotnet test
```

---

## 📄 License

MIT — see [LICENSE.txt](LICENSE.txt).
