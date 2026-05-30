using Countries;
using NUnit.Framework;

namespace Countries.Tests;

[TestFixture]
public class CountryEqualityTests
{
    [Test]
    public void Equals_SameCountry_ShouldBeTrue()
    {
        var a = Country.FromCode(CountryCode.IT);
        var b = Country.FromCode(CountryCode.IT);
        Assert.That(a, Is.EqualTo(b));
    }

    [Test]
    public void Equals_DifferentCountries_ShouldBeFalse()
    {
        var italy  = Country.FromCode(CountryCode.IT);
        var france = Country.FromCode(CountryCode.FR);
        Assert.That(italy, Is.Not.EqualTo(france));
    }

    [Test]
    public void GetHashCode_SameCountry_ShouldBeEqual()
    {
        var a = Country.FromCode(CountryCode.DE);
        var b = Country.FromCode(CountryCode.DE);
        Assert.That(a.GetHashCode(), Is.EqualTo(b.GetHashCode()));
    }

    [Test]
    public void ToString_ShouldReturnCommonName()
        => Assert.That(Country.FromCode(CountryCode.IT).ToString(), Is.EqualTo("Italy"));

    [Test]
    public void CountryUsableAsDictionaryKey()
    {
        var dict = new Dictionary<Country, string>
        {
            [Country.FromCode(CountryCode.IT)] = "Italia",
            [Country.FromCode(CountryCode.DE)] = "Deutschland",
        };
        Assert.That(dict[Country.FromCode(CountryCode.IT)], Is.EqualTo("Italia"));
        Assert.That(dict[Country.FromCode(CountryCode.DE)], Is.EqualTo("Deutschland"));
    }
}
