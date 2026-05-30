using Countries;
using NUnit.Framework;

namespace Countries.Tests;

[TestFixture]
public class CountryContinentTests
{
    // ── Africa ──────────────────────────────────────────────────────────────

    [Test]
    public void Africa_ShouldNotBeEmpty()
        => Assert.That(Country.Africa, Is.Not.Empty);

    [Test]
    public void Africa_AllShouldHaveCorrectRegion()
        => Assert.That(Country.Africa.All(c => c.Continent == "Africa"), Is.True);

    [Test]
    public void Africa_ShouldContainNigeria()
        => Assert.That(Country.Africa.Any(c => c.CommonName == "Nigeria"), Is.True);

    [Test]
    public void Africa_ShouldContainSouthAfrica()
        => Assert.That(Country.Africa.Any(c => c.CountryCode == CountryCode.ZA), Is.True);

    // ── Americas ─────────────────────────────────────────────────────────────

    [Test]
    public void Americas_ShouldNotBeEmpty()
        => Assert.That(Country.Americas, Is.Not.Empty);

    [Test]
    public void Americas_AllShouldHaveCorrectRegion()
        => Assert.That(Country.Americas.All(c => c.Continent == "Americas"), Is.True);

    [Test]
    public void Americas_ShouldContainUnitedStates()
        => Assert.That(Country.Americas.Any(c => c.CountryCode == CountryCode.US), Is.True);

    [Test]
    public void Americas_ShouldContainBrazil()
        => Assert.That(Country.Americas.Any(c => c.CommonName == "Brazil"), Is.True);

    // ── Asia ─────────────────────────────────────────────────────────────────

    [Test]
    public void Asia_ShouldNotBeEmpty()
        => Assert.That(Country.Asia, Is.Not.Empty);

    [Test]
    public void Asia_AllShouldHaveCorrectRegion()
        => Assert.That(Country.Asia.All(c => c.Continent == "Asia"), Is.True);

    [Test]
    public void Asia_ShouldContainChina()
        => Assert.That(Country.Asia.Any(c => c.CountryCode == CountryCode.CN), Is.True);

    [Test]
    public void Asia_ShouldContainJapan()
        => Assert.That(Country.Asia.Any(c => c.CommonName == "Japan"), Is.True);

    // ── Europe ───────────────────────────────────────────────────────────────

    [Test]
    public void Europe_ShouldNotBeEmpty()
        => Assert.That(Country.Europe, Is.Not.Empty);

    [Test]
    public void Europe_AllShouldHaveCorrectRegion()
        => Assert.That(Country.Europe.All(c => c.Continent == "Europe"), Is.True);

    [Test]
    public void Europe_ShouldContainItaly()
        => Assert.That(Country.Europe.Any(c => c.CountryCode == CountryCode.IT), Is.True);

    [Test]
    public void Europe_ShouldContainGermany()
        => Assert.That(Country.Europe.Any(c => c.CommonName == "Germany"), Is.True);

    // ── Oceania ──────────────────────────────────────────────────────────────

    [Test]
    public void Oceania_ShouldNotBeEmpty()
        => Assert.That(Country.Oceania, Is.Not.Empty);

    [Test]
    public void Oceania_AllShouldHaveCorrectRegion()
        => Assert.That(Country.Oceania.All(c => c.Continent == "Oceania"), Is.True);

    [Test]
    public void Oceania_ShouldContainAustralia()
        => Assert.That(Country.Oceania.Any(c => c.CountryCode == CountryCode.AU), Is.True);

    // ── Partitioning ─────────────────────────────────────────────────────────

    [Test]
    public void ContinentCollections_ShouldNotOverlap()
    {
        var all = new[]
        {
            Country.Africa.Select(c => c.CountryCode),
            Country.Americas.Select(c => c.CountryCode),
            Country.Asia.Select(c => c.CountryCode),
            Country.Europe.Select(c => c.CountryCode),
            Country.Oceania.Select(c => c.CountryCode),
        }.SelectMany(x => x).ToList();

        Assert.That(all.Distinct().Count(), Is.EqualTo(all.Count),
            "A country appears in more than one continent collection");
    }

    [Test]
    public void ContinentCollections_SumShouldEqualAllCountriesWithRegion()
    {
        int continentTotal = Country.Africa.Count()
                           + Country.Americas.Count()
                           + Country.Asia.Count()
                           + Country.Europe.Count()
                           + Country.Oceania.Count();

        int allWithRegion = Country.All.Count(c => !string.IsNullOrEmpty(c.Continent));

        Assert.That(continentTotal, Is.EqualTo(allWithRegion));
    }
}
