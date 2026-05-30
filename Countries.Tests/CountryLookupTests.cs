using Countries;
using NUnit.Framework;

namespace Countries.Tests;

[TestFixture]
public class CountryLookupTests
{
    [Test]
    public void FromCode_ISO2_KnownCode_ShouldReturnCorrectCountry()
        => Assert.That(Country.FromCode(CountryCode.IT).CommonName, Is.EqualTo("Italy"));

    [Test]
    public void FromCode_ISO2_UnknownCode_ShouldReturnUnknown()
        => Assert.That(Country.FromCode(CountryCode.Unknown).CommonName, Is.EqualTo("Unknown"));

    [Test]
    public void FromCode_ISO3_KnownCode_ShouldReturnCorrectCountry()
        => Assert.That(Country.FromCode(CountryCodeISO3.ITA).CommonName, Is.EqualTo("Italy"));

    [Test]
    public void FromCode_ISO3_UnknownCode_ShouldReturnUnknown()
        => Assert.That(Country.FromCode(CountryCodeISO3.Unknown).CommonName, Is.EqualTo("Unknown"));

    [TestCase("IT",  "Italy")]
    [TestCase("it",  "Italy")]
    [TestCase("ITA", "Italy")]
    [TestCase("ita", "Italy")]
    [TestCase("DE",  "Germany")]
    [TestCase("DEU", "Germany")]
    [TestCase("US",  "United States")]
    [TestCase("USA", "United States")]
    public void Parse_ShouldReturnCorrectCountry(string input, string expectedName)
        => Assert.That(Country.Parse(input).CommonName, Is.EqualTo(expectedName));

    [TestCase("ZZZZ")]
    [TestCase("")]
    [TestCase("??")]
    public void Parse_InvalidInput_ShouldReturnUnknown(string input)
        => Assert.That(Country.Parse(input).CommonName, Is.EqualTo("Unknown"));

    [Test]
    public void Italy_StaticProperty_ShouldReturnItaly()
    {
        var country = Country.Italy;
        Assert.Multiple(() =>
        {
            Assert.That(country.CommonName,   Is.EqualTo("Italy"));
            Assert.That(country.CountryCode,  Is.EqualTo(CountryCode.IT));
            Assert.That(country.ISO3,         Is.EqualTo(CountryCodeISO3.ITA));
            Assert.That(country.Capital,      Is.EqualTo("Rome"));
            Assert.That(country.Continent,       Is.EqualTo(Continent.Europe));
        });
    }

    [Test]
    public void Unknown_ShouldReturnUnknownCountry()
    {
        var country = Country.Unknown;
        Assert.Multiple(() =>
        {
            Assert.That(country.CommonName,  Is.EqualTo("Unknown"));
            Assert.That(country.CountryCode, Is.EqualTo(CountryCode.Unknown));
            Assert.That(country.ISO3,        Is.EqualTo(CountryCodeISO3.Unknown));
        });
    }
}
