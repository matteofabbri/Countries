namespace Countries;

public partial struct Country
{
    public static Country Angola
    {
        get
        {
            Country country = new()
            {
                CommonName = "Angola",
                OfficialName = "Republic of Angola",
                TLD = [".ao"],
                CountryCode = CountryCode.AO,
                ISONumeric = "024",
                ISO3 = CountryCodeISO3.AGO,
                CIOC = "ANG",
                Currencies = ["AOA"],
                CallingCodes = ["244"],
                Capital = "Luanda",
                AlternativeSpellings = ["AO", "República de Angola", "ʁɛpublika de an'ɡɔla"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.COG,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.ZMB,
                    CountryCodeISO3.NAM
                ],
                Landlocked = false,
                Area = 1246700.0
            };
            return country;
        }
    }

    public static Country Burundi
    {
        get
        {
            Country country = new()
            {
                CommonName = "Burundi",
                OfficialName = "Republic of Burundi",
                TLD = [".bi"],
                CountryCode = CountryCode.BI,
                ISONumeric = "108",
                ISO3 = CountryCodeISO3.BDI,
                CIOC = "BDI",
                Currencies = ["BIF"],
                CallingCodes = ["257"],
                Capital = "Bujumbura",
                AlternativeSpellings = ["BI", "Republic of Burundi", "Republika y'Uburundi", "République du Burundi"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.COD,
                    CountryCodeISO3.RWA,
                    CountryCodeISO3.TZA
                ],
                Landlocked = true,
                Area = 27834.0
            };
            return country;
        }
    }

    public static Country Benin
    {
        get
        {
            Country country = new()
            {
                CommonName = "Benin",
                OfficialName = "Republic of Benin",
                TLD = [".bj"],
                CountryCode = CountryCode.BJ,
                ISONumeric = "204",
                ISO3 = CountryCodeISO3.BEN,
                CIOC = "BEN",
                Currencies = ["XOF"],
                CallingCodes = ["229"],
                Capital = "Porto-Novo",
                AlternativeSpellings = ["BJ", "Republic of Benin", "République du Bénin"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.BFA,
                    CountryCodeISO3.NER,
                    CountryCodeISO3.NGA,
                    CountryCodeISO3.TGO
                ],
                Landlocked = false,
                Area = 112622.0
            };
            return country;
        }
    }

    public static Country BurkinaFaso
    {
        get
        {
            Country country = new()
            {
                CommonName = "Burkina Faso",
                OfficialName = "Burkina Faso",
                TLD = [".bf"],
                CountryCode = CountryCode.BF,
                ISONumeric = "854",
                ISO3 = CountryCodeISO3.BFA,
                CIOC = "BUR",
                Currencies = ["XOF"],
                CallingCodes = ["226"],
                Capital = "Ouagadougou",
                AlternativeSpellings = ["BF"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.BEN,
                    CountryCodeISO3.CIV,
                    CountryCodeISO3.GHA,
                    CountryCodeISO3.MLI,
                    CountryCodeISO3.NER,
                    CountryCodeISO3.TGO
                ],
                Landlocked = true,
                Area = 272967.0
            };
            return country;
        }
    }

    public static Country Botswana
    {
        get
        {
            Country country = new()
            {
                CommonName = "Botswana",
                OfficialName = "Republic of Botswana",
                TLD = [".bw"],
                CountryCode = CountryCode.BW,
                ISONumeric = "072",
                ISO3 = CountryCodeISO3.BWA,
                CIOC = "BOT",
                Currencies = ["BWP"],
                CallingCodes = ["267"],
                Capital = "Gaborone",
                AlternativeSpellings = ["BW", "Republic of Botswana", "Lefatshe la Botswana"],
                Continent = Continent.Africa,
                Region = "Southern Africa",
                Borders =
                [
                    CountryCodeISO3.NAM,
                    CountryCodeISO3.ZAF,
                    CountryCodeISO3.ZMB,
                    CountryCodeISO3.ZWE
                ],
                Landlocked = true,
                Area = 582000.0
            };
            return country;
        }
    }

    public static Country CentralAfricanRepublic
    {
        get
        {
            Country country = new()
            {
                CommonName = "Central African Republic",
                OfficialName = "Central African Republic",
                TLD = [".cf"],
                CountryCode = CountryCode.CF,
                ISONumeric = "140",
                ISO3 = CountryCodeISO3.CAF,
                CIOC = "CAF",
                Currencies = ["XAF"],
                CallingCodes = ["236"],
                Capital = "Bangui",
                AlternativeSpellings = ["CF", "Central African Republic", "République centrafricaine"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.CMR,
                    CountryCodeISO3.TCD,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.COG,
                    CountryCodeISO3.SSD,
                    CountryCodeISO3.SDN
                ],
                Landlocked = true,
                Area = 622984.0
            };
            return country;
        }
    }

    public static Country IvoryCoast
    {
        get
        {
            Country country = new()
            {
                CommonName = "Ivory Coast",
                OfficialName = "Republic of Côte d'Ivoire",
                TLD = [".ci"],
                CountryCode = CountryCode.CI,
                ISONumeric = "384",
                ISO3 = CountryCodeISO3.CIV,
                CIOC = "CIV",
                Currencies = ["XOF"],
                CallingCodes = ["225"],
                Capital = "Yamoussoukro",
                AlternativeSpellings = ["CI", "Côte d'Ivoire", "Ivory Coast", "Republic of Côte d'Ivoire", "République de Côte d'Ivoire"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.BFA,
                    CountryCodeISO3.GHA,
                    CountryCodeISO3.GIN,
                    CountryCodeISO3.LBR,
                    CountryCodeISO3.MLI
                ],
                Landlocked = false,
                Area = 322463.0
            };
            return country;
        }
    }

    public static Country Cameroon
    {
        get
        {
            Country country = new()
            {
                CommonName = "Cameroon",
                OfficialName = "Republic of Cameroon",
                TLD = [".cm"],
                CountryCode = CountryCode.CM,
                ISONumeric = "120",
                ISO3 = CountryCodeISO3.CMR,
                CIOC = "CMR",
                Currencies = ["XAF"],
                CallingCodes = ["237"],
                Capital = "Yaoundé",
                AlternativeSpellings = ["CM", "Republic of Cameroon", "République du Cameroun"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.CAF,
                    CountryCodeISO3.TCD,
                    CountryCodeISO3.COG,
                    CountryCodeISO3.GNQ,
                    CountryCodeISO3.GAB,
                    CountryCodeISO3.NGA
                ],
                Landlocked = false,
                Area = 475442.0
            };
            return country;
        }
    }

    public static Country DRCongo
    {
        get
        {
            Country country = new()
            {
                CommonName = "DR Congo",
                OfficialName = "Democratic Republic of the Congo",
                TLD = [".cd"],
                CountryCode = CountryCode.CD,
                ISONumeric = "180",
                ISO3 = CountryCodeISO3.COD,
                CIOC = "COD",
                Currencies = ["CDF"],
                CallingCodes = ["243"],
                Capital = "Kinshasa",
                AlternativeSpellings = ["CD", "DR Congo", "Congo-Kinshasa", "Congo, the Democratic Republic of the", "DRC"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.AGO,
                    CountryCodeISO3.BDI,
                    CountryCodeISO3.CAF,
                    CountryCodeISO3.COG,
                    CountryCodeISO3.RWA,
                    CountryCodeISO3.SSD,
                    CountryCodeISO3.TZA,
                    CountryCodeISO3.UGA,
                    CountryCodeISO3.ZMB
                ],
                Landlocked = false,
                Area = 2344858.0
            };
            return country;
        }
    }

    public static Country RepublicoftheCongo
    {
        get
        {
            Country country = new()
            {
                CommonName = "Republic of the Congo",
                OfficialName = "Republic of the Congo",
                TLD = [".cg"],
                CountryCode = CountryCode.CG,
                ISONumeric = "178",
                ISO3 = CountryCodeISO3.COG,
                CIOC = "CGO",
                Currencies = ["XAF"],
                CallingCodes = ["242"],
                Capital = "Brazzaville",
                AlternativeSpellings = ["CG", "Congo", "Congo-Brazzaville"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.AGO,
                    CountryCodeISO3.CMR,
                    CountryCodeISO3.CAF,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.GAB
                ],
                Landlocked = false,
                Area = 342000.0
            };
            return country;
        }
    }

    public static Country Comoros
    {
        get
        {
            Country country = new()
            {
                CommonName = "Comoros",
                OfficialName = "Union of the Comoros",
                TLD = [".km"],
                CountryCode = CountryCode.KM,
                ISONumeric = "174",
                ISO3 = CountryCodeISO3.COM,
                CIOC = "COM",
                Currencies = ["KMF"],
                CallingCodes = ["269"],
                Capital = "Moroni",
                AlternativeSpellings = ["KM", "Union of the Comoros", "Union des Comores", "Udzima wa Komori", "al-Ittiḥād al-Qumurī"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 1862.0
            };
            return country;
        }
    }

    public static Country CapeVerde
    {
        get
        {
            Country country = new()
            {
                CommonName = "Cape Verde",
                OfficialName = "Republic of Cabo Verde",
                TLD = [".cv"],
                CountryCode = CountryCode.CV,
                ISONumeric = "132",
                ISO3 = CountryCodeISO3.CPV,
                CIOC = "CPV",
                Currencies = ["CVE"],
                CallingCodes = ["238"],
                Capital = "Praia",
                AlternativeSpellings = ["CV", "Republic of Cabo Verde", "República de Cabo Verde"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders = [],
                Landlocked = false,
                Area = 4033.0
            };
            return country;
        }
    }

    public static Country Djibouti
    {
        get
        {
            Country country = new()
            {
                CommonName = "Djibouti",
                OfficialName = "Republic of Djibouti",
                TLD = [".dj"],
                CountryCode = CountryCode.DJ,
                ISONumeric = "262",
                ISO3 = CountryCodeISO3.DJI,
                CIOC = "DJI",
                Currencies = ["DJF"],
                CallingCodes = ["253"],
                Capital = "Djibouti",
                AlternativeSpellings = ["DJ", "Jabuuti", "Gabuuti", "Republic of Djibouti", "République de Djibouti", "Gabuutih Ummuuno", "Jamhuuriyadda Jabuuti"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.ERI,
                    CountryCodeISO3.ETH,
                    CountryCodeISO3.SOM
                ],
                Landlocked = false,
                Area = 23200.0
            };
            return country;
        }
    }

    public static Country Algeria
    {
        get
        {
            Country country = new()
            {
                CommonName = "Algeria",
                OfficialName = "People's Democratic Republic of Algeria",
                TLD = [".dz", "الجزائر."],
                CountryCode = CountryCode.DZ,
                ISONumeric = "012",
                ISO3 = CountryCodeISO3.DZA,
                CIOC = "ALG",
                Currencies = ["DZD"],
                CallingCodes = ["213"],
                Capital = "Algiers",
                AlternativeSpellings = ["DZ", "Dzayer", "Algérie"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.TUN,
                    CountryCodeISO3.LBY,
                    CountryCodeISO3.NER,
                    CountryCodeISO3.ESH,
                    CountryCodeISO3.MRT,
                    CountryCodeISO3.MLI,
                    CountryCodeISO3.MAR
                ],
                Landlocked = false,
                Area = 2381741.0
            };
            return country;
        }
    }

    public static Country Egypt
    {
        get
        {
            Country country = new()
            {
                CommonName = "Egypt",
                OfficialName = "Arab Republic of Egypt",
                TLD = [".eg", ".مصر"],
                CountryCode = CountryCode.EG,
                ISONumeric = "818",
                ISO3 = CountryCodeISO3.EGY,
                CIOC = "EGY",
                Currencies = ["EGP"],
                CallingCodes = ["20"],
                Capital = "Cairo",
                AlternativeSpellings = ["EG", "Arab Republic of Egypt"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.ISR,
                    CountryCodeISO3.LBY,
                    CountryCodeISO3.SDN
                ],
                Landlocked = false,
                Area = 1002450.0
            };
            return country;
        }
    }

    public static Country Eritrea
    {
        get
        {
            Country country = new()
            {
                CommonName = "Eritrea",
                OfficialName = "State of Eritrea",
                TLD = [".er"],
                CountryCode = CountryCode.ER,
                ISONumeric = "232",
                ISO3 = CountryCodeISO3.ERI,
                CIOC = "ERI",
                Currencies = ["ERN"],
                CallingCodes = ["291"],
                Capital = "Asmara",
                AlternativeSpellings = ["ER", "State of Eritrea", "ሃገረ ኤርትራ", "Dawlat Iritriyá", "ʾErtrā", "Iritriyā", ""],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.DJI,
                    CountryCodeISO3.ETH,
                    CountryCodeISO3.SDN
                ],
                Landlocked = false,
                Area = 117600.0
            };
            return country;
        }
    }

    public static Country WesternSahara
    {
        get
        {
            Country country = new()
            {
                CommonName = "Western Sahara",
                OfficialName = "Sahrawi Arab Democratic Republic",
                TLD = [".eh"],
                CountryCode = CountryCode.EH,
                ISONumeric = "732",
                ISO3 = CountryCodeISO3.ESH,
                CIOC = "",
                Currencies = ["MAD", "DZD", "MRO"],
                CallingCodes = ["212"],
                Capital = "El Aaiún",
                AlternativeSpellings = ["EH", "Taneẓroft Tutrimt"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.MRT,
                    CountryCodeISO3.MAR
                ],
                Landlocked = false,
                Area = 266000.0
            };
            return country;
        }
    }

    public static Country Ethiopia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Ethiopia",
                OfficialName = "Federal Democratic Republic of Ethiopia",
                TLD = [".et"],
                CountryCode = CountryCode.ET,
                ISONumeric = "231",
                ISO3 = CountryCodeISO3.ETH,
                CIOC = "ETH",
                Currencies = ["ETB"],
                CallingCodes = ["251"],
                Capital = "Addis Ababa",
                AlternativeSpellings = ["ET", "ʾĪtyōṗṗyā", "Federal Democratic Republic of Ethiopia", "የኢትዮጵያ ፌዴራላዊ ዲሞክራሲያዊ ሪፐብሊክ"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.DJI,
                    CountryCodeISO3.ERI,
                    CountryCodeISO3.KEN,
                    CountryCodeISO3.SOM,
                    CountryCodeISO3.SSD,
                    CountryCodeISO3.SDN
                ],
                Landlocked = true,
                Area = 1104300.0
            };
            return country;
        }
    }

    public static Country Gabon
    {
        get
        {
            Country country = new()
            {
                CommonName = "Gabon",
                OfficialName = "Gabonese Republic",
                TLD = [".ga"],
                CountryCode = CountryCode.GA,
                ISONumeric = "266",
                ISO3 = CountryCodeISO3.GAB,
                CIOC = "GAB",
                Currencies = ["XAF"],
                CallingCodes = ["241"],
                Capital = "Libreville",
                AlternativeSpellings = ["GA", "Gabonese Republic", "République Gabonaise"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.CMR,
                    CountryCodeISO3.COG,
                    CountryCodeISO3.GNQ
                ],
                Landlocked = false,
                Area = 267668.0
            };
            return country;
        }
    }

    public static Country Ghana
    {
        get
        {
            Country country = new()
            {
                CommonName = "Ghana",
                OfficialName = "Republic of Ghana",
                TLD = [".gh"],
                CountryCode = CountryCode.GH,
                ISONumeric = "288",
                ISO3 = CountryCodeISO3.GHA,
                CIOC = "GHA",
                Currencies = ["GHS"],
                CallingCodes = ["233"],
                Capital = "Accra",
                AlternativeSpellings = ["GH"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.BFA,
                    CountryCodeISO3.CIV,
                    CountryCodeISO3.TGO
                ],
                Landlocked = false,
                Area = 238533.0
            };
            return country;
        }
    }

    public static Country Guinea
    {
        get
        {
            Country country = new()
            {
                CommonName = "Guinea",
                OfficialName = "Republic of Guinea",
                TLD = [".gn"],
                CountryCode = CountryCode.GN,
                ISONumeric = "324",
                ISO3 = CountryCodeISO3.GIN,
                CIOC = "GUI",
                Currencies = ["GNF"],
                CallingCodes = ["224"],
                Capital = "Conakry",
                AlternativeSpellings = ["GN", "Republic of Guinea", "République de Guinée"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.CIV,
                    CountryCodeISO3.GNB,
                    CountryCodeISO3.LBR,
                    CountryCodeISO3.MLI,
                    CountryCodeISO3.SEN,
                    CountryCodeISO3.SLE
                ],
                Landlocked = false,
                Area = 245857.0
            };
            return country;
        }
    }

    public static Country Gambia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Gambia",
                OfficialName = "Republic of the Gambia",
                TLD = [".gm"],
                CountryCode = CountryCode.GM,
                ISONumeric = "270",
                ISO3 = CountryCodeISO3.GMB,
                CIOC = "GAM",
                Currencies = ["GMD"],
                CallingCodes = ["220"],
                Capital = "Banjul",
                AlternativeSpellings = ["GM", "Republic of the Gambia"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders = [CountryCodeISO3.SEN],
                Landlocked = false,
                Area = 10689.0
            };
            return country;
        }
    }

    public static Country GuineaBissau
    {
        get
        {
            Country country = new()
            {
                CommonName = "Guinea-Bissau",
                OfficialName = "Republic of Guinea-Bissau",
                TLD = [".gw"],
                CountryCode = CountryCode.GW,
                ISONumeric = "624",
                ISO3 = CountryCodeISO3.GNB,
                CIOC = "GBS",
                Currencies = ["XOF"],
                CallingCodes = ["245"],
                Capital = "Bissau",
                AlternativeSpellings = ["GW", "Republic of Guinea-Bissau", "República da Guiné-Bissau"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.GIN,
                    CountryCodeISO3.SEN
                ],
                Landlocked = false,
                Area = 36125.0
            };
            return country;
        }
    }

    public static Country EquatorialGuinea
    {
        get
        {
            Country country = new()
            {
                CommonName = "Equatorial Guinea",
                OfficialName = "Republic of Equatorial Guinea",
                TLD = [".gq"],
                CountryCode = CountryCode.GQ,
                ISONumeric = "226",
                ISO3 = CountryCodeISO3.GNQ,
                CIOC = "GEQ",
                Currencies = ["XAF"],
                CallingCodes = ["240"],
                Capital = "Malabo",
                AlternativeSpellings = ["GQ", "Republic of Equatorial Guinea", "República de Guinea Ecuatorial", "République de Guinée équatoriale", "República da Guiné Equatorial"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.CMR,
                    CountryCodeISO3.GAB
                ],
                Landlocked = false,
                Area = 28051.0
            };
            return country;
        }
    }

    public static Country BritishIndianOceanTerritory
    {
        get
        {
            Country country = new()
            {
                CommonName = "British Indian Ocean Territory",
                OfficialName = "British Indian Ocean Territory",
                TLD = [".io"],
                CountryCode = CountryCode.IO,
                ISONumeric = "086",
                ISO3 = CountryCodeISO3.IOT,
                CIOC = "",
                Currencies = ["USD"],
                CallingCodes = ["246"],
                Capital = "Diego Garcia",
                AlternativeSpellings = ["IO"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 60.0
            };
            return country;
        }
    }

    public static Country Kenya
    {
        get
        {
            Country country = new()
            {
                CommonName = "Kenya",
                OfficialName = "Republic of Kenya",
                TLD = [".ke"],
                CountryCode = CountryCode.KE,
                ISONumeric = "404",
                ISO3 = CountryCodeISO3.KEN,
                CIOC = "KEN",
                Currencies = ["KES"],
                CallingCodes = ["254"],
                Capital = "Nairobi",
                AlternativeSpellings = ["KE", "Republic of Kenya", "Jamhuri ya Kenya"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.ETH,
                    CountryCodeISO3.SOM,
                    CountryCodeISO3.SSD,
                    CountryCodeISO3.TZA,
                    CountryCodeISO3.UGA
                ],
                Landlocked = false,
                Area = 580367.0
            };
            return country;
        }
    }

    public static Country Liberia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Liberia",
                OfficialName = "Republic of Liberia",
                TLD = [".lr"],
                CountryCode = CountryCode.LR,
                ISONumeric = "430",
                ISO3 = CountryCodeISO3.LBR,
                CIOC = "LBR",
                Currencies = ["LRD"],
                CallingCodes = ["231"],
                Capital = "Monrovia",
                AlternativeSpellings = ["LR", "Republic of Liberia"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.GIN,
                    CountryCodeISO3.CIV,
                    CountryCodeISO3.SLE
                ],
                Landlocked = false,
                Area = 111369.0
            };
            return country;
        }
    }

    public static Country Libya
    {
        get
        {
            Country country = new()
            {
                CommonName = "Libya",
                OfficialName = "State of Libya",
                TLD = [".ly"],
                CountryCode = CountryCode.LY,
                ISONumeric = "434",
                ISO3 = CountryCodeISO3.LBY,
                CIOC = "LBA",
                Currencies = ["LYD"],
                CallingCodes = ["218"],
                Capital = "Tripoli",
                AlternativeSpellings = ["LY", "State of Libya", "Dawlat Libya"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.TCD,
                    CountryCodeISO3.EGY,
                    CountryCodeISO3.NER,
                    CountryCodeISO3.SDN,
                    CountryCodeISO3.TUN
                ],
                Landlocked = false,
                Area = 1759540.0
            };
            return country;
        }
    }

    public static Country Lesotho
    {
        get
        {
            Country country = new()
            {
                CommonName = "Lesotho",
                OfficialName = "Kingdom of Lesotho",
                TLD = [".ls"],
                CountryCode = CountryCode.LS,
                ISONumeric = "426",
                ISO3 = CountryCodeISO3.LSO,
                CIOC = "LES",
                Currencies = ["LSL", "ZAR"],
                CallingCodes = ["266"],
                Capital = "Maseru",
                AlternativeSpellings = ["LS", "Kingdom of Lesotho", "Muso oa Lesotho"],
                Continent = Continent.Africa,
                Region = "Southern Africa",
                Borders = [CountryCodeISO3.ZAF],
                Landlocked = true,
                Area = 30355.0
            };
            return country;
        }
    }

    public static Country Morocco
    {
        get
        {
            Country country = new()
            {
                CommonName = "Morocco",
                OfficialName = "Kingdom of Morocco",
                TLD = [".ma", "المغرب."],
                CountryCode = CountryCode.MA,
                ISONumeric = "504",
                ISO3 = CountryCodeISO3.MAR,
                CIOC = "MAR",
                Currencies = ["MAD"],
                CallingCodes = ["212"],
                Capital = "Rabat",
                AlternativeSpellings = ["MA", "Kingdom of Morocco", "Al-Mamlakah al-Maġribiyah"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.ESH,
                    CountryCodeISO3.ESP
                ],
                Landlocked = false,
                Area = 446550.0
            };
            return country;
        }
    }

    public static Country Madagascar
    {
        get
        {
            Country country = new()
            {
                CommonName = "Madagascar",
                OfficialName = "Republic of Madagascar",
                TLD = [".mg"],
                CountryCode = CountryCode.MG,
                ISONumeric = "450",
                ISO3 = CountryCodeISO3.MDG,
                CIOC = "MAD",
                Currencies = ["MGA"],
                CallingCodes = ["261"],
                Capital = "Antananarivo",
                AlternativeSpellings = ["MG", "Republic of Madagascar", "Repoblikan'i Madagasikara", "République de Madagascar"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 587041.0
            };
            return country;
        }
    }

    public static Country Mali
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mali",
                OfficialName = "Republic of Mali",
                TLD = [".ml"],
                CountryCode = CountryCode.ML,
                ISONumeric = "466",
                ISO3 = CountryCodeISO3.MLI,
                CIOC = "MLI",
                Currencies = ["XOF"],
                CallingCodes = ["223"],
                Capital = "Bamako",
                AlternativeSpellings = ["ML", "Republic of Mali", "République du Mali"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.BFA,
                    CountryCodeISO3.GIN,
                    CountryCodeISO3.CIV,
                    CountryCodeISO3.MRT,
                    CountryCodeISO3.NER,
                    CountryCodeISO3.SEN
                ],
                Landlocked = true,
                Area = 1240192.0
            };
            return country;
        }
    }

    public static Country Mozambique
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mozambique",
                OfficialName = "Republic of Mozambique",
                TLD = [".mz"],
                CountryCode = CountryCode.MZ,
                ISONumeric = "508",
                ISO3 = CountryCodeISO3.MOZ,
                CIOC = "MOZ",
                Currencies = ["MZN"],
                CallingCodes = ["258"],
                Capital = "Maputo",
                AlternativeSpellings = ["MZ", "Republic of Mozambique", "República de Moçambique"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.MWI,
                    CountryCodeISO3.ZAF,
                    CountryCodeISO3.SWZ,
                    CountryCodeISO3.TZA,
                    CountryCodeISO3.ZMB,
                    CountryCodeISO3.ZWE
                ],
                Landlocked = false,
                Area = 801590.0
            };
            return country;
        }
    }

    public static Country Mauritania
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mauritania",
                OfficialName = "Islamic Republic of Mauritania",
                TLD = [".mr"],
                CountryCode = CountryCode.MR,
                ISONumeric = "478",
                ISO3 = CountryCodeISO3.MRT,
                CIOC = "MTN",
                Currencies = ["MRO"],
                CallingCodes = ["222"],
                Capital = "Nouakchott",
                AlternativeSpellings = ["MR", "Islamic Republic of Mauritania", "al-Jumhūriyyah al-ʾIslāmiyyah al-Mūrītāniyyah"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.MLI,
                    CountryCodeISO3.SEN,
                    CountryCodeISO3.ESH
                ],
                Landlocked = false,
                Area = 1030700.0
            };
            return country;
        }
    }

    public static Country Mauritius
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mauritius",
                OfficialName = "Republic of Mauritius",
                TLD = [".mu"],
                CountryCode = CountryCode.MU,
                ISONumeric = "480",
                ISO3 = CountryCodeISO3.MUS,
                CIOC = "MRI",
                Currencies = ["MUR"],
                CallingCodes = ["230"],
                Capital = "Port Louis",
                AlternativeSpellings = ["MU", "Republic of Mauritius", "République de Maurice"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 2040.0
            };
            return country;
        }
    }

    public static Country Malawi
    {
        get
        {
            Country country = new()
            {
                CommonName = "Malawi",
                OfficialName = "Republic of Malawi",
                TLD = [".mw"],
                CountryCode = CountryCode.MW,
                ISONumeric = "454",
                ISO3 = CountryCodeISO3.MWI,
                CIOC = "MAW",
                Currencies = ["MWK"],
                CallingCodes = ["265"],
                Capital = "Lilongwe",
                AlternativeSpellings = ["MW", "Republic of Malawi"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.MOZ,
                    CountryCodeISO3.TZA,
                    CountryCodeISO3.ZMB
                ],
                Landlocked = true,
                Area = 118484.0
            };
            return country;
        }
    }

    public static Country Mayotte
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mayotte",
                OfficialName = "Department of Mayotte",
                TLD = [".yt"],
                CountryCode = CountryCode.YT,
                ISONumeric = "175",
                ISO3 = CountryCodeISO3.MYT,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["262"],
                Capital = "Mamoudzou",
                AlternativeSpellings = ["YT", "Department of Mayotte", "Département de Mayotte"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 374.0
            };
            return country;
        }
    }

    public static Country Namibia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Namibia",
                OfficialName = "Republic of Namibia",
                TLD = [".na"],
                CountryCode = CountryCode.NA,
                ISONumeric = "516",
                ISO3 = CountryCodeISO3.NAM,
                CIOC = "NAM",
                Currencies = ["NAD", "ZAR"],
                CallingCodes = ["264"],
                Capital = "Windhoek",
                AlternativeSpellings = ["NA", "Namibië", "Republic of Namibia"],
                Continent = Continent.Africa,
                Region = "Southern Africa",
                Borders =
                [
                    CountryCodeISO3.AGO,
                    CountryCodeISO3.BWA,
                    CountryCodeISO3.ZAF,
                    CountryCodeISO3.ZMB
                ],
                Landlocked = false,
                Area = 825615.0
            };
            return country;
        }
    }

    public static Country Niger
    {
        get
        {
            Country country = new()
            {
                CommonName = "Niger",
                OfficialName = "Republic of Niger",
                TLD = [".ne"],
                CountryCode = CountryCode.NE,
                ISONumeric = "562",
                ISO3 = CountryCodeISO3.NER,
                CIOC = "NIG",
                Currencies = ["XOF"],
                CallingCodes = ["227"],
                Capital = "Niamey",
                AlternativeSpellings = ["NE", "Nijar"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.BEN,
                    CountryCodeISO3.BFA,
                    CountryCodeISO3.TCD,
                    CountryCodeISO3.LBY,
                    CountryCodeISO3.MLI,
                    CountryCodeISO3.NGA
                ],
                Landlocked = true,
                Area = 1267000.0
            };
            return country;
        }
    }

    public static Country Nigeria
    {
        get
        {
            Country country = new()
            {
                CommonName = "Nigeria",
                OfficialName = "Federal Republic of Nigeria",
                TLD = [".ng"],
                CountryCode = CountryCode.NG,
                ISONumeric = "566",
                ISO3 = CountryCodeISO3.NGA,
                CIOC = "NGR",
                Currencies = ["NGN"],
                CallingCodes = ["234"],
                Capital = "Abuja",
                AlternativeSpellings = ["NG", "Nijeriya", "Naíjíríà", "Federal Republic of Nigeria"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.BEN,
                    CountryCodeISO3.CMR,
                    CountryCodeISO3.TCD,
                    CountryCodeISO3.NER
                ],
                Landlocked = false,
                Area = 923768.0
            };
            return country;
        }
    }

    public static Country Réunion
    {
        get
        {
            Country country = new()
            {
                CommonName = "Réunion",
                OfficialName = "Réunion Island",
                TLD = [".re"],
                CountryCode = CountryCode.RE,
                ISONumeric = "638",
                ISO3 = CountryCodeISO3.REU,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["262"],
                Capital = "Saint-Denis",
                AlternativeSpellings = ["RE", "Reunion"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 2511.0
            };
            return country;
        }
    }

    public static Country Rwanda
    {
        get
        {
            Country country = new()
            {
                CommonName = "Rwanda",
                OfficialName = "Republic of Rwanda",
                TLD = [".rw"],
                CountryCode = CountryCode.RW,
                ISONumeric = "646",
                ISO3 = CountryCodeISO3.RWA,
                CIOC = "RWA",
                Currencies = ["RWF"],
                CallingCodes = ["250"],
                Capital = "Kigali",
                AlternativeSpellings = ["RW", "Republic of Rwanda", "Repubulika y'u Rwanda", "République du Rwanda"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.BDI,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.TZA,
                    CountryCodeISO3.UGA
                ],
                Landlocked = true,
                Area = 26338.0
            };
            return country;
        }
    }

    public static Country Sudan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Sudan",
                OfficialName = "Republic of the Sudan",
                TLD = [".sd"],
                CountryCode = CountryCode.SD,
                ISONumeric = "729",
                ISO3 = CountryCodeISO3.SDN,
                CIOC = "SUD",
                Currencies = ["SDG"],
                CallingCodes = ["249"],
                Capital = "Khartoum",
                AlternativeSpellings = ["SD", "Republic of the Sudan", "Jumhūrīyat as-Sūdān"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.CAF,
                    CountryCodeISO3.TCD,
                    CountryCodeISO3.EGY,
                    CountryCodeISO3.ERI,
                    CountryCodeISO3.ETH,
                    CountryCodeISO3.LBY,
                    CountryCodeISO3.SSD
                ],
                Landlocked = false,
                Area = 1886068.0
            };
            return country;
        }
    }

    public static Country Senegal
    {
        get
        {
            Country country = new()
            {
                CommonName = "Senegal",
                OfficialName = "Republic of Senegal",
                TLD = [".sn"],
                CountryCode = CountryCode.SN,
                ISONumeric = "686",
                ISO3 = CountryCodeISO3.SEN,
                CIOC = "SEN",
                Currencies = ["XOF"],
                CallingCodes = ["221"],
                Capital = "Dakar",
                AlternativeSpellings = ["SN", "Republic of Senegal", "République du Sénégal"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.GMB,
                    CountryCodeISO3.GIN,
                    CountryCodeISO3.GNB,
                    CountryCodeISO3.MLI,
                    CountryCodeISO3.MRT
                ],
                Landlocked = false,
                Area = 196722.0
            };
            return country;
        }
    }

    public static Country SierraLeone
    {
        get
        {
            Country country = new()
            {
                CommonName = "Sierra Leone",
                OfficialName = "Republic of Sierra Leone",
                TLD = [".sl"],
                CountryCode = CountryCode.SL,
                ISONumeric = "694",
                ISO3 = CountryCodeISO3.SLE,
                CIOC = "SLE",
                Currencies = ["SLL"],
                CallingCodes = ["232"],
                Capital = "Freetown",
                AlternativeSpellings = ["SL", "Republic of Sierra Leone"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.GIN,
                    CountryCodeISO3.LBR
                ],
                Landlocked = false,
                Area = 71740.0
            };
            return country;
        }
    }

    public static Country Somalia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Somalia",
                OfficialName = "Federal Republic of Somalia",
                TLD = [".so"],
                CountryCode = CountryCode.SO,
                ISONumeric = "706",
                ISO3 = CountryCodeISO3.SOM,
                CIOC = "SOM",
                Currencies = ["SOS"],
                CallingCodes = ["252"],
                Capital = "Mogadishu",
                AlternativeSpellings = ["SO", "aṣ-Ṣūmāl", "Federal Republic of Somalia", "Jamhuuriyadda Federaalka Soomaaliya", "Jumhūriyyat aṣ-Ṣūmāl al-Fiderāliyya"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.DJI,
                    CountryCodeISO3.ETH,
                    CountryCodeISO3.KEN
                ],
                Landlocked = false,
                Area = 637657.0
            };
            return country;
        }
    }

    public static Country SouthSudan
    {
        get
        {
            Country country = new()
            {
                CommonName = "South Sudan",
                OfficialName = "Republic of South Sudan",
                TLD = [".ss"],
                CountryCode = CountryCode.SS,
                ISONumeric = "728",
                ISO3 = CountryCodeISO3.SSD,
                CIOC = "",
                Currencies = ["SSP"],
                CallingCodes = ["211"],
                Capital = "Juba",
                AlternativeSpellings = ["SS"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.CAF,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.ETH,
                    CountryCodeISO3.KEN,
                    CountryCodeISO3.SDN,
                    CountryCodeISO3.UGA
                ],
                Landlocked = true,
                Area = 619745.0
            };
            return country;
        }
    }

    public static Country SãoToméandPríncipe
    {
        get
        {
            Country country = new()
            {
                CommonName = "São Tomé and Príncipe",
                OfficialName = "Democratic Republic of São Tomé and Príncipe",
                TLD = [".st"],
                CountryCode = CountryCode.ST,
                ISONumeric = "678",
                ISO3 = CountryCodeISO3.STP,
                CIOC = "STP",
                Currencies = ["STD"],
                CallingCodes = ["239"],
                Capital = "São Tomé",
                AlternativeSpellings = ["ST", "Democratic Republic of São Tomé and Príncipe", "Sao Tome and Principe", "República Democrática de São Tomé e Príncipe"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders = [],
                Landlocked = false,
                Area = 964.0
            };
            return country;
        }
    }

    public static Country Swaziland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Swaziland",
                OfficialName = "Kingdom of Swaziland",
                TLD = [".sz"],
                CountryCode = CountryCode.SZ,
                ISONumeric = "748",
                ISO3 = CountryCodeISO3.SWZ,
                CIOC = "SWZ",
                Currencies = ["SZL"],
                CallingCodes = ["268"],
                Capital = "Lobamba",
                AlternativeSpellings = ["SZ", "weSwatini", "Swatini", "Ngwane", "Kingdom of Swaziland", "Umbuso waseSwatini"],
                Continent = Continent.Africa,
                Region = "Southern Africa",
                Borders =
                [
                    CountryCodeISO3.MOZ,
                    CountryCodeISO3.ZAF
                ],
                Landlocked = true,
                Area = 17364.0
            };
            return country;
        }
    }

    public static Country Seychelles
    {
        get
        {
            Country country = new()
            {
                CommonName = "Seychelles",
                OfficialName = "Republic of Seychelles",
                TLD = [".sc"],
                CountryCode = CountryCode.SC,
                ISONumeric = "690",
                ISO3 = CountryCodeISO3.SYC,
                CIOC = "SEY",
                Currencies = ["SCR"],
                CallingCodes = ["248"],
                Capital = "Victoria",
                AlternativeSpellings = ["SC", "Republic of Seychelles", "Repiblik Sesel", "République des Seychelles"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders = [],
                Landlocked = false,
                Area = 452.0
            };
            return country;
        }
    }

    public static Country Chad
    {
        get
        {
            Country country = new()
            {
                CommonName = "Chad",
                OfficialName = "Republic of Chad",
                TLD = [".td"],
                CountryCode = CountryCode.TD,
                ISONumeric = "148",
                ISO3 = CountryCodeISO3.TCD,
                CIOC = "CHA",
                Currencies = ["XAF"],
                CallingCodes = ["235"],
                Capital = "N'Djamena",
                AlternativeSpellings = ["TD", "Tchad", "Republic of Chad", "République du Tchad"],
                Continent = Continent.Africa,
                Region = "Middle Africa",
                Borders =
                [
                    CountryCodeISO3.CMR,
                    CountryCodeISO3.CAF,
                    CountryCodeISO3.LBY,
                    CountryCodeISO3.NER,
                    CountryCodeISO3.NGA,
                    CountryCodeISO3.SSD
                ],
                Landlocked = true,
                Area = 1284000.0
            };
            return country;
        }
    }

    public static Country Togo
    {
        get
        {
            Country country = new()
            {
                CommonName = "Togo",
                OfficialName = "Togolese Republic",
                TLD = [".tg"],
                CountryCode = CountryCode.TG,
                ISONumeric = "768",
                ISO3 = CountryCodeISO3.TGO,
                CIOC = "TOG",
                Currencies = ["XOF"],
                CallingCodes = ["228"],
                Capital = "Lomé",
                AlternativeSpellings = ["TG", "Togolese", "Togolese Republic", "République Togolaise"],
                Continent = Continent.Africa,
                Region = "Western Africa",
                Borders =
                [
                    CountryCodeISO3.BEN,
                    CountryCodeISO3.BFA,
                    CountryCodeISO3.GHA
                ],
                Landlocked = false,
                Area = 56785.0
            };
            return country;
        }
    }

    public static Country Tunisia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Tunisia",
                OfficialName = "Tunisian Republic",
                TLD = [".tn"],
                CountryCode = CountryCode.TN,
                ISONumeric = "788",
                ISO3 = CountryCodeISO3.TUN,
                CIOC = "TUN",
                Currencies = ["TND"],
                CallingCodes = ["216"],
                Capital = "Tunis",
                AlternativeSpellings = ["TN", "Republic of Tunisia", "al-Jumhūriyyah at-Tūnisiyyah"],
                Continent = Continent.Africa,
                Region = "Northern Africa",
                Borders =
                [
                    CountryCodeISO3.DZA,
                    CountryCodeISO3.LBY
                ],
                Landlocked = false,
                Area = 163610.0
            };
            return country;
        }
    }

    public static Country Tanzania
    {
        get
        {
            Country country = new()
            {
                CommonName = "Tanzania",
                OfficialName = "United Republic of Tanzania",
                TLD = [".tz"],
                CountryCode = CountryCode.TZ,
                ISONumeric = "834",
                ISO3 = CountryCodeISO3.TZA,
                CIOC = "TAN",
                Currencies = ["TZS"],
                CallingCodes = ["255"],
                Capital = "Dodoma",
                AlternativeSpellings = ["TZ", "Tanzania, United Republic of", "United Republic of Tanzania", "Jamhuri ya Muungano wa Tanzania"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.BDI,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.KEN,
                    CountryCodeISO3.MWI,
                    CountryCodeISO3.MOZ,
                    CountryCodeISO3.RWA,
                    CountryCodeISO3.UGA,
                    CountryCodeISO3.ZMB
                ],
                Landlocked = false,
                Area = 945087.0
            };
            return country;
        }
    }

    public static Country Uganda
    {
        get
        {
            Country country = new()
            {
                CommonName = "Uganda",
                OfficialName = "Republic of Uganda",
                TLD = [".ug"],
                CountryCode = CountryCode.UG,
                ISONumeric = "800",
                ISO3 = CountryCodeISO3.UGA,
                CIOC = "UGA",
                Currencies = ["UGX"],
                CallingCodes = ["256"],
                Capital = "Kampala",
                AlternativeSpellings = ["UG", "Republic of Uganda", "Jamhuri ya Uganda"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.COD,
                    CountryCodeISO3.KEN,
                    CountryCodeISO3.RWA,
                    CountryCodeISO3.SSD,
                    CountryCodeISO3.TZA
                ],
                Landlocked = true,
                Area = 241550.0
            };
            return country;
        }
    }

    public static Country SouthAfrica
    {
        get
        {
            Country country = new()
            {
                CommonName = "South Africa",
                OfficialName = "Republic of South Africa",
                TLD = [".za"],
                CountryCode = CountryCode.ZA,
                ISONumeric = "710",
                ISO3 = CountryCodeISO3.ZAF,
                CIOC = "RSA",
                Currencies = ["ZAR"],
                CallingCodes = ["27"],
                Capital = "Pretoria",
                AlternativeSpellings = ["ZA", "RSA", "Suid-Afrika", "Republic of South Africa"],
                Continent = Continent.Africa,
                Region = "Southern Africa",
                Borders =
                [
                    CountryCodeISO3.BWA,
                    CountryCodeISO3.LSO,
                    CountryCodeISO3.MOZ,
                    CountryCodeISO3.NAM,
                    CountryCodeISO3.SWZ,
                    CountryCodeISO3.ZWE
                ],
                Landlocked = false,
                Area = 1221037.0
            };
            return country;
        }
    }

    public static Country Zambia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Zambia",
                OfficialName = "Republic of Zambia",
                TLD = [".zm"],
                CountryCode = CountryCode.ZM,
                ISONumeric = "894",
                ISO3 = CountryCodeISO3.ZMB,
                CIOC = "ZAM",
                Currencies = ["ZMW"],
                CallingCodes = ["260"],
                Capital = "Lusaka",
                AlternativeSpellings = ["ZM", "Republic of Zambia"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.AGO,
                    CountryCodeISO3.BWA,
                    CountryCodeISO3.COD,
                    CountryCodeISO3.MWI,
                    CountryCodeISO3.MOZ,
                    CountryCodeISO3.NAM,
                    CountryCodeISO3.TZA,
                    CountryCodeISO3.ZWE
                ],
                Landlocked = true,
                Area = 752612.0
            };
            return country;
        }
    }

    public static Country Zimbabwe
    {
        get
        {
            Country country = new()
            {
                CommonName = "Zimbabwe",
                OfficialName = "Republic of Zimbabwe",
                TLD = [".zw"],
                CountryCode = CountryCode.ZW,
                ISONumeric = "716",
                ISO3 = CountryCodeISO3.ZWE,
                CIOC = "ZIM",
                Currencies = ["ZWL"],
                CallingCodes = ["263"],
                Capital = "Harare",
                AlternativeSpellings = ["ZW", "Republic of Zimbabwe"],
                Continent = Continent.Africa,
                Region = "Eastern Africa",
                Borders =
                [
                    CountryCodeISO3.BWA,
                    CountryCodeISO3.MOZ,
                    CountryCodeISO3.ZAF,
                    CountryCodeISO3.ZMB
                ],
                Landlocked = true,
                Area = 390757.0
            };
            return country;
        }
    }
}
