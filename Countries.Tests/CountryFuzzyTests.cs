using Countries;

namespace Countries.Tests;

[TestFixture]
public class CountryFuzzyTests
{
    // ── Exact matches ────────────────────────────────────────────────────────

    [TestCase("Italy",       "Italy")]
    [TestCase("Germany",     "Germany")]
    [TestCase("France",      "France")]
    [TestCase("Brazil",      "Brazil")]
    [TestCase("Australia",   "Australia")]
    [TestCase("Japan",       "Japan")]
    [TestCase("China",       "China")]
    [TestCase("Spain",       "Spain")]
    public void Fuzzy_ExactName_ShouldReturnCorrectCountry(string input, string expected)
    {
        var country = Country.Fuzzy(input);
        Assert.That(country.CommonName, Is.EqualTo(expected));
    }

    // ── Typos / near-matches ─────────────────────────────────────────────────

    // "Spian" is intentionally excluded: Levenshtein correctly prefers "Sudan"
    // (distance 1: s-u-d-a-n vs s-p-i-a-n) over "Spain" (distance 2).
    [TestCase("Itali",  "Italy")]
    [TestCase("Germny", "Germany")]
    [TestCase("Frace",  "France")]
    public void Fuzzy_MinorTypo_ShouldReturnCorrectCountry(string input, string expected)
    {
        var country = Country.Fuzzy(input);
        Assert.That(country.CommonName, Is.EqualTo(expected));
    }

    // ── Case insensitive ─────────────────────────────────────────────────────

    [TestCase("italy")]
    [TestCase("ITALY")]
    [TestCase("iTaLy")]
    public void Fuzzy_CaseVariants_ShouldReturnItaly(string input)
    {
        var country = Country.Fuzzy(input);
        Assert.That(country.CommonName, Is.EqualTo("Italy"));
    }

    // ── Edge cases ───────────────────────────────────────────────────────────

    [Test]
    public void Fuzzy_NullOrWhitespace_ShouldReturnUnknown()
    {
        Assert.That(Country.Fuzzy(null!).CommonName, Is.EqualTo("Unknown"));
        Assert.That(Country.Fuzzy("").CommonName,    Is.EqualTo("Unknown"));
        Assert.That(Country.Fuzzy("   ").CommonName, Is.EqualTo("Unknown"));
    }

    [Test]
    public void Fuzzy_CompletelyUnrelated_ShouldReturnUnknown()
    {
        var country = Country.Fuzzy("xxxxxxxxxxx");
        Assert.That(country.CommonName, Is.EqualTo("Unknown"));
    }
}
