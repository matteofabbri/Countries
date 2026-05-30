using Countries;
using NUnit.Framework;

namespace Countries.Tests;

[TestFixture]
public class CountryCollectionTests
{
    [Test]
    public void All_ShouldNotBeEmpty()
        => Assert.That(Country.All, Is.Not.Empty);

    [Test]
    public void All_ShouldContainMoreThan190Countries()
        => Assert.That(Country.All.Count(), Is.GreaterThan(190));

    [Test]
    public void All_ShouldNotContainDuplicateCodes()
    {
        var codes = Country.All.Select(c => c.CountryCode).ToList();
        Assert.That(codes.Distinct().Count(), Is.EqualTo(codes.Count));
    }

    [Test]
    public void All_ShouldNotContainDuplicateISO3()
    {
        var codes = Country.All.Select(c => c.ISO3).ToList();
        Assert.That(codes.Distinct().Count(), Is.EqualTo(codes.Count));
    }

    [TestCase(Continent.Europe)]
    [TestCase(Continent.Africa)]
    [TestCase(Continent.Asia)]
    [TestCase(Continent.America)]
    [TestCase(Continent.Oceania)]
    public void All_EachRegion_ShouldHaveAtLeastOneCountry(Continent region)
        => Assert.That(Country.All.Any(c => c.Continent == region), Is.True,
            $"Region '{region}' should have at least one country");

    [Test]
    public void All_AllCountries_ShouldHaveNonEmptyCommonName()
    {
        var missing = Country.All.Where(c => string.IsNullOrWhiteSpace(c.CommonName)).ToList();
        Assert.That(missing, Is.Empty, "All countries should have a CommonName");
    }

    [Test]
    public void All_MostCountries_ShouldHavePositiveArea()
    {
        // A handful of entries (e.g. Svalbard and Jan Mayen, Vatican City) legitimately
        // have Area = 0 in the source data. We tolerate up to 5 such cases.
        var zeroArea = Country.All.Where(c => c.Area <= 0).ToList();
        Assert.That(zeroArea.Count, Is.LessThanOrEqualTo(5),
            $"Too many countries with zero/negative area: {string.Join(", ", zeroArea.Select(c => c.CommonName))}");
    }
}
