namespace Countries;

public partial struct Country
{
    public static Country ÅlandIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Åland Islands",
                OfficialName = "Åland Islands",
                TLD = [".ax"],
                CountryCode = CountryCode.AX,
                ISONumeric = "248",
                ISO3 = CountryCodeISO3.ALA,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["358"],
                Capital = "Mariehamn",
                AlternativeSpellings = ["AX", "Aaland", "Aland", "Ahvenanmaa"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = 1580.0
            };
            return country;
        }
    }

    public static Country Albania
    {
        get
        {
            Country country = new()
            {
                CommonName = "Albania",
                OfficialName = "Republic of Albania",
                TLD = [".al"],
                CountryCode = CountryCode.AL,
                ISONumeric = "008",
                ISO3 = CountryCodeISO3.ALB,
                CIOC = "ALB",
                Currencies = ["ALL"],
                CallingCodes = ["355"],
                Capital = "Tirana",
                AlternativeSpellings = ["AL", "Shqipëri", "Shqipëria", "Shqipnia"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.MNE,
                    CountryCodeISO3.GRC,
                    CountryCodeISO3.MKD,
                    CountryCodeISO3.KOS
                ],
                Landlocked = false,
                Area = 28748.0
            };
            return country;
        }
    }

    public static Country Andorra
    {
        get
        {
            Country country = new()
            {
                CommonName = "Andorra",
                OfficialName = "Principality of Andorra",
                TLD = [".ad"],
                CountryCode = CountryCode.AD,
                ISONumeric = "020",
                ISO3 = CountryCodeISO3.AND,
                CIOC = "AND",
                Currencies = ["EUR"],
                CallingCodes = ["376"],
                Capital = "Andorra la Vella",
                AlternativeSpellings = ["AD", "Principality of Andorra", "Principat d'Andorra"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.ESP
                ],
                Landlocked = true,
                Area = 468.0
            };
            return country;
        }
    }

    public static Country Austria
    {
        get
        {
            Country country = new()
            {
                CommonName = "Austria",
                OfficialName = "Republic of Austria",
                TLD = [".at"],
                CountryCode = CountryCode.AT,
                ISONumeric = "040",
                ISO3 = CountryCodeISO3.AUT,
                CIOC = "AUT",
                Currencies = ["EUR"],
                CallingCodes = ["43"],
                Capital = "Vienna",
                AlternativeSpellings = ["AT", "Osterreich", "Oesterreich"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.CZE,
                    CountryCodeISO3.DEU,
                    CountryCodeISO3.HUN,
                    CountryCodeISO3.ITA,
                    CountryCodeISO3.LIE,
                    CountryCodeISO3.SVK,
                    CountryCodeISO3.SVN,
                    CountryCodeISO3.CHE
                ],
                Landlocked = true,
                Area = 83871.0
            };
            return country;
        }
    }

    public static Country Belgium
    {
        get
        {
            Country country = new()
            {
                CommonName = "Belgium",
                OfficialName = "Kingdom of Belgium",
                TLD = [".be"],
                CountryCode = CountryCode.BE,
                ISONumeric = "056",
                ISO3 = CountryCodeISO3.BEL,
                CIOC = "BEL",
                Currencies = ["EUR"],
                CallingCodes = ["32"],
                Capital = "Brussels",
                AlternativeSpellings = ["BE", "België", "Belgie", "Belgien", "Belgique", "Kingdom of Belgium", "Koninkrijk België", "Royaume de Belgique", "Königreich Belgien"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.DEU,
                    CountryCodeISO3.LUX,
                    CountryCodeISO3.NLD
                ],
                Landlocked = false,
                Area = 30528.0
            };
            return country;
        }
    }

    public static Country Bulgaria
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bulgaria",
                OfficialName = "Republic of Bulgaria",
                TLD = [".bg"],
                CountryCode = CountryCode.BG,
                ISONumeric = "100",
                ISO3 = CountryCodeISO3.BGR,
                CIOC = "BUL",
                Currencies = ["BGN"],
                CallingCodes = ["359"],
                Capital = "Sofia",
                AlternativeSpellings = ["BG", "Republic of Bulgaria", "Република България"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.GRC,
                    CountryCodeISO3.MKD,
                    CountryCodeISO3.ROU,
                    CountryCodeISO3.SRB,
                    CountryCodeISO3.TUR
                ],
                Landlocked = false,
                Area = 110879.0
            };
            return country;
        }
    }

    public static Country BosniaandHerzegovina
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bosnia and Herzegovina",
                OfficialName = "Bosnia and Herzegovina",
                TLD = [".ba"],
                CountryCode = CountryCode.BA,
                ISONumeric = "070",
                ISO3 = CountryCodeISO3.BIH,
                CIOC = "BIH",
                Currencies = ["BAM"],
                CallingCodes = ["387"],
                Capital = "Sarajevo",
                AlternativeSpellings = ["BA", "Bosnia-Herzegovina", "Босна и Херцеговина"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.HRV,
                    CountryCodeISO3.MNE,
                    CountryCodeISO3.SRB
                ],
                Landlocked = false,
                Area = 51209.0
            };
            return country;
        }
    }

    public static Country Belarus
    {
        get
        {
            Country country = new()
            {
                CommonName = "Belarus",
                OfficialName = "Republic of Belarus",
                TLD = [".by"],
                CountryCode = CountryCode.BY,
                ISONumeric = "112",
                ISO3 = CountryCodeISO3.BLR,
                CIOC = "BLR",
                Currencies = ["BYR"],
                CallingCodes = ["375"],
                Capital = "Minsk",
                AlternativeSpellings = ["BY", "Bielaruś", "Republic of Belarus", "Белоруссия", "Республика Беларусь", "Belorussiya", "Respublika Belarus'"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.LVA,
                    CountryCodeISO3.LTU,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.UKR
                ],
                Landlocked = true,
                Area = 207600.0
            };
            return country;
        }
    }

    public static Country Switzerland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Switzerland",
                OfficialName = "Swiss Confederation",
                TLD = [".ch"],
                CountryCode = CountryCode.CH,
                ISONumeric = "756",
                ISO3 = CountryCodeISO3.CHE,
                CIOC = "SUI",
                Currencies = ["CHE", "CHF", "CHW"],
                CallingCodes = ["41"],
                Capital = "Bern",
                AlternativeSpellings = ["CH", "Swiss Confederation", "Schweiz", "Suisse", "Svizzera", "Svizra"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.ITA,
                    CountryCodeISO3.LIE,
                    CountryCodeISO3.DEU
                ],
                Landlocked = true,
                Area = 41284.0
            };
            return country;
        }
    }

    public static Country Cyprus
    {
        get
        {
            Country country = new()
            {
                CommonName = "Cyprus",
                OfficialName = "Republic of Cyprus",
                TLD = [".cy"],
                CountryCode = CountryCode.CY,
                ISONumeric = "196",
                ISO3 = CountryCodeISO3.CYP,
                CIOC = "CYP",
                Currencies = ["EUR"],
                CallingCodes = ["357"],
                Capital = "Nicosia",
                AlternativeSpellings = ["CY", "Kýpros", "Kıbrıs", "Republic of Cyprus", "Κυπριακή Δημοκρατία", "Kıbrıs Cumhuriyeti"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders = [CountryCodeISO3.GBR],
                Landlocked = false,
                Area = 9251.0
            };
            return country;
        }
    }

    public static Country CzechRepublic
    {
        get
        {
            Country country = new()
            {
                CommonName = "Czech Republic",
                OfficialName = "Czech Republic",
                TLD = [".cz"],
                CountryCode = CountryCode.CZ,
                ISONumeric = "203",
                ISO3 = CountryCodeISO3.CZE,
                CIOC = "CZE",
                Currencies = ["CZK"],
                CallingCodes = ["420"],
                Capital = "Prague",
                AlternativeSpellings = ["CZ", "Česká republika", "Česko"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.DEU,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.SVK
                ],
                Landlocked = true,
                Area = 78865.0
            };
            return country;
        }
    }

    public static Country Germany
    {
        get
        {
            Country country = new()
            {
                CommonName = "Germany",
                OfficialName = "Federal Republic of Germany",
                TLD = [".de"],
                CountryCode = CountryCode.DE,
                ISONumeric = "276",
                ISO3 = CountryCodeISO3.DEU,
                CIOC = "GER",
                Currencies = ["EUR"],
                CallingCodes = ["49"],
                Capital = "Berlin",
                AlternativeSpellings = ["DE", "Federal Republic of Germany", "Bundesrepublik Deutschland"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.BEL,
                    CountryCodeISO3.CZE,
                    CountryCodeISO3.DNK,
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.LUX,
                    CountryCodeISO3.NLD,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.CHE
                ],
                Landlocked = false,
                Area = 357114.0
            };
            return country;
        }
    }

    public static Country Denmark
    {
        get
        {
            Country country = new()
            {
                CommonName = "Denmark",
                OfficialName = "Kingdom of Denmark",
                TLD = [".dk"],
                CountryCode = CountryCode.DK,
                ISONumeric = "208",
                ISO3 = CountryCodeISO3.DNK,
                CIOC = "DEN",
                Currencies = ["DKK"],
                CallingCodes = ["45"],
                Capital = "Copenhagen",
                AlternativeSpellings = ["DK", "Danmark", "Kingdom of Denmark", "Kongeriget Danmark"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [CountryCodeISO3.DEU],
                Landlocked = false,
                Area = 43094.0
            };
            return country;
        }
    }

    public static Country Spain
    {
        get
        {
            Country country = new()
            {
                CommonName = "Spain",
                OfficialName = "Kingdom of Spain",
                TLD = [".es"],
                CountryCode = CountryCode.ES,
                ISONumeric = "724",
                ISO3 = CountryCodeISO3.ESP,
                CIOC = "ESP",
                Currencies = ["EUR"],
                CallingCodes = ["34"],
                Capital = "Madrid",
                AlternativeSpellings = ["ES", "Kingdom of Spain", "Reino de España"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.AND,
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.GIB,
                    CountryCodeISO3.PRT,
                    CountryCodeISO3.MAR
                ],
                Landlocked = false,
                Area = 505992.0
            };
            return country;
        }
    }

    public static Country Estonia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Estonia",
                OfficialName = "Republic of Estonia",
                TLD = [".ee"],
                CountryCode = CountryCode.EE,
                ISONumeric = "233",
                ISO3 = CountryCodeISO3.EST,
                CIOC = "EST",
                Currencies = ["EUR"],
                CallingCodes = ["372"],
                Capital = "Tallinn",
                AlternativeSpellings = ["EE", "Eesti", "Republic of Estonia", "Eesti Vabariik"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders =
                [
                    CountryCodeISO3.LVA,
                    CountryCodeISO3.RUS
                ],
                Landlocked = false,
                Area = 45227.0
            };
            return country;
        }
    }

    public static Country Finland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Finland",
                OfficialName = "Republic of Finland",
                TLD = [".fi"],
                CountryCode = CountryCode.FI,
                ISONumeric = "246",
                ISO3 = CountryCodeISO3.FIN,
                CIOC = "FIN",
                Currencies = ["EUR"],
                CallingCodes = ["358"],
                Capital = "Helsinki",
                AlternativeSpellings = ["FI", "Suomi", "Republic of Finland", "Suomen tasavalta", "Republiken Finland"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders =
                [
                    CountryCodeISO3.NOR,
                    CountryCodeISO3.SWE,
                    CountryCodeISO3.RUS
                ],
                Landlocked = false,
                Area = 338424.0
            };
            return country;
        }
    }

    public static Country France
    {
        get
        {
            Country country = new()
            {
                CommonName = "France",
                OfficialName = "French Republic",
                TLD = [".fr"],
                CountryCode = CountryCode.FR,
                ISONumeric = "250",
                ISO3 = CountryCodeISO3.FRA,
                CIOC = "FRA",
                Currencies = ["EUR"],
                CallingCodes = ["33"],
                Capital = "Paris",
                AlternativeSpellings = ["FR", "French Republic", "République française"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.AND,
                    CountryCodeISO3.BEL,
                    CountryCodeISO3.DEU,
                    CountryCodeISO3.ITA,
                    CountryCodeISO3.LUX,
                    CountryCodeISO3.MCO,
                    CountryCodeISO3.ESP,
                    CountryCodeISO3.CHE
                ],
                Landlocked = false,
                Area = 551695.0
            };
            return country;
        }
    }

    public static Country FaroeIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Faroe Islands",
                OfficialName = "Faroe Islands",
                TLD = [".fo"],
                CountryCode = CountryCode.FO,
                ISONumeric = "234",
                ISO3 = CountryCodeISO3.FRO,
                CIOC = "",
                Currencies = ["DKK"],
                CallingCodes = ["298"],
                Capital = "Tórshavn",
                AlternativeSpellings = ["FO", "Føroyar", "Færøerne"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = 1393.0
            };
            return country;
        }
    }

    public static Country UnitedKingdom
    {
        get
        {
            Country country = new()
            {
                CommonName = "United Kingdom",
                OfficialName = "United Kingdom of Great Britain and Northern Ireland",
                TLD = [".uk"],
                CountryCode = CountryCode.GB,
                ISONumeric = "826",
                ISO3 = CountryCodeISO3.GBR,
                CIOC = "GBR",
                Currencies = ["GBP"],
                CallingCodes = ["44"],
                Capital = "London",
                AlternativeSpellings = ["GB", "UK", "Great Britain"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [CountryCodeISO3.IRL],
                Landlocked = false,
                Area = 242900.0
            };
            return country;
        }
    }

    public static Country Guernsey
    {
        get
        {
            Country country = new()
            {
                CommonName = "Guernsey",
                OfficialName = "Bailiwick of Guernsey",
                TLD = [".gg"],
                CountryCode = CountryCode.GG,
                ISONumeric = "831",
                ISO3 = CountryCodeISO3.GGY,
                CIOC = "",
                Currencies = ["GBP"],
                CallingCodes = ["44"],
                Capital = "St. Peter Port",
                AlternativeSpellings = ["GG", "Bailiwick of Guernsey", "Bailliage de Guernesey"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = 78.0
            };
            return country;
        }
    }

    public static Country Gibraltar
    {
        get
        {
            Country country = new()
            {
                CommonName = "Gibraltar",
                OfficialName = "Gibraltar",
                TLD = [".gi"],
                CountryCode = CountryCode.GI,
                ISONumeric = "292",
                ISO3 = CountryCodeISO3.GIB,
                CIOC = "",
                Currencies = ["GIP"],
                CallingCodes = ["350"],
                Capital = "Gibraltar",
                AlternativeSpellings = ["GI"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders = [CountryCodeISO3.ESP],
                Landlocked = false,
                Area = 6.0
            };
            return country;
        }
    }

    public static Country Greece
    {
        get
        {
            Country country = new()
            {
                CommonName = "Greece",
                OfficialName = "Hellenic Republic",
                TLD = [".gr"],
                CountryCode = CountryCode.GR,
                ISONumeric = "300",
                ISO3 = CountryCodeISO3.GRC,
                CIOC = "GRE",
                Currencies = ["EUR"],
                CallingCodes = ["30"],
                Capital = "Athens",
                AlternativeSpellings = ["GR", "Elláda", "Hellenic Republic", "Ελληνική Δημοκρατία"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.ALB,
                    CountryCodeISO3.BGR,
                    CountryCodeISO3.TUR,
                    CountryCodeISO3.MKD
                ],
                Landlocked = false,
                Area = 131990.0
            };
            return country;
        }
    }

    public static Country Croatia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Croatia",
                OfficialName = "Republic of Croatia",
                TLD = [".hr"],
                CountryCode = CountryCode.HR,
                ISONumeric = "191",
                ISO3 = CountryCodeISO3.HRV,
                CIOC = "CRO",
                Currencies = ["HRK"],
                CallingCodes = ["385"],
                Capital = "Zagreb",
                AlternativeSpellings = ["HR", "Hrvatska", "Republic of Croatia", "Republika Hrvatska"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.BIH,
                    CountryCodeISO3.HUN,
                    CountryCodeISO3.MNE,
                    CountryCodeISO3.SRB,
                    CountryCodeISO3.SVN
                ],
                Landlocked = false,
                Area = 56594.0
            };
            return country;
        }
    }

    public static Country Hungary
    {
        get
        {
            Country country = new()
            {
                CommonName = "Hungary",
                OfficialName = "Hungary",
                TLD = [".hu"],
                CountryCode = CountryCode.HU,
                ISONumeric = "348",
                ISO3 = CountryCodeISO3.HUN,
                CIOC = "HUN",
                Currencies = ["HUF"],
                CallingCodes = ["36"],
                Capital = "Budapest",
                AlternativeSpellings = ["HU"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.HRV,
                    CountryCodeISO3.ROU,
                    CountryCodeISO3.SRB,
                    CountryCodeISO3.SVK,
                    CountryCodeISO3.SVN,
                    CountryCodeISO3.UKR
                ],
                Landlocked = true,
                Area = 93028.0
            };
            return country;
        }
    }

    public static Country IsleofMan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Isle of Man",
                OfficialName = "Isle of Man",
                TLD = [".im"],
                CountryCode = CountryCode.IM,
                ISONumeric = "833",
                ISO3 = CountryCodeISO3.IMN,
                CIOC = "",
                Currencies = ["GBP"],
                CallingCodes = ["44"],
                Capital = "Douglas",
                AlternativeSpellings = ["IM", "Ellan Vannin", "Mann", "Mannin"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = 572.0
            };
            return country;
        }
    }

    public static Country Ireland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Ireland",
                OfficialName = "Republic of Ireland",
                TLD = [".ie"],
                CountryCode = CountryCode.IE,
                ISONumeric = "372",
                ISO3 = CountryCodeISO3.IRL,
                CIOC = "IRL",
                Currencies = ["EUR"],
                CallingCodes = ["353"],
                Capital = "Dublin",
                AlternativeSpellings = ["IE", "Éire", "Republic of Ireland", "Poblacht na hÉireann"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [CountryCodeISO3.GBR],
                Landlocked = false,
                Area = 70273.0
            };
            return country;
        }
    }

    public static Country Iceland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Iceland",
                OfficialName = "Iceland",
                TLD = [".is"],
                CountryCode = CountryCode.IS,
                ISONumeric = "352",
                ISO3 = CountryCodeISO3.ISL,
                CIOC = "ISL",
                Currencies = ["ISK"],
                CallingCodes = ["354"],
                Capital = "Reykjavik",
                AlternativeSpellings = ["IS", "Island", "Republic of Iceland", "Lýðveldið Ísland"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = 103000.0
            };
            return country;
        }
    }

    public static Country Italy
    {
        get
        {
            Country country = new()
            {
                CommonName = "Italy",
                OfficialName = "Italian Republic",
                TLD = [".it"],
                CountryCode = CountryCode.IT,
                ISONumeric = "380",
                ISO3 = CountryCodeISO3.ITA,
                CIOC = "ITA",
                Currencies = ["EUR"],
                CallingCodes = ["39"],
                Capital = "Rome",
                AlternativeSpellings = ["IT", "Italian Republic", "Repubblica italiana"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.SMR,
                    CountryCodeISO3.SVN,
                    CountryCodeISO3.CHE,
                    CountryCodeISO3.VAT
                ],
                Landlocked = false,
                Area = 301336.0
            };
            return country;
        }
    }

    public static Country Jersey
    {
        get
        {
            Country country = new()
            {
                CommonName = "Jersey",
                OfficialName = "Bailiwick of Jersey",
                TLD = [".je"],
                CountryCode = CountryCode.JE,
                ISONumeric = "832",
                ISO3 = CountryCodeISO3.JEY,
                CIOC = "",
                Currencies = ["GBP"],
                CallingCodes = ["44"],
                Capital = "Saint Helier",
                AlternativeSpellings = ["JE", "Bailiwick of Jersey", "Bailliage de Jersey", "Bailliage dé Jèrri"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = 116.0
            };
            return country;
        }
    }

    public static Country Kosovo
    {
        get
        {
            Country country = new()
            {
                CommonName = "Kosovo",
                OfficialName = "Republic of Kosovo",
                TLD = [],
                CountryCode = CountryCode.XK,
                ISONumeric = "",
                ISO3 = CountryCodeISO3.KOS,
                CIOC = "KOS",
                Currencies = ["EUR"],
                CallingCodes = ["383"],
                Capital = "Pristina",
                AlternativeSpellings = ["XK", "Република Косово"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.ALB,
                    CountryCodeISO3.MKD,
                    CountryCodeISO3.MNE,
                    CountryCodeISO3.SRB
                ],
                Landlocked = true,
                Area = 10908.0
            };
            return country;
        }
    }

    public static Country Liechtenstein
    {
        get
        {
            Country country = new()
            {
                CommonName = "Liechtenstein",
                OfficialName = "Principality of Liechtenstein",
                TLD = [".li"],
                CountryCode = CountryCode.LI,
                ISONumeric = "438",
                ISO3 = CountryCodeISO3.LIE,
                CIOC = "LIE",
                Currencies = ["CHF"],
                CallingCodes = ["423"],
                Capital = "Vaduz",
                AlternativeSpellings = ["LI", "Principality of Liechtenstein", "Fürstentum Liechtenstein"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.CHE
                ],
                Landlocked = true,
                Area = 160.0
            };
            return country;
        }
    }

    public static Country Lithuania
    {
        get
        {
            Country country = new()
            {
                CommonName = "Lithuania",
                OfficialName = "Republic of Lithuania",
                TLD = [".lt"],
                CountryCode = CountryCode.LT,
                ISONumeric = "440",
                ISO3 = CountryCodeISO3.LTU,
                CIOC = "LTU",
                Currencies = ["EUR"],
                CallingCodes = ["370"],
                Capital = "Vilnius",
                AlternativeSpellings = ["LT", "Republic of Lithuania", "Lietuvos Respublika"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders =
                [
                    CountryCodeISO3.BLR,
                    CountryCodeISO3.LVA,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.RUS
                ],
                Landlocked = false,
                Area = 65300.0
            };
            return country;
        }
    }

    public static Country Luxembourg
    {
        get
        {
            Country country = new()
            {
                CommonName = "Luxembourg",
                OfficialName = "Grand Duchy of Luxembourg",
                TLD = [".lu"],
                CountryCode = CountryCode.LU,
                ISONumeric = "442",
                ISO3 = CountryCodeISO3.LUX,
                CIOC = "LUX",
                Currencies = ["EUR"],
                CallingCodes = ["352"],
                Capital = "Luxembourg",
                AlternativeSpellings = ["LU", "Grand Duchy of Luxembourg", "Grand-Duché de Luxembourg", "Großherzogtum Luxemburg", "Groussherzogtum Lëtzebuerg"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.BEL,
                    CountryCodeISO3.FRA,
                    CountryCodeISO3.DEU
                ],
                Landlocked = true,
                Area = 2586.0
            };
            return country;
        }
    }

    public static Country Latvia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Latvia",
                OfficialName = "Republic of Latvia",
                TLD = [".lv"],
                CountryCode = CountryCode.LV,
                ISONumeric = "428",
                ISO3 = CountryCodeISO3.LVA,
                CIOC = "LAT",
                Currencies = ["EUR"],
                CallingCodes = ["371"],
                Capital = "Riga",
                AlternativeSpellings = ["LV", "Republic of Latvia", "Latvijas Republika"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders =
                [
                    CountryCodeISO3.BLR,
                    CountryCodeISO3.EST,
                    CountryCodeISO3.LTU,
                    CountryCodeISO3.RUS
                ],
                Landlocked = false,
                Area = 64559.0
            };
            return country;
        }
    }

    public static Country Monaco
    {
        get
        {
            Country country = new()
            {
                CommonName = "Monaco",
                OfficialName = "Principality of Monaco",
                TLD = [".mc"],
                CountryCode = CountryCode.MC,
                ISONumeric = "492",
                ISO3 = CountryCodeISO3.MCO,
                CIOC = "MON",
                Currencies = ["EUR"],
                CallingCodes = ["377"],
                Capital = "Monaco",
                AlternativeSpellings = ["MC", "Principality of Monaco", "Principauté de Monaco"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders = [CountryCodeISO3.FRA],
                Landlocked = false,
                Area = 2.0
            };
            return country;
        }
    }

    public static Country Moldova
    {
        get
        {
            Country country = new()
            {
                CommonName = "Moldova",
                OfficialName = "Republic of Moldova",
                TLD = [".md"],
                CountryCode = CountryCode.MD,
                ISONumeric = "498",
                ISO3 = CountryCodeISO3.MDA,
                CIOC = "MDA",
                Currencies = ["MDL"],
                CallingCodes = ["373"],
                Capital = "Chișinău",
                AlternativeSpellings = ["MD", "Moldova, Republic of", "Republic of Moldova", "Republica Moldova"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.ROU,
                    CountryCodeISO3.UKR
                ],
                Landlocked = true,
                Area = 33846.0
            };
            return country;
        }
    }

    public static Country Macedonia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Macedonia",
                OfficialName = "Republic of Macedonia",
                TLD = [".mk"],
                CountryCode = CountryCode.MK,
                ISONumeric = "807",
                ISO3 = CountryCodeISO3.MKD,
                CIOC = "MKD",
                Currencies = ["MKD"],
                CallingCodes = ["389"],
                Capital = "Skopje",
                AlternativeSpellings = ["MK", "Macedonia, the Former Yugoslav Republic of", "Republic of Macedonia", "Република Македонија"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.ALB,
                    CountryCodeISO3.BGR,
                    CountryCodeISO3.GRC,
                    CountryCodeISO3.KOS,
                    CountryCodeISO3.SRB
                ],
                Landlocked = true,
                Area = 25713.0
            };
            return country;
        }
    }

    public static Country Malta
    {
        get
        {
            Country country = new()
            {
                CommonName = "Malta",
                OfficialName = "Republic of Malta",
                TLD = [".mt"],
                CountryCode = CountryCode.MT,
                ISONumeric = "470",
                ISO3 = CountryCodeISO3.MLT,
                CIOC = "MLT",
                Currencies = ["EUR"],
                CallingCodes = ["356"],
                Capital = "Valletta",
                AlternativeSpellings = ["MT", "Republic of Malta", "Repubblika ta' Malta"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders = [],
                Landlocked = false,
                Area = 316.0
            };
            return country;
        }
    }

    public static Country Montenegro
    {
        get
        {
            Country country = new()
            {
                CommonName = "Montenegro",
                OfficialName = "Montenegro",
                TLD = [".me"],
                CountryCode = CountryCode.ME,
                ISONumeric = "499",
                ISO3 = CountryCodeISO3.MNE,
                CIOC = "MNE",
                Currencies = ["EUR"],
                CallingCodes = ["382"],
                Capital = "Podgorica",
                AlternativeSpellings = ["ME", "Crna Gora"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.ALB,
                    CountryCodeISO3.BIH,
                    CountryCodeISO3.HRV,
                    CountryCodeISO3.KOS,
                    CountryCodeISO3.SRB
                ],
                Landlocked = false,
                Area = 13812.0
            };
            return country;
        }
    }

    public static Country Netherlands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Netherlands",
                OfficialName = "Netherlands",
                TLD = [".nl"],
                CountryCode = CountryCode.NL,
                ISONumeric = "528",
                ISO3 = CountryCodeISO3.NLD,
                CIOC = "NED",
                Currencies = ["EUR"],
                CallingCodes = ["31"],
                Capital = "Amsterdam",
                AlternativeSpellings = ["NL", "Holland", "Nederland"],
                Region = "Europe",
                SubRegion = "Western Europe",
                Borders =
                [
                    CountryCodeISO3.BEL,
                    CountryCodeISO3.DEU
                ],
                Landlocked = false,
                Area = 41850.0
            };
            return country;
        }
    }

    public static Country Norway
    {
        get
        {
            Country country = new()
            {
                CommonName = "Norway",
                OfficialName = "Kingdom of Norway",
                TLD = [".no"],
                CountryCode = CountryCode.NO,
                ISONumeric = "578",
                ISO3 = CountryCodeISO3.NOR,
                CIOC = "NOR",
                Currencies = ["NOK"],
                CallingCodes = ["47"],
                Capital = "Oslo",
                AlternativeSpellings = ["NO", "Norge", "Noreg", "Kingdom of Norway", "Kongeriket Norge", "Kongeriket Noreg"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders =
                [
                    CountryCodeISO3.FIN,
                    CountryCodeISO3.SWE,
                    CountryCodeISO3.RUS
                ],
                Landlocked = false,
                Area = 323802.0
            };
            return country;
        }
    }

    public static Country Poland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Poland",
                OfficialName = "Republic of Poland",
                TLD = [".pl"],
                CountryCode = CountryCode.PL,
                ISONumeric = "616",
                ISO3 = CountryCodeISO3.POL,
                CIOC = "POL",
                Currencies = ["PLN"],
                CallingCodes = ["48"],
                Capital = "Warsaw",
                AlternativeSpellings = ["PL", "Republic of Poland", "Rzeczpospolita Polska"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.BLR,
                    CountryCodeISO3.CZE,
                    CountryCodeISO3.DEU,
                    CountryCodeISO3.LTU,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.SVK,
                    CountryCodeISO3.UKR
                ],
                Landlocked = false,
                Area = 312679.0
            };
            return country;
        }
    }

    public static Country Portugal
    {
        get
        {
            Country country = new()
            {
                CommonName = "Portugal",
                OfficialName = "Portuguese Republic",
                TLD = [".pt"],
                CountryCode = CountryCode.PT,
                ISONumeric = "620",
                ISO3 = CountryCodeISO3.PRT,
                CIOC = "POR",
                Currencies = ["EUR"],
                CallingCodes = ["351"],
                Capital = "Lisbon",
                AlternativeSpellings = ["PT", "Portuguesa", "Portuguese Republic", "República Portuguesa"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders = [CountryCodeISO3.ESP],
                Landlocked = false,
                Area = 92090.0
            };
            return country;
        }
    }

    public static Country Romania
    {
        get
        {
            Country country = new()
            {
                CommonName = "Romania",
                OfficialName = "Romania",
                TLD = [".ro"],
                CountryCode = CountryCode.RO,
                ISONumeric = "642",
                ISO3 = CountryCodeISO3.ROU,
                CIOC = "ROU",
                Currencies = ["RON"],
                CallingCodes = ["40"],
                Capital = "Bucharest",
                AlternativeSpellings = ["RO", "Rumania", "Roumania", "România"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.BGR,
                    CountryCodeISO3.HUN,
                    CountryCodeISO3.MDA,
                    CountryCodeISO3.SRB,
                    CountryCodeISO3.UKR
                ],
                Landlocked = false,
                Area = 238391.0
            };
            return country;
        }
    }

    public static Country Russia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Russia",
                OfficialName = "Russian Federation",
                TLD = [".ru", ".su", ".рф"],
                CountryCode = CountryCode.RU,
                ISONumeric = "643",
                ISO3 = CountryCodeISO3.RUS,
                CIOC = "RUS",
                Currencies = ["RUB"],
                CallingCodes = ["7"],
                Capital = "Moscow",
                AlternativeSpellings = ["RU", "Rossiya", "Russian Federation", "Российская Федерация", "Rossiyskaya Federatsiya"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.AZE,
                    CountryCodeISO3.BLR,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.EST,
                    CountryCodeISO3.FIN,
                    CountryCodeISO3.GEO,
                    CountryCodeISO3.KAZ,
                    CountryCodeISO3.PRK,
                    CountryCodeISO3.LVA,
                    CountryCodeISO3.LTU,
                    CountryCodeISO3.MNG,
                    CountryCodeISO3.NOR,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.UKR
                ],
                Landlocked = false,
                Area = 17098242.0
            };
            return country;
        }
    }

    public static Country SanMarino
    {
        get
        {
            Country country = new()
            {
                CommonName = "San Marino",
                OfficialName = "Most Serene Republic of San Marino",
                TLD = [".sm"],
                CountryCode = CountryCode.SM,
                ISONumeric = "674",
                ISO3 = CountryCodeISO3.SMR,
                CIOC = "SMR",
                Currencies = ["EUR"],
                CallingCodes = ["378"],
                Capital = "City of San Marino",
                AlternativeSpellings = ["SM", "Republic of San Marino", "Repubblica di San Marino"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders = [CountryCodeISO3.ITA],
                Landlocked = true,
                Area = 61.0
            };
            return country;
        }
    }

    public static Country Serbia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Serbia",
                OfficialName = "Republic of Serbia",
                TLD = [".rs", ".срб"],
                CountryCode = CountryCode.RS,
                ISONumeric = "688",
                ISO3 = CountryCodeISO3.SRB,
                CIOC = "SRB",
                Currencies = ["RSD"],
                CallingCodes = ["381"],
                Capital = "Belgrade",
                AlternativeSpellings = ["RS", "Srbija", "Republic of Serbia", "Република Србија", "Republika Srbija"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.BIH,
                    CountryCodeISO3.BGR,
                    CountryCodeISO3.HRV,
                    CountryCodeISO3.HUN,
                    CountryCodeISO3.KOS,
                    CountryCodeISO3.MKD,
                    CountryCodeISO3.MNE,
                    CountryCodeISO3.ROU
                ],
                Landlocked = true,
                Area = 88361.0
            };
            return country;
        }
    }

    public static Country SvalbardandJanMayen
    {
        get
        {
            Country country = new()
            {
                CommonName = "Svalbard and Jan Mayen",
                OfficialName = "Svalbard og Jan Mayen",
                TLD = [".sj"],
                CountryCode = CountryCode.SJ,
                ISONumeric = "744",
                ISO3 = CountryCodeISO3.SJM,
                CIOC = "",
                Currencies = ["NOK"],
                CallingCodes = ["4779"],
                Capital = "Longyearbyen",
                AlternativeSpellings = ["SJ", "Svalbard and Jan Mayen Islands"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders = [],
                Landlocked = false,
                Area = -1.0
            };
            return country;
        }
    }

    public static Country Slovakia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Slovakia",
                OfficialName = "Slovak Republic",
                TLD = [".sk"],
                CountryCode = CountryCode.SK,
                ISONumeric = "703",
                ISO3 = CountryCodeISO3.SVK,
                CIOC = "SVK",
                Currencies = ["EUR"],
                CallingCodes = ["421"],
                Capital = "Bratislava",
                AlternativeSpellings = ["SK", "Slovak Republic", "Slovenská republika"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.CZE,
                    CountryCodeISO3.HUN,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.UKR
                ],
                Landlocked = true,
                Area = 49037.0
            };
            return country;
        }
    }

    public static Country Slovenia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Slovenia",
                OfficialName = "Republic of Slovenia",
                TLD = [".si"],
                CountryCode = CountryCode.SI,
                ISONumeric = "705",
                ISO3 = CountryCodeISO3.SVN,
                CIOC = "SLO",
                Currencies = ["EUR"],
                CallingCodes = ["386"],
                Capital = "Ljubljana",
                AlternativeSpellings = ["SI", "Republic of Slovenia", "Republika Slovenija"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders =
                [
                    CountryCodeISO3.AUT,
                    CountryCodeISO3.HRV,
                    CountryCodeISO3.ITA,
                    CountryCodeISO3.HUN
                ],
                Landlocked = false,
                Area = 20273.0
            };
            return country;
        }
    }

    public static Country Sweden
    {
        get
        {
            Country country = new()
            {
                CommonName = "Sweden",
                OfficialName = "Kingdom of Sweden",
                TLD = [".se"],
                CountryCode = CountryCode.SE,
                ISONumeric = "752",
                ISO3 = CountryCodeISO3.SWE,
                CIOC = "SWE",
                Currencies = ["SEK"],
                CallingCodes = ["46"],
                Capital = "Stockholm",
                AlternativeSpellings = ["SE", "Kingdom of Sweden", "Konungariket Sverige"],
                Region = "Europe",
                SubRegion = "Northern Europe",
                Borders =
                [
                    CountryCodeISO3.FIN,
                    CountryCodeISO3.NOR
                ],
                Landlocked = false,
                Area = 450295.0
            };
            return country;
        }
    }

    public static Country Ukraine
    {
        get
        {
            Country country = new()
            {
                CommonName = "Ukraine",
                OfficialName = "Ukraine",
                TLD = [".ua", ".укр"],
                CountryCode = CountryCode.UA,
                ISONumeric = "804",
                ISO3 = CountryCodeISO3.UKR,
                CIOC = "UKR",
                Currencies = ["UAH"],
                CallingCodes = ["380"],
                Capital = "Kiev",
                AlternativeSpellings = ["UA", "Ukrayina"],
                Region = "Europe",
                SubRegion = "Eastern Europe",
                Borders =
                [
                    CountryCodeISO3.BLR,
                    CountryCodeISO3.HUN,
                    CountryCodeISO3.MDA,
                    CountryCodeISO3.POL,
                    CountryCodeISO3.ROU,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.SVK
                ],
                Landlocked = false,
                Area = 603500.0
            };
            return country;
        }
    }

    public static Country VaticanCity
    {
        get
        {
            Country country = new()
            {
                CommonName = "Vatican City",
                OfficialName = "Vatican City State",
                TLD = [".va"],
                CountryCode = CountryCode.VA,
                ISONumeric = "336",
                ISO3 = CountryCodeISO3.VAT,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["3906698", "379"],
                Capital = "Vatican City",
                AlternativeSpellings = ["VA", "Holy See (Vatican City State)", "Vatican City State", "Stato della Città del Vaticano"],
                Region = "Europe",
                SubRegion = "Southern Europe",
                Borders = [CountryCodeISO3.ITA],
                Landlocked = true,
                Area = 0.0
            };
            return country;
        }
    }
}
