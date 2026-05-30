namespace Countries;

public partial struct Country
{
    public static Country Afghanistan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Afghanistan",
                OfficialName = "Islamic Republic of Afghanistan",
                TLD = [".af"],
                CountryCode = CountryCode.AF,
                ISONumeric = "004",
                ISO3 = CountryCodeISO3.AFG,
                CIOC = "AFG",
                Currencies = ["AFN"],
                CallingCodes = ["93"],
                Capital = "Kabul",
                AlternativeSpellings = ["AF", "Afġānistān"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.IRN,
                    CountryCodeISO3.PAK,
                    CountryCodeISO3.TKM,
                    CountryCodeISO3.UZB,
                    CountryCodeISO3.TJK,
                    CountryCodeISO3.CHN
                ],
                Landlocked = true,
                Area = 652230.0
            };
            return country;
        }
    }

    public static Country UnitedArabEmirates
    {
        get
        {
            Country country = new()
            {
                CommonName = "United Arab Emirates",
                OfficialName = "United Arab Emirates",
                TLD = [".ae", "امارات."],
                CountryCode = CountryCode.AE,
                ISONumeric = "784",
                ISO3 = CountryCodeISO3.ARE,
                CIOC = "UAE",
                Currencies = ["AED"],
                CallingCodes = ["971"],
                Capital = "Abu Dhabi",
                AlternativeSpellings = ["AE", "UAE", "Emirates"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.OMN,
                    CountryCodeISO3.SAU
                ],
                Landlocked = false,
                Area = 83600.0
            };
            return country;
        }
    }

    public static Country Armenia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Armenia",
                OfficialName = "Republic of Armenia",
                TLD = [".am"],
                CountryCode = CountryCode.AM,
                ISONumeric = "051",
                ISO3 = CountryCodeISO3.ARM,
                CIOC = "ARM",
                Currencies = ["AMD"],
                CallingCodes = ["374"],
                Capital = "Yerevan",
                AlternativeSpellings = ["AM", "Hayastan", "Republic of Armenia", "Հայաստանի Հանրապետություն"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.AZE,
                    CountryCodeISO3.GEO,
                    CountryCodeISO3.IRN,
                    CountryCodeISO3.TUR
                ],
                Landlocked = true,
                Area = 29743.0
            };
            return country;
        }
    }

    public static Country Azerbaijan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Azerbaijan",
                OfficialName = "Republic of Azerbaijan",
                TLD = [".az"],
                CountryCode = CountryCode.AZ,
                ISONumeric = "031",
                ISO3 = CountryCodeISO3.AZE,
                CIOC = "AZE",
                Currencies = ["AZN"],
                CallingCodes = ["994"],
                Capital = "Baku",
                AlternativeSpellings = ["AZ", "Republic of Azerbaijan", "Azərbaycan Respublikası"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.ARM,
                    CountryCodeISO3.GEO,
                    CountryCodeISO3.IRN,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.TUR
                ],
                Landlocked = true,
                Area = 86600.0
            };
            return country;
        }
    }

    public static Country Bangladesh
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bangladesh",
                OfficialName = "People's Republic of Bangladesh",
                TLD = [".bd"],
                CountryCode = CountryCode.BD,
                ISONumeric = "050",
                ISO3 = CountryCodeISO3.BGD,
                CIOC = "BAN",
                Currencies = ["BDT"],
                CallingCodes = ["880"],
                Capital = "Dhaka",
                AlternativeSpellings = ["BD", "People's Republic of Bangladesh", "Gônôprôjatôntri Bangladesh"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.MMR,
                    CountryCodeISO3.IND
                ],
                Landlocked = false,
                Area = 147570.0
            };
            return country;
        }
    }

    public static Country Bahrain
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bahrain",
                OfficialName = "Kingdom of Bahrain",
                TLD = [".bh"],
                CountryCode = CountryCode.BH,
                ISONumeric = "048",
                ISO3 = CountryCodeISO3.BHR,
                CIOC = "BRN",
                Currencies = ["BHD"],
                CallingCodes = ["973"],
                Capital = "Manama",
                AlternativeSpellings = ["BH", "Kingdom of Bahrain", "Mamlakat al-Baḥrayn"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders = [],
                Landlocked = false,
                Area = 765.0
            };
            return country;
        }
    }

    public static Country Brunei
    {
        get
        {
            Country country = new()
            {
                CommonName = "Brunei",
                OfficialName = "Nation of Brunei, Abode of Peace",
                TLD = [".bn"],
                CountryCode = CountryCode.BN,
                ISONumeric = "096",
                ISO3 = CountryCodeISO3.BRN,
                CIOC = "BRU",
                Currencies = ["BND"],
                CallingCodes = ["673"],
                Capital = "Bandar Seri Begawan",
                AlternativeSpellings = ["BN", "Brunei Darussalam", "Nation of Brunei", "the Abode of Peace"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders = [CountryCodeISO3.MYS],
                Landlocked = false,
                Area = 5765.0
            };
            return country;
        }
    }

    public static Country Bhutan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Bhutan",
                OfficialName = "Kingdom of Bhutan",
                TLD = [".bt"],
                CountryCode = CountryCode.BT,
                ISONumeric = "064",
                ISO3 = CountryCodeISO3.BTN,
                CIOC = "BHU",
                Currencies = ["BTN", "INR"],
                CallingCodes = ["975"],
                Capital = "Thimphu",
                AlternativeSpellings = ["BT", "Kingdom of Bhutan"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.IND
                ],
                Landlocked = true,
                Area = 38394.0
            };
            return country;
        }
    }

    public static Country China
    {
        get
        {
            Country country = new()
            {
                CommonName = "China",
                OfficialName = "People's Republic of China",
                TLD = [".cn", ".中国", ".中國", ".公司", ".网络"],
                CountryCode = CountryCode.CN,
                ISONumeric = "156",
                ISO3 = CountryCodeISO3.CHN,
                CIOC = "CHN",
                Currencies = ["CNY"],
                CallingCodes = ["86"],
                Capital = "Beijing",
                AlternativeSpellings = ["CN", "Zhōngguó", "Zhongguo", "Zhonghua", "People's Republic of China", "中华人民共和国", "Zhōnghuá Rénmín Gònghéguó"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.BTN,
                    CountryCodeISO3.MMR,
                    CountryCodeISO3.HKG,
                    CountryCodeISO3.IND,
                    CountryCodeISO3.KAZ,
                    CountryCodeISO3.PRK,
                    CountryCodeISO3.KGZ,
                    CountryCodeISO3.LAO,
                    CountryCodeISO3.MAC,
                    CountryCodeISO3.MNG,
                    CountryCodeISO3.PAK,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.TJK,
                    CountryCodeISO3.VNM
                ],
                Landlocked = false,
                Area = 9706961.0
            };
            return country;
        }
    }

    public static Country Georgia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Georgia",
                OfficialName = "Georgia",
                TLD = [".ge"],
                CountryCode = CountryCode.GE,
                ISONumeric = "268",
                ISO3 = CountryCodeISO3.GEO,
                CIOC = "GEO",
                Currencies = ["GEL"],
                CallingCodes = ["995"],
                Capital = "Tbilisi",
                AlternativeSpellings = ["GE", "Sakartvelo"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.ARM,
                    CountryCodeISO3.AZE,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.TUR
                ],
                Landlocked = false,
                Area = 69700.0
            };
            return country;
        }
    }

    public static Country HongKong
    {
        get
        {
            Country country = new()
            {
                CommonName = "Hong Kong",
                OfficialName = "Hong Kong Special Administrative Region of the People's Republic of China",
                TLD = [".hk", ".香港"],
                CountryCode = CountryCode.HK,
                ISONumeric = "344",
                ISO3 = CountryCodeISO3.HKG,
                CIOC = "HKG",
                Currencies = ["HKD"],
                CallingCodes = ["852"],
                Capital = "City of Victoria",
                AlternativeSpellings = ["HK"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders = [CountryCodeISO3.CHN],
                Landlocked = false,
                Area = 1104.0
            };
            return country;
        }
    }

    public static Country Indonesia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Indonesia",
                OfficialName = "Republic of Indonesia",
                TLD = [".id"],
                CountryCode = CountryCode.ID,
                ISONumeric = "360",
                ISO3 = CountryCodeISO3.IDN,
                CIOC = "INA",
                Currencies = ["IDR"],
                CallingCodes = ["62"],
                Capital = "Jakarta",
                AlternativeSpellings = ["ID", "Republic of Indonesia", "Republik Indonesia"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.TLS,
                    CountryCodeISO3.MYS,
                    CountryCodeISO3.PNG
                ],
                Landlocked = false,
                Area = 1904569.0
            };
            return country;
        }
    }

    public static Country India
    {
        get
        {
            Country country = new()
            {
                CommonName = "India",
                OfficialName = "Republic of India",
                TLD = [".in"],
                CountryCode = CountryCode.IN,
                ISONumeric = "356",
                ISO3 = CountryCodeISO3.IND,
                CIOC = "IND",
                Currencies = ["INR"],
                CallingCodes = ["91"],
                Capital = "New Delhi",
                AlternativeSpellings = ["IN", "Bhārat", "Republic of India", "Bharat Ganrajya", "இந்தியா"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.BGD,
                    CountryCodeISO3.BTN,
                    CountryCodeISO3.MMR,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.NPL,
                    CountryCodeISO3.PAK,
                    CountryCodeISO3.LKA
                ],
                Landlocked = false,
                Area = 3287590.0
            };
            return country;
        }
    }

    public static Country Iran
    {
        get
        {
            Country country = new()
            {
                CommonName = "Iran",
                OfficialName = "Islamic Republic of Iran",
                TLD = [".ir", "ایران."],
                CountryCode = CountryCode.IR,
                ISONumeric = "364",
                ISO3 = CountryCodeISO3.IRN,
                CIOC = "IRI",
                Currencies = ["IRR"],
                CallingCodes = ["98"],
                Capital = "Tehran",
                AlternativeSpellings = ["IR", "Islamic Republic of Iran", "Iran, Islamic Republic of", "Jomhuri-ye Eslāmi-ye Irān"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.ARM,
                    CountryCodeISO3.AZE,
                    CountryCodeISO3.IRQ,
                    CountryCodeISO3.PAK,
                    CountryCodeISO3.TUR,
                    CountryCodeISO3.TKM
                ],
                Landlocked = false,
                Area = 1648195.0
            };
            return country;
        }
    }

    public static Country Iraq
    {
        get
        {
            Country country = new()
            {
                CommonName = "Iraq",
                OfficialName = "Republic of Iraq",
                TLD = [".iq"],
                CountryCode = CountryCode.IQ,
                ISONumeric = "368",
                ISO3 = CountryCodeISO3.IRQ,
                CIOC = "IRQ",
                Currencies = ["IQD"],
                CallingCodes = ["964"],
                Capital = "Baghdad",
                AlternativeSpellings = ["IQ", "Republic of Iraq", "Jumhūriyyat al-'Irāq"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.IRN,
                    CountryCodeISO3.JOR,
                    CountryCodeISO3.KWT,
                    CountryCodeISO3.SAU,
                    CountryCodeISO3.SYR,
                    CountryCodeISO3.TUR
                ],
                Landlocked = false,
                Area = 438317.0
            };
            return country;
        }
    }

    public static Country Israel
    {
        get
        {
            Country country = new()
            {
                CommonName = "Israel",
                OfficialName = "State of Israel",
                TLD = [".il"],
                CountryCode = CountryCode.IL,
                ISONumeric = "376",
                ISO3 = CountryCodeISO3.ISR,
                CIOC = "ISR",
                Currencies = ["ILS"],
                CallingCodes = ["972"],
                Capital = "Jerusalem",
                AlternativeSpellings = ["IL", "State of Israel", "Medīnat Yisrā'el"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.EGY,
                    CountryCodeISO3.JOR,
                    CountryCodeISO3.LBN,
                    CountryCodeISO3.SYR
                ],
                Landlocked = false,
                Area = 20770.0
            };
            return country;
        }
    }

    public static Country Jordan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Jordan",
                OfficialName = "Hashemite Kingdom of Jordan",
                TLD = [".jo", "الاردن."],
                CountryCode = CountryCode.JO,
                ISONumeric = "400",
                ISO3 = CountryCodeISO3.JOR,
                CIOC = "JOR",
                Currencies = ["JOD"],
                CallingCodes = ["962"],
                Capital = "Amman",
                AlternativeSpellings = ["JO", "Hashemite Kingdom of Jordan", "al-Mamlakah al-Urdunīyah al-Hāshimīyah"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.IRQ,
                    CountryCodeISO3.ISR,
                    CountryCodeISO3.SAU,
                    CountryCodeISO3.SYR
                ],
                Landlocked = false,
                Area = 89342.0
            };
            return country;
        }
    }

    public static Country Japan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Japan",
                OfficialName = "Japan",
                TLD = [".jp", ".みんな"],
                CountryCode = CountryCode.JP,
                ISONumeric = "392",
                ISO3 = CountryCodeISO3.JPN,
                CIOC = "JPN",
                Currencies = ["JPY"],
                CallingCodes = ["81"],
                Capital = "Tokyo",
                AlternativeSpellings = ["JP", "Nippon", "Nihon"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders = [],
                Landlocked = false,
                Area = 377930.0
            };
            return country;
        }
    }

    public static Country Kazakhstan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Kazakhstan",
                OfficialName = "Republic of Kazakhstan",
                TLD = [".kz", ".қаз"],
                CountryCode = CountryCode.KZ,
                ISONumeric = "398",
                ISO3 = CountryCodeISO3.KAZ,
                CIOC = "KAZ",
                Currencies = ["KZT"],
                CallingCodes = ["76", "77"],
                Capital = "Astana",
                AlternativeSpellings = ["KZ", "Qazaqstan", "Казахстан", "Republic of Kazakhstan", "Қазақстан Республикасы", "Qazaqstan Respublïkası", "Республика Казахстан", "Respublika Kazakhstan"],
                Continent = Continent.Asia,
                Region = "Central Asia",
                Borders =
                [
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.KGZ,
                    CountryCodeISO3.RUS,
                    CountryCodeISO3.TKM,
                    CountryCodeISO3.UZB
                ],
                Landlocked = true,
                Area = 2724900.0
            };
            return country;
        }
    }

    public static Country Kyrgyzstan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Kyrgyzstan",
                OfficialName = "Kyrgyz Republic",
                TLD = [".kg"],
                CountryCode = CountryCode.KG,
                ISONumeric = "417",
                ISO3 = CountryCodeISO3.KGZ,
                CIOC = "KGZ",
                Currencies = ["KGS"],
                CallingCodes = ["996"],
                Capital = "Bishkek",
                AlternativeSpellings = ["KG", "Киргизия", "Kyrgyz Republic", "Кыргыз Республикасы", "Kyrgyz Respublikasy"],
                Continent = Continent.Asia,
                Region = "Central Asia",
                Borders =
                [
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.KAZ,
                    CountryCodeISO3.TJK,
                    CountryCodeISO3.UZB
                ],
                Landlocked = true,
                Area = 199951.0
            };
            return country;
        }
    }

    public static Country Cambodia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Cambodia",
                OfficialName = "Kingdom of Cambodia",
                TLD = [".kh"],
                CountryCode = CountryCode.KH,
                ISONumeric = "116",
                ISO3 = CountryCodeISO3.KHM,
                CIOC = "CAM",
                Currencies = ["KHR"],
                CallingCodes = ["855"],
                Capital = "Phnom Penh",
                AlternativeSpellings = ["KH", "Kingdom of Cambodia"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.LAO,
                    CountryCodeISO3.THA,
                    CountryCodeISO3.VNM
                ],
                Landlocked = false,
                Area = 181035.0
            };
            return country;
        }
    }

    public static Country SouthKorea
    {
        get
        {
            Country country = new()
            {
                CommonName = "South Korea",
                OfficialName = "Republic of Korea",
                TLD = [".kr", ".한국"],
                CountryCode = CountryCode.KR,
                ISONumeric = "410",
                ISO3 = CountryCodeISO3.KOR,
                CIOC = "KOR",
                Currencies = ["KRW"],
                CallingCodes = ["82"],
                Capital = "Seoul",
                AlternativeSpellings = ["KR", "Korea, Republic of", "Republic of Korea"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders = [CountryCodeISO3.PRK],
                Landlocked = false,
                Area = 100210.0
            };
            return country;
        }
    }

    public static Country Kuwait
    {
        get
        {
            Country country = new()
            {
                CommonName = "Kuwait",
                OfficialName = "State of Kuwait",
                TLD = [".kw"],
                CountryCode = CountryCode.KW,
                ISONumeric = "414",
                ISO3 = CountryCodeISO3.KWT,
                CIOC = "KUW",
                Currencies = ["KWD"],
                CallingCodes = ["965"],
                Capital = "Kuwait City",
                AlternativeSpellings = ["KW", "State of Kuwait", "Dawlat al-Kuwait"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.IRQ,
                    CountryCodeISO3.SAU
                ],
                Landlocked = false,
                Area = 17818.0
            };
            return country;
        }
    }

    public static Country Laos
    {
        get
        {
            Country country = new()
            {
                CommonName = "Laos",
                OfficialName = "Lao People's Democratic Republic",
                TLD = [".la"],
                CountryCode = CountryCode.LA,
                ISONumeric = "418",
                ISO3 = CountryCodeISO3.LAO,
                CIOC = "LAO",
                Currencies = ["LAK"],
                CallingCodes = ["856"],
                Capital = "Vientiane",
                AlternativeSpellings = ["LA", "Lao", "Lao People's Democratic Republic", "Sathalanalat Paxathipatai Paxaxon Lao"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.MMR,
                    CountryCodeISO3.KHM,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.THA,
                    CountryCodeISO3.VNM
                ],
                Landlocked = true,
                Area = 236800.0
            };
            return country;
        }
    }

    public static Country Lebanon
    {
        get
        {
            Country country = new()
            {
                CommonName = "Lebanon",
                OfficialName = "Lebanese Republic",
                TLD = [".lb"],
                CountryCode = CountryCode.LB,
                ISONumeric = "422",
                ISO3 = CountryCodeISO3.LBN,
                CIOC = "LIB",
                Currencies = ["LBP"],
                CallingCodes = ["961"],
                Capital = "Beirut",
                AlternativeSpellings = ["LB", "Lebanese Republic", "Al-Jumhūrīyah Al-Libnānīyah"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.ISR,
                    CountryCodeISO3.SYR
                ],
                Landlocked = false,
                Area = 10452.0
            };
            return country;
        }
    }

    public static Country SriLanka
    {
        get
        {
            Country country = new()
            {
                CommonName = "Sri Lanka",
                OfficialName = "Democratic Socialist Republic of Sri Lanka",
                TLD = [".lk", ".இலங்கை", ".ලංකා"],
                CountryCode = CountryCode.LK,
                ISONumeric = "144",
                ISO3 = CountryCodeISO3.LKA,
                CIOC = "SRI",
                Currencies = ["LKR"],
                CallingCodes = ["94"],
                Capital = "Colombo",
                AlternativeSpellings = ["LK", "ilaṅkai", "Democratic Socialist Republic of Sri Lanka"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders = [CountryCodeISO3.IND],
                Landlocked = false,
                Area = 65610.0
            };
            return country;
        }
    }

    public static Country Macau
    {
        get
        {
            Country country = new()
            {
                CommonName = "Macau",
                OfficialName = "Macao Special Administrative Region of the People's Republic of China",
                TLD = [".mo"],
                CountryCode = CountryCode.MO,
                ISONumeric = "446",
                ISO3 = CountryCodeISO3.MAC,
                CIOC = "",
                Currencies = ["MOP"],
                CallingCodes = ["853"],
                Capital = "",
                AlternativeSpellings = ["MO", "澳门", "Macao", "Macao Special Administrative Region of the People's Republic of China", "中華人民共和國澳門特別行政區", "Região Administrativa Especial de Macau da República Popular da China"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders = [CountryCodeISO3.CHN],
                Landlocked = false,
                Area = 30.0
            };
            return country;
        }
    }

    public static Country Maldives
    {
        get
        {
            Country country = new()
            {
                CommonName = "Maldives",
                OfficialName = "Republic of the Maldives",
                TLD = [".mv"],
                CountryCode = CountryCode.MV,
                ISONumeric = "462",
                ISO3 = CountryCodeISO3.MDV,
                CIOC = "MDV",
                Currencies = ["MVR"],
                CallingCodes = ["960"],
                Capital = "Malé",
                AlternativeSpellings = ["MV", "Maldive Islands", "Republic of the Maldives", "Dhivehi Raajjeyge Jumhooriyya"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders = [],
                Landlocked = false,
                Area = 300.0
            };
            return country;
        }
    }

    public static Country Myanmar
    {
        get
        {
            Country country = new()
            {
                CommonName = "Myanmar",
                OfficialName = "Republic of the Union of Myanmar",
                TLD = [".mm"],
                CountryCode = CountryCode.MM,
                ISONumeric = "104",
                ISO3 = CountryCodeISO3.MMR,
                CIOC = "MYA",
                Currencies = ["MMK"],
                CallingCodes = ["95"],
                Capital = "Naypyidaw",
                AlternativeSpellings = ["MM", "Burma", "Republic of the Union of Myanmar", "Pyidaunzu Thanmăda Myăma Nainngandaw"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.BGD,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.IND,
                    CountryCodeISO3.LAO,
                    CountryCodeISO3.THA
                ],
                Landlocked = false,
                Area = 676578.0
            };
            return country;
        }
    }

    public static Country Mongolia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Mongolia",
                OfficialName = "Mongolia",
                TLD = [".mn"],
                CountryCode = CountryCode.MN,
                ISONumeric = "496",
                ISO3 = CountryCodeISO3.MNG,
                CIOC = "MGL",
                Currencies = ["MNT"],
                CallingCodes = ["976"],
                Capital = "Ulan Bator",
                AlternativeSpellings = ["MN"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.RUS
                ],
                Landlocked = true,
                Area = 1564110.0
            };
            return country;
        }
    }

    public static Country Malaysia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Malaysia",
                OfficialName = "Malaysia",
                TLD = [".my"],
                CountryCode = CountryCode.MY,
                ISONumeric = "458",
                ISO3 = CountryCodeISO3.MYS,
                CIOC = "MAS",
                Currencies = ["MYR"],
                CallingCodes = ["60"],
                Capital = "Kuala Lumpur",
                AlternativeSpellings = ["MY"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.BRN,
                    CountryCodeISO3.IDN,
                    CountryCodeISO3.THA
                ],
                Landlocked = false,
                Area = 330803.0
            };
            return country;
        }
    }

    public static Country Nepal
    {
        get
        {
            Country country = new()
            {
                CommonName = "Nepal",
                OfficialName = "Federal Democratic Republic of Nepal",
                TLD = [".np"],
                CountryCode = CountryCode.NP,
                ISONumeric = "524",
                ISO3 = CountryCodeISO3.NPL,
                CIOC = "NEP",
                Currencies = ["NPR"],
                CallingCodes = ["977"],
                Capital = "Kathmandu",
                AlternativeSpellings = ["NP", "Federal Democratic Republic of Nepal", "Loktāntrik Ganatantra Nepāl"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.IND
                ],
                Landlocked = true,
                Area = 147181.0
            };
            return country;
        }
    }

    public static Country Oman
    {
        get
        {
            Country country = new()
            {
                CommonName = "Oman",
                OfficialName = "Sultanate of Oman",
                TLD = [".om"],
                CountryCode = CountryCode.OM,
                ISONumeric = "512",
                ISO3 = CountryCodeISO3.OMN,
                CIOC = "OMA",
                Currencies = ["OMR"],
                CallingCodes = ["968"],
                Capital = "Muscat",
                AlternativeSpellings = ["OM", "Sultanate of Oman", "Salṭanat ʻUmān"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.SAU,
                    CountryCodeISO3.ARE,
                    CountryCodeISO3.YEM
                ],
                Landlocked = false,
                Area = 309500.0
            };
            return country;
        }
    }

    public static Country Pakistan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Pakistan",
                OfficialName = "Islamic Republic of Pakistan",
                TLD = [".pk"],
                CountryCode = CountryCode.PK,
                ISONumeric = "586",
                ISO3 = CountryCodeISO3.PAK,
                CIOC = "PAK",
                Currencies = ["PKR"],
                CallingCodes = ["92"],
                Capital = "Islamabad",
                AlternativeSpellings = ["PK", "Pākistān", "Islamic Republic of Pakistan", "Islāmī Jumhūriya'eh Pākistān"],
                Continent = Continent.Asia,
                Region = "Southern Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.IND,
                    CountryCodeISO3.IRN
                ],
                Landlocked = false,
                Area = 881912.0
            };
            return country;
        }
    }

    public static Country Philippines
    {
        get
        {
            Country country = new()
            {
                CommonName = "Philippines",
                OfficialName = "Republic of the Philippines",
                TLD = [".ph"],
                CountryCode = CountryCode.PH,
                ISONumeric = "608",
                ISO3 = CountryCodeISO3.PHL,
                CIOC = "PHI",
                Currencies = ["PHP"],
                CallingCodes = ["63"],
                Capital = "Manila",
                AlternativeSpellings = ["PH", "Republic of the Philippines", "Repúblika ng Pilipinas"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders = [],
                Landlocked = false,
                Area = 342353.0
            };
            return country;
        }
    }

    public static Country NorthKorea
    {
        get
        {
            Country country = new()
            {
                CommonName = "North Korea",
                OfficialName = "Democratic People's Republic of Korea",
                TLD = [".kp"],
                CountryCode = CountryCode.KP,
                ISONumeric = "408",
                ISO3 = CountryCodeISO3.PRK,
                CIOC = "PRK",
                Currencies = ["KPW"],
                CallingCodes = ["850"],
                Capital = "Pyongyang",
                AlternativeSpellings = ["KP", "Democratic People's Republic of Korea", "조선민주주의인민공화국", "Chosŏn Minjujuŭi Inmin Konghwaguk", "Korea, Democratic People's Republic of"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.KOR,
                    CountryCodeISO3.RUS
                ],
                Landlocked = false,
                Area = 120538.0
            };
            return country;
        }
    }

    public static Country Palestine
    {
        get
        {
            Country country = new()
            {
                CommonName = "Palestine",
                OfficialName = "State of Palestine",
                TLD = [".ps", "فلسطين."],
                CountryCode = CountryCode.PS,
                ISONumeric = "275",
                ISO3 = CountryCodeISO3.PSE,
                CIOC = "PLE",
                Currencies = ["ILS"],
                CallingCodes = ["970"],
                Capital = "Ramallah",
                AlternativeSpellings = ["PS", "Palestine, State of", "State of Palestine", "Dawlat Filasṭin"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.ISR,
                    CountryCodeISO3.EGY,
                    CountryCodeISO3.JOR
                ],
                Landlocked = false,
                Area = 6220.0
            };
            return country;
        }
    }

    public static Country Qatar
    {
        get
        {
            Country country = new()
            {
                CommonName = "Qatar",
                OfficialName = "State of Qatar",
                TLD = [".qa", "قطر."],
                CountryCode = CountryCode.QA,
                ISONumeric = "634",
                ISO3 = CountryCodeISO3.QAT,
                CIOC = "QAT",
                Currencies = ["QAR"],
                CallingCodes = ["974"],
                Capital = "Doha",
                AlternativeSpellings = ["QA", "State of Qatar", "Dawlat Qaṭar"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders = [CountryCodeISO3.SAU],
                Landlocked = false,
                Area = 11586.0
            };
            return country;
        }
    }

    public static Country SaudiArabia
    {
        get
        {
            Country country = new()
            {
                CommonName = "Saudi Arabia",
                OfficialName = "Kingdom of Saudi Arabia",
                TLD = [".sa", ".السعودية"],
                CountryCode = CountryCode.SA,
                ISONumeric = "682",
                ISO3 = CountryCodeISO3.SAU,
                CIOC = "KSA",
                Currencies = ["SAR"],
                CallingCodes = ["966"],
                Capital = "Riyadh",
                AlternativeSpellings = ["Saudi", "SA", "Kingdom of Saudi Arabia", "Al-Mamlakah al-'Arabiyyah as-Su'ūdiyyah"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.IRQ,
                    CountryCodeISO3.JOR,
                    CountryCodeISO3.KWT,
                    CountryCodeISO3.OMN,
                    CountryCodeISO3.QAT,
                    CountryCodeISO3.ARE,
                    CountryCodeISO3.YEM
                ],
                Landlocked = false,
                Area = 2149690.0
            };
            return country;
        }
    }

    public static Country Singapore
    {
        get
        {
            Country country = new()
            {
                CommonName = "Singapore",
                OfficialName = "Republic of Singapore",
                TLD = [".sg", ".新加坡", ".சிங்கப்பூர்"],
                CountryCode = CountryCode.SG,
                ISONumeric = "702",
                ISO3 = CountryCodeISO3.SGP,
                CIOC = "SIN",
                Currencies = ["SGD"],
                CallingCodes = ["65"],
                Capital = "Singapore",
                AlternativeSpellings = ["SG", "Singapura", "Republik Singapura", "新加坡共和国"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders = [],
                Landlocked = false,
                Area = 710.0
            };
            return country;
        }
    }

    public static Country Syria
    {
        get
        {
            Country country = new()
            {
                CommonName = "Syria",
                OfficialName = "Syrian Arab Republic",
                TLD = [".sy", "سوريا."],
                CountryCode = CountryCode.SY,
                ISONumeric = "760",
                ISO3 = CountryCodeISO3.SYR,
                CIOC = "SYR",
                Currencies = ["SYP"],
                CallingCodes = ["963"],
                Capital = "Damascus",
                AlternativeSpellings = ["SY", "Syrian Arab Republic", "Al-Jumhūrīyah Al-ʻArabīyah As-Sūrīyah"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.IRQ,
                    CountryCodeISO3.ISR,
                    CountryCodeISO3.JOR,
                    CountryCodeISO3.LBN,
                    CountryCodeISO3.TUR
                ],
                Landlocked = false,
                Area = 185180.0
            };
            return country;
        }
    }

    public static Country Thailand
    {
        get
        {
            Country country = new()
            {
                CommonName = "Thailand",
                OfficialName = "Kingdom of Thailand",
                TLD = [".th", ".ไทย"],
                CountryCode = CountryCode.TH,
                ISONumeric = "764",
                ISO3 = CountryCodeISO3.THA,
                CIOC = "THA",
                Currencies = ["THB"],
                CallingCodes = ["66"],
                Capital = "Bangkok",
                AlternativeSpellings = ["TH", "Prathet", "Thai", "Kingdom of Thailand", "ราชอาณาจักรไทย", "Ratcha Anachak Thai"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.MMR,
                    CountryCodeISO3.KHM,
                    CountryCodeISO3.LAO,
                    CountryCodeISO3.MYS
                ],
                Landlocked = false,
                Area = 513120.0
            };
            return country;
        }
    }

    public static Country Tajikistan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Tajikistan",
                OfficialName = "Republic of Tajikistan",
                TLD = [".tj"],
                CountryCode = CountryCode.TJ,
                ISONumeric = "762",
                ISO3 = CountryCodeISO3.TJK,
                CIOC = "TJK",
                Currencies = ["TJS"],
                CallingCodes = ["992"],
                Capital = "Dushanbe",
                AlternativeSpellings = ["TJ", "Toçikiston", "Republic of Tajikistan", "Ҷумҳурии Тоҷикистон", "Çumhuriyi Toçikiston"],
                Continent = Continent.Asia,
                Region = "Central Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.KGZ,
                    CountryCodeISO3.UZB
                ],
                Landlocked = true,
                Area = 143100.0
            };
            return country;
        }
    }

    public static Country Turkmenistan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Turkmenistan",
                OfficialName = "Turkmenistan",
                TLD = [".tm"],
                CountryCode = CountryCode.TM,
                ISONumeric = "795",
                ISO3 = CountryCodeISO3.TKM,
                CIOC = "TKM",
                Currencies = ["TMT"],
                CallingCodes = ["993"],
                Capital = "Ashgabat",
                AlternativeSpellings = ["TM"],
                Continent = Continent.Asia,
                Region = "Central Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.IRN,
                    CountryCodeISO3.KAZ,
                    CountryCodeISO3.UZB
                ],
                Landlocked = true,
                Area = 488100.0
            };
            return country;
        }
    }

    public static Country TimorLeste
    {
        get
        {
            Country country = new()
            {
                CommonName = "Timor-Leste",
                OfficialName = "Democratic Republic of Timor-Leste",
                TLD = [".tl"],
                CountryCode = CountryCode.TL,
                ISONumeric = "626",
                ISO3 = CountryCodeISO3.TLS,
                CIOC = "TLS",
                Currencies = ["USD"],
                CallingCodes = ["670"],
                Capital = "Dili",
                AlternativeSpellings = ["TL", "East Timor", "Democratic Republic of Timor-Leste", "República Democrática de Timor-Leste", "Repúblika Demokrátika Timór-Leste", "Timór Lorosa'e", "Timor Lorosae"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders = [CountryCodeISO3.IDN],
                Landlocked = false,
                Area = 14874.0
            };
            return country;
        }
    }

    public static Country Turkey
    {
        get
        {
            Country country = new()
            {
                CommonName = "Turkey",
                OfficialName = "Republic of Turkey",
                TLD = [".tr"],
                CountryCode = CountryCode.TR,
                ISONumeric = "792",
                ISO3 = CountryCodeISO3.TUR,
                CIOC = "TUR",
                Currencies = ["TRY"],
                CallingCodes = ["90"],
                Capital = "Ankara",
                AlternativeSpellings = ["TR", "Turkiye", "Republic of Turkey", "Türkiye Cumhuriyeti"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.ARM,
                    CountryCodeISO3.AZE,
                    CountryCodeISO3.BGR,
                    CountryCodeISO3.GEO,
                    CountryCodeISO3.GRC,
                    CountryCodeISO3.IRN,
                    CountryCodeISO3.IRQ,
                    CountryCodeISO3.SYR
                ],
                Landlocked = false,
                Area = 783562.0
            };
            return country;
        }
    }

    public static Country Taiwan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Taiwan",
                OfficialName = "Republic of China",
                TLD = [".tw", ".台湾", ".台灣"],
                CountryCode = CountryCode.TW,
                ISONumeric = "158",
                ISO3 = CountryCodeISO3.TWN,
                CIOC = "TPE",
                Currencies = ["TWD"],
                CallingCodes = ["886"],
                Capital = "Taipei",
                AlternativeSpellings = ["TW", "Táiwān", "Republic of China", "中華民國", "Zhōnghuá Mínguó", "Chinese Taipei for IOC", "Taiwan, Province of China"],
                Continent = Continent.Asia,
                Region = "Eastern Asia",
                Borders = [],
                Landlocked = false,
                Area = 36193.0
            };
            return country;
        }
    }

    public static Country Uzbekistan
    {
        get
        {
            Country country = new()
            {
                CommonName = "Uzbekistan",
                OfficialName = "Republic of Uzbekistan",
                TLD = [".uz"],
                CountryCode = CountryCode.UZ,
                ISONumeric = "860",
                ISO3 = CountryCodeISO3.UZB,
                CIOC = "UZB",
                Currencies = ["UZS"],
                CallingCodes = ["998"],
                Capital = "Tashkent",
                AlternativeSpellings = ["UZ", "Republic of Uzbekistan", "O'zbekiston Respublikasi", "Ўзбекистон Республикаси"],
                Continent = Continent.Asia,
                Region = "Central Asia",
                Borders =
                [
                    CountryCodeISO3.AFG,
                    CountryCodeISO3.KAZ,
                    CountryCodeISO3.KGZ,
                    CountryCodeISO3.TJK,
                    CountryCodeISO3.TKM
                ],
                Landlocked = true,
                Area = 447400.0
            };
            return country;
        }
    }

    public static Country Vietnam
    {
        get
        {
            Country country = new()
            {
                CommonName = "Vietnam",
                OfficialName = "Socialist Republic of Vietnam",
                TLD = [".vn"],
                CountryCode = CountryCode.VN,
                ISONumeric = "704",
                ISO3 = CountryCodeISO3.VNM,
                CIOC = "VIE",
                Currencies = ["VND"],
                CallingCodes = ["84"],
                Capital = "Hanoi",
                AlternativeSpellings = ["VN", "Socialist Republic of Vietnam", "Cộng hòa Xã hội chủ nghĩa Việt Nam", "Viet Nam"],
                Continent = Continent.Asia,
                Region = "South-Eastern Asia",
                Borders =
                [
                    CountryCodeISO3.KHM,
                    CountryCodeISO3.CHN,
                    CountryCodeISO3.LAO
                ],
                Landlocked = false,
                Area = 331212.0
            };
            return country;
        }
    }

    public static Country Yemen
    {
        get
        {
            Country country = new()
            {
                CommonName = "Yemen",
                OfficialName = "Republic of Yemen",
                TLD = [".ye"],
                CountryCode = CountryCode.YE,
                ISONumeric = "887",
                ISO3 = CountryCodeISO3.YEM,
                CIOC = "YEM",
                Currencies = ["YER"],
                CallingCodes = ["967"],
                Capital = "Sana'a",
                AlternativeSpellings = ["YE", "Yemeni Republic", "al-Jumhūriyyah al-Yamaniyyah"],
                Continent = Continent.Asia,
                Region = "Western Asia",
                Borders =
                [
                    CountryCodeISO3.OMN,
                    CountryCodeISO3.SAU
                ],
                Landlocked = false,
                Area = 527968.0
            };
            return country;
        }
    }
}
