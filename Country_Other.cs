namespace Countries;

public partial struct Country
{
    public static Country Antarctica
    {
        get
        {
            Country country = new()
            {
                CommonName = "Antarctica",
                OfficialName = "Antarctica",
                TLD = [".aq"],
                CountryCode = CountryCode.AQ,
                ISONumeric = "010",
                ISO3 = CountryCodeISO3.ATA,
                CIOC = "",
                Currencies = [],
                Capital = "",
                AlternativeSpellings = ["AQ"],
                Region = "",
                SubRegion = "",
                Borders = [],
                Landlocked = false,
                Area = 14000000.0
            };
            return country;
        }
    }

    public static Country FrenchSouthernandAntarcticLands
    {
        get
        {
            Country country = new()
            {
                CommonName = "French Southern and Antarctic Lands",
                OfficialName = "Territory of the French Southern and Antarctic Lands",
                TLD = [".tf"],
                CountryCode = CountryCode.TF,
                ISONumeric = "260",
                ISO3 = CountryCodeISO3.ATF,
                CIOC = "",
                Currencies = ["EUR"],
                Capital = "Port-aux-Français",
                AlternativeSpellings = ["TF", "French Southern Territories"],
                Region = "",
                SubRegion = "",
                Borders = [],
                Landlocked = false,
                Area = 7747.0
            };
            return country;
        }
    }

    public static Country BouvetIsland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bouvet Island",
                OfficialName = "Bouvet Island",
                TLD = [".bv"],
                CountryCode = CountryCode.BV,
                ISONumeric = "074",
                ISO3 = CountryCodeISO3.BVT,
                CIOC = "",
                Currencies = ["NOK"],
                Capital = "",
                AlternativeSpellings = ["BV", "Bouvetøya", "Bouvet-øya"],
                Region = "",
                SubRegion = "",
                Borders = [],
                Landlocked = false,
                Area = 49.0
            };
            return country;
        }
    }

    public static Country HeardIslandandMcDonaldIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Heard Island and McDonald Islands",
                OfficialName = "Heard Island and McDonald Islands",
                TLD = [".hm", ".aq"],
                CountryCode = CountryCode.HM,
                ISONumeric = "334",
                ISO3 = CountryCodeISO3.HMD,
                CIOC = "",
                Currencies = ["AUD"],
                Capital = "",
                AlternativeSpellings = ["HM", "Heard Island and McDonald Mcdonald Islands"],
                Region = "",
                SubRegion = "",
                Borders = [],
                Landlocked = false,
                Area = 412.0
            };
            return country;
        }
    }
}
