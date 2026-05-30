using Countries;

namespace Countries.Tests;

[TestFixture]
public class CountryLookupTests
{
    // ── FromCode (ISO2) ──────────────────────────────────────────────────────

    [Test]
    public void FromCode_ISO2_KnownCode_ShouldReturnCorrectCountry()
    {
        var country = Country.FromCode(CountryCode.IT);
        Assert.That(country.CommonName, Is.EqualTo("Italy"));
    }

    [Test]
    public void FromCode_ISO2_UnknownCode_ShouldReturnUnknown()
    {
        var country = Country.FromCode(CountryCode.Unknown);
        Assert.That(country.CommonName, Is.EqualTo("Unknown"));
    }

    // ── FromCode (ISO3) ──────────────────────────────────────────────────────

    [Test]
    public void FromCode_ISO3_KnownCode_ShouldReturnCorrectCountry()
    {
        var country = Country.FromCode(CountryCodeISO3.ITA);
        Assert.That(country.CommonName, Is.EqualTo("Italy"));
    }

    [Test]
    public void FromCode_ISO3_UnknownCode_ShouldReturnUnknown()
    {
        var country = Country.FromCode(CountryCodeISO3.Unknown);
        Assert.That(country.CommonName, Is.EqualTo("Unknown"));
    }

    // ── Parse ────────────────────────────────────────────────────────────────

    [TestCase("IT",  "Italy")]
    [TestCase("it",  "Italy")]
    [TestCase("ITA", "Italy")]
    [TestCase("ita", "Italy")]
    [TestCase("DE",  "Germany")]
    [TestCase("DEU", "Germany")]
    [TestCase("US",  "United States")]
    [TestCase("USA", "United States")]
    public void Parse_ShouldReturnCorrectCountry(string input, string expectedName)
    {
        var country = Country.Parse(input);
        Assert.That(country.CommonName, Is.EqualTo(expectedName));
    }

    [TestCase("ZZZZ")]
    [TestCase("")]
    [TestCase("??")]
    public void Parse_InvalidInput_ShouldReturnUnknown(string input)
    {
        var country = Country.Parse(input);
        Assert.That(country.CommonName, Is.EqualTo("Unknown"));
    }

    // ── Static properties ────────────────────────────────────────────────────

    [Test]
    public void Italy_StaticProperty_ShouldReturnItaly()
    {
        var country = Country.Italy;
        Assert.Multiple(() =>
        {
            Assert.That(country.CommonName, Is.EqualTo("Italy"));
            Assert.That(country.CountryCode, Is.EqualTo(CountryCode.IT));
            Assert.That(country.ISO3, Is.EqualTo(CountryCodeISO3.ITA));
            Assert.That(country.Capital, Is.EqualTo("Rome"));
            Assert.That(country.Region, Is.EqualTo("Europe"));
        });
    }

    [Test]
    public void Unknown_ShouldReturnUnknownCountry()
    {
        var country = Country.Unknown;
        Assert.Multiple(() =>
        {
            Assert.That(country.CommonName, Is.EqualTo("Unknown"));
            Assert.That(country.CountryCode, Is.EqualTo(CountryCode.Unknown));
            Assert.That(country.ISO3, Is.EqualTo(CountryCodeISO3.Unknown));
        });
    }
}
