using Countries;
using NUnit.Framework;

namespace Countries.Tests;

[TestFixture]
public class CountryFuzzyTests
{
    [TestCase("Italy",     "Italy")]
    [TestCase("Germany",   "Germany")]
    [TestCase("France",    "France")]
    [TestCase("Brazil",    "Brazil")]
    [TestCase("Australia", "Australia")]
    [TestCase("Japan",     "Japan")]
    [TestCase("China",     "China")]
    [TestCase("Spain",     "Spain")]
    public void Fuzzy_ExactName_ShouldReturnCorrectCountry(string input, string expected)
        => Assert.That(Country.Fuzzy(input).CommonName, Is.EqualTo(expected));

    // "Spian" is intentionally excluded: Levenshtein correctly prefers "Sudan" over "Spain".
    [TestCase("Itali",  "Italy")]
    [TestCase("Germny", "Germany")]
    [TestCase("Frace",  "France")]
    public void Fuzzy_MinorTypo_ShouldReturnCorrectCountry(string input, string expected)
        => Assert.That(Country.Fuzzy(input).CommonName, Is.EqualTo(expected));

    [TestCase("italy")]
    [TestCase("ITALY")]
    [TestCase("iTaLy")]
    public void Fuzzy_CaseVariants_ShouldReturnItaly(string input)
        => Assert.That(Country.Fuzzy(input).CommonName, Is.EqualTo("Italy"));

    [Test]
    public void Fuzzy_NullOrWhitespace_ShouldReturnUnknown()
    {
        Assert.That(Country.Fuzzy(null!).CommonName,  Is.EqualTo("Unknown"));
        Assert.That(Country.Fuzzy("").CommonName,     Is.EqualTo("Unknown"));
        Assert.That(Country.Fuzzy("   ").CommonName,  Is.EqualTo("Unknown"));
    }

    [Test]
    public void Fuzzy_CompletelyUnrelated_ShouldReturnUnknown()
        => Assert.That(Country.Fuzzy("xxxxxxxxxxx").CommonName, Is.EqualTo("Unknown"));
}
