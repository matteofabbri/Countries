namespace Countries;

public partial struct Country
{
    public static Country Aruba
    {
        get
        {
            Country country = new()
            {
                CommonName = "Aruba",
                OfficialName = "Aruba",
                TLD = [".aw"],
                CountryCode = CountryCode.AW,
                ISONumeric = "533",
                ISO3 = CountryCodeISO3.ABW,
                CIOC = "ARU",
                Currencies = ["AWG"],
                CallingCodes = ["297"],
                Capital = "Oranjestad",
                AlternativeSpellings = ["AW"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 180.0
            };
            return country;
        }
    }

    public static Country Anguilla
    {
        get
        {
            Country country = new()
            {
                CommonName = "Anguilla",
                OfficialName = "Anguilla",
                TLD = [".ai"],
                CountryCode = CountryCode.AI,
                ISONumeric = "660",
                ISO3 = CountryCodeISO3.AIA,
                CIOC = "",
                Currencies = ["XCD"],
                CallingCodes = ["1264"],
                Capital = "The Valley",
                AlternativeSpellings = ["AI"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 91.0
            };
            return country;
        }
    }

    public static Country Argentina
    {
        get
        {
            Country country = new()
            {
                CommonName = "Argentina",
                OfficialName = "Argentine Republic",
                TLD = [".ar"],
                CountryCode = CountryCode.AR,
                ISONumeric = "032",
                ISO3 = CountryCodeISO3.ARG,
                CIOC = "ARG",
                Currencies = ["ARS"],
                CallingCodes = ["54"],
                Capital = "Buenos Aires",
                AlternativeSpellings = ["AR", "Argentine Republic", "República Argentina"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BOL,
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.CHL,
                    CountryCodeISO3.PRY,
                    CountryCodeISO3.URY
                ],
                Landlocked = false,
                Area = 2780400.0
            };
            return country;
        }
    }

    public static Country AntiguaandBarbuda
    {
        get
        {
            Country country = new()
            {
                CommonName = "Antigua and Barbuda",
                OfficialName = "Antigua and Barbuda",
                TLD = [".ag"],
                CountryCode = CountryCode.AG,
                ISONumeric = "028",
                ISO3 = CountryCodeISO3.ATG,
                CIOC = "ANT",
                Currencies = ["XCD"],
                CallingCodes = ["1268"],
                Capital = "Saint John's",
                AlternativeSpellings = ["AG"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 442.0
            };
            return country;
        }
    }

    public static Country Bahamas
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bahamas",
                OfficialName = "Commonwealth of the Bahamas",
                TLD = [".bs"],
                CountryCode = CountryCode.BS,
                ISONumeric = "044",
                ISO3 = CountryCodeISO3.BHS,
                CIOC = "BAH",
                Currencies = ["BSD"],
                CallingCodes = ["1242"],
                Capital = "Nassau",
                AlternativeSpellings = ["BS", "Commonwealth of the Bahamas"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 13943.0
            };
            return country;
        }
    }

    public static Country SaintBarthélemy
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saint Barthélemy",
                OfficialName = "Collectivity of Saint BarthélemySaint Barthélemy",
                TLD = [".bl"],
                CountryCode = CountryCode.BL,
                ISONumeric = "652",
                ISO3 = CountryCodeISO3.BLM,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["590"],
                Capital = "Gustavia",
                AlternativeSpellings = ["BL", "St. Barthelemy", "Collectivity of Saint Barthélemy", "Collectivité de Saint-Barthélemy"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 21.0
            };
            return country;
        }
    }

    public static Country Belize
    {
        get
        {
            Country country = new()
            {
                CommonName = "Belize",
                OfficialName = "Belize",
                TLD = [".bz"],
                CountryCode = CountryCode.BZ,
                ISONumeric = "084",
                ISO3 = CountryCodeISO3.BLZ,
                CIOC = "BIZ",
                Currencies = ["BZD"],
                CallingCodes = ["501"],
                Capital = "Belmopan",
                AlternativeSpellings = ["BZ"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.GTM,
                    CountryCodeISO3.MEX
                ],
                Landlocked = false,
                Area = 22966.0
            };
            return country;
        }
    }

    public static Country Bermuda
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bermuda",
                OfficialName = "Bermuda",
                TLD = [".bm"],
                CountryCode = CountryCode.BM,
                ISONumeric = "060",
                ISO3 = CountryCodeISO3.BMU,
                CIOC = "BER",
                Currencies = ["BMD"],
                CallingCodes = ["1441"],
                Capital = "Hamilton",
                AlternativeSpellings = ["BM", "The Islands of Bermuda", "The Bermudas", "Somers Isles"],
                Region = "Americas",
                SubRegion = "Northern America",
                Borders = [],
                Landlocked = false,
                Area = 54.0
            };
            return country;
        }
    }

    public static Country Bolivia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bolivia",
                OfficialName = "Plurinational State of Bolivia",
                TLD = [".bo"],
                CountryCode = CountryCode.BO,
                ISONumeric = "068",
                ISO3 = CountryCodeISO3.BOL,
                CIOC = "BOL",
                Currencies = ["BOB", "BOV"],
                CallingCodes = ["591"],
                Capital = "Sucre",
                AlternativeSpellings = ["BO", "Buliwya", "Wuliwya", "Bolivia, Plurinational State of", "Plurinational State of Bolivia", "Estado Plurinacional de Bolivia", "Buliwya Mamallaqta", "Wuliwya Suyu", "Tetã Volívia"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.ARG,
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.CHL,
                    CountryCodeISO3.PRY,
                    CountryCodeISO3.PER
                ],
                Landlocked = true,
                Area = 1098581.0
            };
            return country;
        }
    }

    public static Country Brazil
    {
        get
        {
            Country country = new()
            {
                CommonName = "Brazil",
                OfficialName = "Federative Republic of Brazil",
                TLD = [".br"],
                CountryCode = CountryCode.BR,
                ISONumeric = "076",
                ISO3 = CountryCodeISO3.BRA,
                CIOC = "BRA",
                Currencies = ["BRL"],
                CallingCodes = ["55"],
                Capital = "Brasília",
                AlternativeSpellings = ["BR", "Brasil", "Federative Republic of Brazil", "República Federativa do Brasil"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.ARG,
                    CountryCodeISO3.BOL,
                    CountryCodeISO3.COL,
                    CountryCodeISO3.GUF,
                    CountryCodeISO3.GUY,
                    CountryCodeISO3.PRY,
                    CountryCodeISO3.PER,
                    CountryCodeISO3.SUR,
                    CountryCodeISO3.URY,
                    CountryCodeISO3.VEN
                ],
                Landlocked = false,
                Area = 8515767.0
            };
            return country;
        }
    }

    public static Country Barbados
    {
        get
        {
            Country country = new()
            {
                CommonName = "Barbados",
                OfficialName = "Barbados",
                TLD = [".bb"],
                CountryCode = CountryCode.BB,
                ISONumeric = "052",
                ISO3 = CountryCodeISO3.BRB,
                CIOC = "BAR",
                Currencies = ["BBD"],
                CallingCodes = ["1246"],
                Capital = "Bridgetown",
                AlternativeSpellings = ["BB"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 430.0
            };
            return country;
        }
    }

    public static Country Canada
    {
        get
        {
            Country country = new()
            {
                CommonName = "Canada",
                OfficialName = "Canada",
                TLD = [".ca"],
                CountryCode = CountryCode.CA,
                ISONumeric = "124",
                ISO3 = CountryCodeISO3.CAN,
                CIOC = "CAN",
                Currencies = ["CAD"],
                CallingCodes = ["1"],
                Capital = "Ottawa",
                AlternativeSpellings = ["CA"],
                Region = "Americas",
                SubRegion = "Northern America",
                Borders = [CountryCodeISO3.USA],
                Landlocked = false,
                Area = 9984670.0
            };
            return country;
        }
    }

    public static Country Chile
    {
        get
        {
            Country country = new()
            {
                CommonName = "Chile",
                OfficialName = "Republic of Chile",
                TLD = [".cl"],
                CountryCode = CountryCode.CL,
                ISONumeric = "152",
                ISO3 = CountryCodeISO3.CHL,
                CIOC = "CHI",
                Currencies = ["CLF", "CLP"],
                CallingCodes = ["56"],
                Capital = "Santiago",
                AlternativeSpellings = ["CL", "Republic of Chile", "República de Chile"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.ARG,
                    CountryCodeISO3.BOL,
                    CountryCodeISO3.PER
                ],
                Landlocked = false,
                Area = 756102.0
            };
            return country;
        }
    }

    public static Country Colombia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Colombia",
                OfficialName = "Republic of Colombia",
                TLD = [".co"],
                CountryCode = CountryCode.CO,
                ISONumeric = "170",
                ISO3 = CountryCodeISO3.COL,
                CIOC = "COL",
                Currencies = ["COP"],
                CallingCodes = ["57"],
                Capital = "Bogotá",
                AlternativeSpellings = ["CO", "Republic of Colombia", "República de Colombia"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.ECU,
                    CountryCodeISO3.PAN,
                    CountryCodeISO3.PER,
                    CountryCodeISO3.VEN
                ],
                Landlocked = false,
                Area = 1141748.0
            };
            return country;
        }
    }

    public static Country CostaRica
    {
        get
        {
            Country country = new()
            {
                CommonName = "Costa Rica",
                OfficialName = "Republic of Costa Rica",
                TLD = [".cr"],
                CountryCode = CountryCode.CR,
                ISONumeric = "188",
                ISO3 = CountryCodeISO3.CRI,
                CIOC = "CRC",
                Currencies = ["CRC"],
                CallingCodes = ["506"],
                Capital = "San José",
                AlternativeSpellings = ["CR", "Republic of Costa Rica", "República de Costa Rica"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.NIC,
                    CountryCodeISO3.PAN
                ],
                Landlocked = false,
                Area = 51100.0
            };
            return country;
        }
    }

    public static Country Cuba
    {
        get
        {
            Country country = new()
            {
                CommonName = "Cuba",
                OfficialName = "Republic of Cuba",
                TLD = [".cu"],
                CountryCode = CountryCode.CU,
                ISONumeric = "192",
                ISO3 = CountryCodeISO3.CUB,
                CIOC = "CUB",
                Currencies = ["CUC", "CUP"],
                CallingCodes = ["53"],
                Capital = "Havana",
                AlternativeSpellings = ["CU", "Republic of Cuba", "República de Cuba"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 109884.0
            };
            return country;
        }
    }

    public static Country Curaçao
    {
        get
        {
            Country country = new()
            {
                CommonName = "Curaçao",
                OfficialName = "Country of Curaçao",
                TLD = [".cw"],
                CountryCode = CountryCode.CW,
                ISONumeric = "531",
                ISO3 = CountryCodeISO3.CUW,
                CIOC = "",
                Currencies = ["ANG"],
                CallingCodes = ["5999"],
                Capital = "Willemstad",
                AlternativeSpellings = ["CW", "Curacao", "Kòrsou", "Country of Curaçao", "Land Curaçao", "Pais Kòrsou"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 444.0
            };
            return country;
        }
    }

    public static Country CaymanIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Cayman Islands",
                OfficialName = "Cayman Islands",
                TLD = [".ky"],
                CountryCode = CountryCode.KY,
                ISONumeric = "136",
                ISO3 = CountryCodeISO3.CYM,
                CIOC = "CAY",
                Currencies = ["KYD"],
                CallingCodes = ["1345"],
                Capital = "George Town",
                AlternativeSpellings = ["KY"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 264.0
            };
            return country;
        }
    }

    public static Country Dominica
    {
        get
        {
            Country country = new()
            {
                CommonName = "Dominica",
                OfficialName = "Commonwealth of Dominica",
                TLD = [".dm"],
                CountryCode = CountryCode.DM,
                ISONumeric = "212",
                ISO3 = CountryCodeISO3.DMA,
                CIOC = "DMA",
                Currencies = ["XCD"],
                CallingCodes = ["1767"],
                Capital = "Roseau",
                AlternativeSpellings = ["DM", "Dominique", "Wai'tu kubuli", "Commonwealth of Dominica"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 751.0
            };
            return country;
        }
    }

    public static Country DominicanRepublic
    {
        get
        {
            Country country = new()
            {
                CommonName = "Dominican Republic",
                OfficialName = "Dominican Republic",
                TLD = [".do"],
                CountryCode = CountryCode.DO,
                ISONumeric = "214",
                ISO3 = CountryCodeISO3.DOM,
                CIOC = "DOM",
                Currencies = ["DOP"],
                CallingCodes = ["1809", "1829", "1849"],
                Capital = "Santo Domingo",
                AlternativeSpellings = ["DO"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [CountryCodeISO3.HTI],
                Landlocked = false,
                Area = 48671.0
            };
            return country;
        }
    }

    public static Country Ecuador
    {
        get
        {
            Country country = new()
            {
                CommonName = "Ecuador",
                OfficialName = "Republic of Ecuador",
                TLD = [".ec"],
                CountryCode = CountryCode.EC,
                ISONumeric = "218",
                ISO3 = CountryCodeISO3.ECU,
                CIOC = "ECU",
                Currencies = ["USD"],
                CallingCodes = ["593"],
                Capital = "Quito",
                AlternativeSpellings = ["EC", "Republic of Ecuador", "República del Ecuador"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.COL,
                    CountryCodeISO3.PER
                ],
                Landlocked = false,
                Area = 276841.0
            };
            return country;
        }
    }

    public static Country FalklandIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Falkland Islands",
                OfficialName = "Falkland Islands",
                TLD = [".fk"],
                CountryCode = CountryCode.FK,
                ISONumeric = "238",
                ISO3 = CountryCodeISO3.FLK,
                CIOC = "",
                Currencies = ["FKP"],
                CallingCodes = ["500"],
                Capital = "Stanley",
                AlternativeSpellings = ["FK", "Islas Malvinas", "Falkland Islands (Malvinas)"],
                Region = "Americas",
                SubRegion = "South America",
                Borders = [],
                Landlocked = false,
                Area = 12173.0
            };
            return country;
        }
    }

    public static Country Grenada
    {
        get
        {
            Country country = new()
            {
                CommonName = "Grenada",
                OfficialName = "Grenada",
                TLD = [".gd"],
                CountryCode = CountryCode.GD,
                ISONumeric = "308",
                ISO3 = CountryCodeISO3.GRD,
                CIOC = "GRN",
                Currencies = ["XCD"],
                CallingCodes = ["1473"],
                Capital = "St. George's",
                AlternativeSpellings = ["GD"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 344.0
            };
            return country;
        }
    }

    public static Country Greenland
    {
        get
        {
            Country country = new()
            {
                CommonName = "Greenland",
                OfficialName = "Greenland",
                TLD = [".gl"],
                CountryCode = CountryCode.GL,
                ISONumeric = "304",
                ISO3 = CountryCodeISO3.GRL,
                CIOC = "",
                Currencies = ["DKK"],
                CallingCodes = ["299"],
                Capital = "Nuuk",
                AlternativeSpellings = ["GL", "Grønland"],
                Region = "Americas",
                SubRegion = "Northern America",
                Borders = [],
                Landlocked = false,
                Area = 2166086.0
            };
            return country;
        }
    }

    public static Country Guatemala
    {
        get
        {
            Country country = new()
            {
                CommonName = "Guatemala",
                OfficialName = "Republic of Guatemala",
                TLD = [".gt"],
                CountryCode = CountryCode.GT,
                ISONumeric = "320",
                ISO3 = CountryCodeISO3.GTM,
                CIOC = "GUA",
                Currencies = ["GTQ"],
                CallingCodes = ["502"],
                Capital = "Guatemala City",
                AlternativeSpellings = ["GT"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.BLZ,
                    CountryCodeISO3.SLV,
                    CountryCodeISO3.HND,
                    CountryCodeISO3.MEX
                ],
                Landlocked = false,
                Area = 108889.0
            };
            return country;
        }
    }

    public static Country FrenchGuiana
    {
        get
        {
            Country country = new()
            {
                CommonName = "French Guiana",
                OfficialName = "Guiana",
                TLD = [".gf"],
                CountryCode = CountryCode.GF,
                ISONumeric = "254",
                ISO3 = CountryCodeISO3.GUF,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["594"],
                Capital = "Cayenne",
                AlternativeSpellings = ["GF", "Guiana", "Guyane"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.SUR
                ],
                Landlocked = false,
                Area = 83534.0
            };
            return country;
        }
    }

    public static Country Guadeloupe
    {
        get
        {
            Country country = new()
            {
                CommonName = "Guadeloupe",
                OfficialName = "Guadeloupe",
                TLD = [".gp"],
                CountryCode = CountryCode.GP,
                ISONumeric = "312",
                ISO3 = CountryCodeISO3.GLP,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["590"],
                Capital = "Basse-Terre",
                AlternativeSpellings = ["GP", "Gwadloup"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 1628.0
            };
            return country;
        }
    }

    public static Country Guyana
    {
        get
        {
            Country country = new()
            {
                CommonName = "Guyana",
                OfficialName = "Co-operative Republic of Guyana",
                TLD = [".gy"],
                CountryCode = CountryCode.GY,
                ISONumeric = "328",
                ISO3 = CountryCodeISO3.GUY,
                CIOC = "GUY",
                Currencies = ["GYD"],
                CallingCodes = ["592"],
                Capital = "Georgetown",
                AlternativeSpellings = ["GY", "Co-operative Republic of Guyana"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.SUR,
                    CountryCodeISO3.VEN
                ],
                Landlocked = false,
                Area = 214969.0
            };
            return country;
        }
    }

    public static Country Honduras
    {
        get
        {
            Country country = new()
            {
                CommonName = "Honduras",
                OfficialName = "Republic of Honduras",
                TLD = [".hn"],
                CountryCode = CountryCode.HN,
                ISONumeric = "340",
                ISO3 = CountryCodeISO3.HND,
                CIOC = "HON",
                Currencies = ["HNL"],
                CallingCodes = ["504"],
                Capital = "Tegucigalpa",
                AlternativeSpellings = ["HN", "Republic of Honduras", "República de Honduras"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.GTM,
                    CountryCodeISO3.SLV,
                    CountryCodeISO3.NIC
                ],
                Landlocked = false,
                Area = 112492.0
            };
            return country;
        }
    }

    public static Country Haiti
    {
        get
        {
            Country country = new()
            {
                CommonName = "Haiti",
                OfficialName = "Republic of Haiti",
                TLD = [".ht"],
                CountryCode = CountryCode.HT,
                ISONumeric = "332",
                ISO3 = CountryCodeISO3.HTI,
                CIOC = "HAI",
                Currencies = ["HTG", "USD"],
                CallingCodes = ["509"],
                Capital = "Port-au-Prince",
                AlternativeSpellings = ["HT", "Republic of Haiti", "République d'Haïti", "Repiblik Ayiti"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [CountryCodeISO3.DOM],
                Landlocked = false,
                Area = 27750.0
            };
            return country;
        }
    }

    public static Country Jamaica
    {
        get
        {
            Country country = new()
            {
                CommonName = "Jamaica",
                OfficialName = "Jamaica",
                TLD = [".jm"],
                CountryCode = CountryCode.JM,
                ISONumeric = "388",
                ISO3 = CountryCodeISO3.JAM,
                CIOC = "JAM",
                Currencies = ["JMD"],
                CallingCodes = ["1876"],
                Capital = "Kingston",
                AlternativeSpellings = ["JM"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 10991.0
            };
            return country;
        }
    }

    public static Country SaintKittsandNevis
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saint Kitts and Nevis",
                OfficialName = "Federation of Saint Christopher and Nevisa",
                TLD = [".kn"],
                CountryCode = CountryCode.KN,
                ISONumeric = "659",
                ISO3 = CountryCodeISO3.KNA,
                CIOC = "SKN",
                Currencies = ["XCD"],
                CallingCodes = ["1869"],
                Capital = "Basseterre",
                AlternativeSpellings = ["KN", "Federation of Saint Christopher and Nevis"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 261.0
            };
            return country;
        }
    }

    public static Country SaintLucia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saint Lucia",
                OfficialName = "Saint Lucia",
                TLD = [".lc"],
                CountryCode = CountryCode.LC,
                ISONumeric = "662",
                ISO3 = CountryCodeISO3.LCA,
                CIOC = "LCA",
                Currencies = ["XCD"],
                CallingCodes = ["1758"],
                Capital = "Castries",
                AlternativeSpellings = ["LC"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 616.0
            };
            return country;
        }
    }

    public static Country SaintMartin
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saint Martin",
                OfficialName = "Saint Martin",
                TLD = [".fr", ".gp"],
                CountryCode = CountryCode.MF,
                ISONumeric = "663",
                ISO3 = CountryCodeISO3.MAF,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["590"],
                Capital = "Marigot",
                AlternativeSpellings = ["MF", "Collectivity of Saint Martin", "Collectivité de Saint-Martin", "Saint Martin (French part)"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [CountryCodeISO3.SXM],
                Landlocked = false,
                Area = 53.0
            };
            return country;
        }
    }

    public static Country Mexico
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mexico",
                OfficialName = "United Mexican States",
                TLD = [".mx"],
                CountryCode = CountryCode.MX,
                ISONumeric = "484",
                ISO3 = CountryCodeISO3.MEX,
                CIOC = "MEX",
                Currencies = ["MXN"],
                CallingCodes = ["52"],
                Capital = "Mexico City",
                AlternativeSpellings = ["MX", "Mexicanos", "United Mexican States", "Estados Unidos Mexicanos"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.BLZ,
                    CountryCodeISO3.GTM,
                    CountryCodeISO3.USA
                ],
                Landlocked = false,
                Area = 1964375.0
            };
            return country;
        }
    }

    public static Country Montserrat
    {
        get
        {
            Country country = new()
            {
                CommonName = "Montserrat",
                OfficialName = "Montserrat",
                TLD = [".ms"],
                CountryCode = CountryCode.MS,
                ISONumeric = "500",
                ISO3 = CountryCodeISO3.MSR,
                CIOC = "",
                Currencies = ["XCD"],
                CallingCodes = ["1664"],
                Capital = "Plymouth",
                AlternativeSpellings = ["MS"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 102.0
            };
            return country;
        }
    }

    public static Country Martinique
    {
        get
        {
            Country country = new()
            {
                CommonName = "Martinique",
                OfficialName = "Martinique",
                TLD = [".mq"],
                CountryCode = CountryCode.MQ,
                ISONumeric = "474",
                ISO3 = CountryCodeISO3.MTQ,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["596"],
                Capital = "Fort-de-France",
                AlternativeSpellings = ["MQ"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 1128.0
            };
            return country;
        }
    }

    public static Country Nicaragua
    {
        get
        {
            Country country = new()
            {
                CommonName = "Nicaragua",
                OfficialName = "Republic of Nicaragua",
                TLD = [".ni"],
                CountryCode = CountryCode.NI,
                ISONumeric = "558",
                ISO3 = CountryCodeISO3.NIC,
                CIOC = "NCA",
                Currencies = ["NIO"],
                CallingCodes = ["505"],
                Capital = "Managua",
                AlternativeSpellings = ["NI", "Republic of Nicaragua", "República de Nicaragua"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.CRI,
                    CountryCodeISO3.HND
                ],
                Landlocked = false,
                Area = 130373.0
            };
            return country;
        }
    }

    public static Country Panama
    {
        get
        {
            Country country = new()
            {
                CommonName = "Panama",
                OfficialName = "Republic of Panama",
                TLD = [".pa"],
                CountryCode = CountryCode.PA,
                ISONumeric = "591",
                ISO3 = CountryCodeISO3.PAN,
                CIOC = "PAN",
                Currencies = ["PAB", "USD"],
                CallingCodes = ["507"],
                Capital = "Panama City",
                AlternativeSpellings = ["PA", "Republic of Panama", "República de Panamá"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.COL,
                    CountryCodeISO3.CRI
                ],
                Landlocked = false,
                Area = 75417.0
            };
            return country;
        }
    }

    public static Country Peru
    {
        get
        {
            Country country = new()
            {
                CommonName = "Peru",
                OfficialName = "Republic of Peru",
                TLD = [".pe"],
                CountryCode = CountryCode.PE,
                ISONumeric = "604",
                ISO3 = CountryCodeISO3.PER,
                CIOC = "PER",
                Currencies = ["PEN"],
                CallingCodes = ["51"],
                Capital = "Lima",
                AlternativeSpellings = ["PE", "Republic of Peru", "República del Perú"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BOL,
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.CHL,
                    CountryCodeISO3.COL,
                    CountryCodeISO3.ECU
                ],
                Landlocked = false,
                Area = 1285216.0
            };
            return country;
        }
    }

    public static Country PuertoRico
    {
        get
        {
            Country country = new()
            {
                CommonName = "Puerto Rico",
                OfficialName = "Commonwealth of Puerto Rico",
                TLD = [".pr"],
                CountryCode = CountryCode.PR,
                ISONumeric = "630",
                ISO3 = CountryCodeISO3.PRI,
                CIOC = "PUR",
                Currencies = ["USD"],
                CallingCodes = ["1787", "1939"],
                Capital = "San Juan",
                AlternativeSpellings = ["PR", "Commonwealth of Puerto Rico", "Estado Libre Asociado de Puerto Rico"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 8870.0
            };
            return country;
        }
    }

    public static Country Paraguay
    {
        get
        {
            Country country = new()
            {
                CommonName = "Paraguay",
                OfficialName = "Republic of Paraguay",
                TLD = [".py"],
                CountryCode = CountryCode.PY,
                ISONumeric = "600",
                ISO3 = CountryCodeISO3.PRY,
                CIOC = "PAR",
                Currencies = ["PYG"],
                CallingCodes = ["595"],
                Capital = "Asunción",
                AlternativeSpellings = ["PY", "Republic of Paraguay", "República del Paraguay", "Tetã Paraguái"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.ARG,
                    CountryCodeISO3.BOL,
                    CountryCodeISO3.BRA
                ],
                Landlocked = true,
                Area = 406752.0
            };
            return country;
        }
    }

    public static Country SouthGeorgia
    {
        get
        {
            Country country = new()
            {
                CommonName = "South Georgia",
                OfficialName = "South Georgia and the South Sandwich Islands",
                TLD = [".gs"],
                CountryCode = CountryCode.GS,
                ISONumeric = "239",
                ISO3 = CountryCodeISO3.SGS,
                CIOC = "",
                Currencies = ["GBP"],
                CallingCodes = ["500"],
                Capital = "King Edward Point",
                AlternativeSpellings = ["GS", "South Georgia and the South Sandwich Islands"],
                Region = "Americas",
                SubRegion = "South America",
                Borders = [],
                Landlocked = false,
                Area = 3903.0
            };
            return country;
        }
    }

    public static Country ElSalvador
    {
        get
        {
            Country country = new()
            {
                CommonName = "El Salvador",
                OfficialName = "Republic of El Salvador",
                TLD = [".sv"],
                CountryCode = CountryCode.SV,
                ISONumeric = "222",
                ISO3 = CountryCodeISO3.SLV,
                CIOC = "ESA",
                Currencies = ["SVC", "USD"],
                CallingCodes = ["503"],
                Capital = "San Salvador",
                AlternativeSpellings = ["SV", "Republic of El Salvador", "República de El Salvador"],
                Region = "Americas",
                SubRegion = "Central America",
                Borders =
                [
                    CountryCodeISO3.GTM,
                    CountryCodeISO3.HND
                ],
                Landlocked = false,
                Area = 21041.0
            };
            return country;
        }
    }

    public static Country SaintPierreandMiquelon
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saint Pierre and Miquelon",
                OfficialName = "Saint Pierre and Miquelon",
                TLD = [".pm"],
                CountryCode = CountryCode.PM,
                ISONumeric = "666",
                ISO3 = CountryCodeISO3.SPM,
                CIOC = "",
                Currencies = ["EUR"],
                CallingCodes = ["508"],
                Capital = "Saint-Pierre",
                AlternativeSpellings = ["PM", "Collectivité territoriale de Saint-Pierre-et-Miquelon"],
                Region = "Americas",
                SubRegion = "Northern America",
                Borders = [],
                Landlocked = false,
                Area = 242.0
            };
            return country;
        }
    }

    public static Country Suriname
    {
        get
        {
            Country country = new()
            {
                CommonName = "Suriname",
                OfficialName = "Republic of Suriname",
                TLD = [".sr"],
                CountryCode = CountryCode.SR,
                ISONumeric = "740",
                ISO3 = CountryCodeISO3.SUR,
                CIOC = "SUR",
                Currencies = ["SRD"],
                CallingCodes = ["597"],
                Capital = "Paramaribo",
                AlternativeSpellings = ["SR", "Sarnam", "Sranangron", "Republic of Suriname", "Republiek Suriname"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.GUF,
                    CountryCodeISO3.GUY
                ],
                Landlocked = false,
                Area = 163820.0
            };
            return country;
        }
    }

    public static Country SintMaarten
    {
        get
        {
            Country country = new()
            {
                CommonName = "Sint Maarten",
                OfficialName = "Sint Maarten",
                TLD = [".sx"],
                CountryCode = CountryCode.SX,
                ISONumeric = "534",
                ISO3 = CountryCodeISO3.SXM,
                CIOC = "",
                Currencies = ["ANG"],
                CallingCodes = ["1721"],
                Capital = "Philipsburg",
                AlternativeSpellings = ["SX", "Sint Maarten (Dutch part)"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [CountryCodeISO3.MAF],
                Landlocked = false,
                Area = 34.0
            };
            return country;
        }
    }

    public static Country TurksandCaicosIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "Turks and Caicos Islands",
                OfficialName = "Turks and Caicos Islands",
                TLD = [".tc"],
                CountryCode = CountryCode.TC,
                ISONumeric = "796",
                ISO3 = CountryCodeISO3.TCA,
                CIOC = "",
                Currencies = ["USD"],
                CallingCodes = ["1649"],
                Capital = "Cockburn Town",
                AlternativeSpellings = ["TC"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 948.0
            };
            return country;
        }
    }

    public static Country TrinidadandTobago
    {
        get
        {
            Country country = new()
            {
                CommonName = "Trinidad and Tobago",
                OfficialName = "Republic of Trinidad and Tobago",
                TLD = [".tt"],
                CountryCode = CountryCode.TT,
                ISONumeric = "780",
                ISO3 = CountryCodeISO3.TTO,
                CIOC = "TTO",
                Currencies = ["TTD"],
                CallingCodes = ["1868"],
                Capital = "Port of Spain",
                AlternativeSpellings = ["TT", "Republic of Trinidad and Tobago"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 5130.0
            };
            return country;
        }
    }

    public static Country UnitedStatesMinorOutlyingIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "United States Minor Outlying Islands",
                OfficialName = "United States Minor Outlying Islands",
                TLD = [".us"],
                CountryCode = CountryCode.UM,
                ISONumeric = "581",
                ISO3 = CountryCodeISO3.UMI,
                CIOC = "",
                Currencies = ["USD"],
                Capital = "",
                AlternativeSpellings = ["UM"],
                Region = "Americas",
                SubRegion = "Northern America",
                Borders = [],
                Landlocked = false,
                Area = 34.0
            };
            return country;
        }
    }

    public static Country Uruguay
    {
        get
        {
            Country country = new()
            {
                CommonName = "Uruguay",
                OfficialName = "Oriental Republic of Uruguay",
                TLD = [".uy"],
                CountryCode = CountryCode.UY,
                ISONumeric = "858",
                ISO3 = CountryCodeISO3.URY,
                CIOC = "URU",
                Currencies = ["UYI", "UYU"],
                CallingCodes = ["598"],
                Capital = "Montevideo",
                AlternativeSpellings = ["UY", "Oriental Republic of Uruguay", "República Oriental del Uruguay"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.ARG,
                    CountryCodeISO3.BRA
                ],
                Landlocked = false,
                Area = 181034.0
            };
            return country;
        }
    }

    public static Country UnitedStates
    {
        get
        {
            Country country = new()
            {
                CommonName = "United States",
                OfficialName = "United States of America",
                TLD = [".us"],
                CountryCode = CountryCode.US,
                ISONumeric = "840",
                ISO3 = CountryCodeISO3.USA,
                CIOC = "USA",
                Currencies = ["USD", "USN", "USS"],
                CallingCodes = ["1"],
                Capital = "Washington D.C.",
                AlternativeSpellings = ["US", "USA", "United States of America"],
                Region = "Americas",
                SubRegion = "Northern America",
                Borders =
                [
                    CountryCodeISO3.CAN,
                    CountryCodeISO3.MEX
                ],
                Landlocked = false,
                Area = 9372610.0
            };
            return country;
        }
    }

    public static Country SaintVincentandtheGrenadines
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saint Vincent and the Grenadines",
                OfficialName = "Saint Vincent and the Grenadines",
                TLD = [".vc"],
                CountryCode = CountryCode.VC,
                ISONumeric = "670",
                ISO3 = CountryCodeISO3.VCT,
                CIOC = "VIN",
                Currencies = ["XCD"],
                CallingCodes = ["1784"],
                Capital = "Kingstown",
                AlternativeSpellings = ["VC"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 389.0
            };
            return country;
        }
    }

    public static Country Venezuela
    {
        get
        {
            Country country = new()
            {
                CommonName = "Venezuela",
                OfficialName = "Bolivarian Republic of Venezuela",
                TLD = [".ve"],
                CountryCode = CountryCode.VE,
                ISONumeric = "862",
                ISO3 = CountryCodeISO3.VEN,
                CIOC = "VEN",
                Currencies = ["VEF"],
                CallingCodes = ["58"],
                Capital = "Caracas",
                AlternativeSpellings = ["VE", "Bolivarian Republic of Venezuela", "Venezuela, Bolivarian Republic of", "República Bolivariana de Venezuela"],
                Region = "Americas",
                SubRegion = "South America",
                Borders =
                [
                    CountryCodeISO3.BRA,
                    CountryCodeISO3.COL,
                    CountryCodeISO3.GUY
                ],
                Landlocked = false,
                Area = 916445.0
            };
            return country;
        }
    }

    public static Country BritishVirginIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "British Virgin Islands",
                OfficialName = "Virgin Islands",
                TLD = [".vg"],
                CountryCode = CountryCode.VG,
                ISONumeric = "092",
                ISO3 = CountryCodeISO3.VGB,
                CIOC = "IVB",
                Currencies = ["USD"],
                CallingCodes = ["1284"],
                Capital = "Road Town",
                AlternativeSpellings = ["VG", "Virgin Islands, British"],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 151.0
            };
            return country;
        }
    }

    public static Country UnitedStatesVirginIslands
    {
        get
        {
            Country country = new()
            {
                CommonName = "United States Virgin Islands",
                OfficialName = "Virgin Islands of the United States",
                TLD = [".vi"],
                CountryCode = CountryCode.VI,
                ISONumeric = "850",
                ISO3 = CountryCodeISO3.VIR,
                CIOC = "ISV",
                Currencies = ["USD"],
                CallingCodes = ["1340"],
                Capital = "Charlotte Amalie",
                AlternativeSpellings = ["VI", "Virgin Islands, U.S."],
                Region = "Americas",
                SubRegion = "Caribbean",
                Borders = [],
                Landlocked = false,
                Area = 347.0
            };
            return country;
        }
    }
}
