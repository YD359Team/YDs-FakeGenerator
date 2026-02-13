using System.Globalization;

namespace YDs_FakeGenerator
{
    public class Generator
    {
        // Singleton
        public static Generator Instance => field ??= new();

        private readonly Random _rand = new();

        #region StaticData
        private readonly Lazy<string[]> _firstNamesMale = new(() => [
            "Abraham", "Abram", "Alex", "Aaron", "Antony", "Andy",
            "Brandon",
            "Charles", "Christopher",
            "Frank",
            "George",
            "Harry",
            "Ian",
            "Jacob", "John", "Joshua", "James", "Jack", "Justin",
            "Kail",
            "Michael",
            "Piter",
            "Stan",
            "Tom", "Tyler",
            "Quentin",
            "Zak", "Zein"
        ]);

        private readonly Lazy<string[]> _firstNamesFemale = new(() => [
            "Alisa", "Alice", "Amanda", "Amber", "Ashley",
            "Brittany",
            "Caroline", "Courtney",
            "Danielle",
            "Emily",
            "Jane", "Jacklin", "Jessica",
            "Kate", "Kayla",
            "Lisa",
            "Mary", "Maria", "Marina", "Mariah", "Misha", "Megan",
            "Nina",
            "Rachel",
            "Sasha", "Sandra", "Sarah", "Samantha",
            "Taylor",
            "Victoria", "Vivien"
        ]);

        private readonly Lazy<string[]> _lastNames = new(() => [
            "Anderson", "Aniston",
            "Biden", "Black", "Brown",
            "Colt", "Crowley",
            "Davis", "Doe", "Dimmer",
            "Garcia",
            "Harris",
            "Jackson", "Johnson", "Jones",
            "Goldberg", "Grey", "Green",
            "Little", "Lincoln",
            "Martin", "Martinez", "Miller", "Moore",
            "Obaba",
            "Parker",
            "Richardson", "Rickson",
            "Skott", "Smith",
            "Taylor", "Trump", "Thompson", "Thomas",
            "Washington", "Wilson", "Williams", "White"
        ]);

        private readonly Lazy<string[]> _countries = new(() => [
            "United States", "Canada", "Mexico", "Brazil", "Argentina", 
            "Colombia", "Chile", "Peru", "Venezuela", "Ecuador", "Bolivia", 
            "Paraguay", "Uruguay", "Guyana", "Suriname", "French Guiana", 
            "United Kingdom", "France", "Germany", "Italy", "Spain", 
            "Portugal", "Netherlands", "Belgium", "Luxembourg", "Switzerland", 
            "Austria", "Ireland", "Poland", "Czech Republic", "Slovakia", 
            "Hungary", "Romania", "Bulgaria", "Greece", "Sweden", "Norway", 
            "Denmark", "Finland", "Iceland", "Estonia", "Latvia", "Lithuania", 
            "Ukraine", "Belarus", "Moldova", "Russia", "Turkey", "Georgia", 
            "Armenia", "Azerbaijan", "Kazakhstan", "Uzbekistan", "Turkmenistan", 
            "Kyrgyzstan", "Tajikistan", "China", "India", "Pakistan", "Bangladesh", 
            "Afghanistan", "Iran", "Iraq", "Saudi Arabia", "United Arab Emirates", 
            "Qatar", "Kuwait", "Bahrain", "Oman", "Yemen", "Israel", "Jordan", 
            "Lebanon", "Syria", "Egypt", "Sudan", "South Sudan", "Libya", "Tunisia", 
            "Algeria", "Morocco", "Western Sahara", "Mauritania", "Senegal", "Gambia", 
            "Mali", "Burkina Faso", "Niger", "Nigeria", "Benin", "Togo", "Ghana", 
            "Ivory Coast", "Liberia", "Sierra Leone", "Guinea", "Guinea-Bissau", 
            "Cape Verde", "Chad", "Central African Republic", "Cameroon", 
            "Equatorial Guinea", "Gabon", "Republic of the Congo", 
            "Democratic Republic of the Congo", "Uganda", "Kenya", "Tanzania", "Rwanda", 
            "Burundi", "Somalia", "Ethiopia", "Eritrea", "Djibouti", "South Africa", 
            "Namibia", "Botswana", "Zimbabwe", "Zambia", "Malawi", "Mozambique", 
            "Madagascar", "Mauritius", "Seychelles", "Comoros", "Australia", 
            "New Zealand", "Papua New Guinea", "Indonesia", "Malaysia", "Singapore", 
            "Thailand", "Vietnam", "Cambodia", "Laos", "Myanmar", "Philippines", "Japan", 
            "South Korea", "North Korea", "Mongolia", "Bhutan", "Nepal", "Sri Lanka", 
            "Maldives", "Fiji", "Vanuatu", "Solomon Islands", "Samoa", "Tonga", "Kiribati", 
            "Micronesia", "Palau", "Marshall Islands", "Nauru", "Tuvalu", "Vatican City", 
            "Monaco", "San Marino", "Liechtenstein", "Andorra", "Malta", "Cyprus", "Albania", 
            "North Macedonia", "Serbia", "Croatia", "Slovenia", "Bosnia and Herzegovina", 
            "Montenegro", "Kosovo"
        ]);

        private readonly Lazy<string[]> _capitals = new(() => [
           "Washington, D.C.", "Ottawa", "Mexico City", "Brasília", "Buenos Aires", "Bogotá", 
            "Santiago", "Lima", "Caracas", "Quito", "Sucre", "Asunción", "Montevideo", 
            "Georgetown", "Paramaribo", "Cayenne", "London", "Paris", "Berlin", "Rome", 
            "Madrid", "Lisbon", "Amsterdam", "Brussels", "Luxembourg City", "Bern", "Vienna", 
            "Dublin", "Warsaw", "Prague", "Bratislava", "Budapest", "Bucharest", "Sofia", 
            "Athens", "Stockholm", "Oslo", "Copenhagen", "Helsinki", "Reykjavik", "Tallinn", 
            "Riga", "Vilnius", "Kyiv", "Minsk", "Chișinău", "Moscow", "Ankara", "Tbilisi", 
            "Yerevan", "Baku", "Nur-Sultan", "Tashkent", "Ashgabat", "Bishkek", "Dushanbe", 
            "Beijing", "New Delhi", "Islamabad", "Dhaka", "Kabul", "Tehran", "Baghdad", 
            "Riyadh", "Abu Dhabi", "Doha", "Kuwait City", "Manama", "Muscat", "Sana'a", 
            "Jerusalem", "Amman", "Beirut", "Damascus", "Cairo", "Khartoum", "Juba", "Tripoli", 
            "Tunis", "Algiers", "Rabat", "El Aaiún", "Nouakchott", "Dakar", "Banjul", "Bamako", 
            "Ouagadougou", "Niamey", "Abuja", "Porto-Novo", "Lomé", "Accra", "Yamoussoukro", 
            "Monrovia", "Freetown", "Conakry", "Bissau", "Praia", "N'Djamena", "Bangui", 
            "Yaoundé", "Malabo", "Libreville", "Brazzaville", "Kinshasa", "Kampala", "Nairobi", 
            "Dodoma", "Kigali", "Gitega", "Mogadishu", "Addis Ababa", "Asmara", "Djibouti", 
            "Pretoria", "Windhoek", "Gaborone", "Harare", "Lusaka", "Lilongwe", "Maputo", 
            "Antananarivo", "Port Louis", "Victoria", "Moroni", "Canberra", "Wellington", 
            "Port Moresby", "Jakarta", "Kuala Lumpur", "Singapore", "Bangkok", "Hanoi", 
            "Phnom Penh", "Vientiane", "Naypyidaw", "Manila", "Tokyo", "Seoul", "Pyongyang", 
            "Ulaanbaatar", "Thimphu", "Kathmandu", "Sri Jayawardenepura Kotte", "Malé", "Suva", 
            "Port Vila", "Honiara", "Apia", "Nukuʻalofa", "South Tarawa", "Palikir", "Ngerulmud", 
            "Majuro", "Yaren District", "Funafuti", "Vatican City", "Monaco", "San Marino", "Vaduz", 
            "Andorra la Vella", "Valletta", "Nicosia", "Tirana", "Skopje", "Belgrade", "Zagreb", 
            "Ljubljana", "Sarajevo", "Podgorica", "Pristina"
        ]);

        private readonly Lazy<string[]> _languages = new(() => [
          "English", "Spanish", "French", "German", "Italian", "Portuguese", "Russian", 
            "Mandarin Chinese", "Cantonese", "Japanese", "Korean", "Arabic", "Hindi", "Bengali", 
            "Punjabi", "Urdu", "Tamil", "Telugu", "Marathi", "Gujarati", "Kannada", "Malayalam", 
            "Sanskrit", "Persian (Farsi)", "Turkish", "Vietnamese", "Thai", "Indonesian", "Malay", 
            "Filipino (Tagalog)", "Javanese", "Sundanese", "Dutch", "Swedish", "Norwegian", "Danish", 
            "Finnish", "Icelandic", "Polish", "Czech", "Slovak", "Hungarian", "Romanian", "Bulgarian", 
            "Serbian", "Croatian", "Slovenian", "Bosnian", "Macedonian", "Albanian", "Greek", "Ukrainian", 
            "Belarusian", "Latvian", "Lithuanian", "Estonian", "Georgian", "Armenian", "Azerbaijani", 
            "Kazakh", "Uzbek", "Turkmen", "Kyrgyz", "Tajik", "Mongolian", "Tibetan", "Burmese", "Khmer", 
            "Lao", "Hebrew", "Yiddish", "Amharic", "Oromo", "Somali", "Swahili", "Zulu", "Xhosa", 
            "Afrikaans", "Hausa", "Yoruba", "Igbo", "Fula", "Malagasy", "Maori", "Hawaiian", "Navajo", 
            "Quechua", "Guarani", "Aymara", "Nahuatl", "Esperanto", "Latin", "Welsh", "Irish Gaelic", 
            "Scottish Gaelic", "Basque", "Catalan", "Galician", "Breton", "Corsican", "Sardinian", "Frisian", 
            "Luxembourgish", "Maltese", "Icelandic", "Faroese", "Greenlandic", "Inuktitut", "Cree", "Ojibwe", 
            "Cherokee", "Sinhala", "Nepali", "Bhutanese (Dzongkha)", "Pashto", "Kurdish", "Sindhi", "Balochi", 
            "Assamese", "Odia (Oriya)", "Bhojpuri", "Maithili", "Sinhalese", "Dhivehi", "Tigrinya", "Kinyarwanda", 
            "Lingala", "Kongo", "Shona", "Sesotho", "Setswana", "Swati", "Tsonga", "Venda", "Chichewa", "Kikuyu", 
            "Luo", "Gikuyu", "Akan", "Ewe", "Fon", "Mossi", "Bambara", "Soninke", "Wolof", "Serer", "Malinke", 
            "Susu", "Kpelle", "Mandinka", "Jola", "Temne", "Limba", "Mende", "Kru", "Grebo", "Krahn", "Mano", 
            "Dan", "Guro", "Senufo", "Lobi", "Dagara", "Bissa", "Dyula", "Samoan", "Tongan", "Tahitian", "Rapa Nui", 
            "Haitian Creole", "Louisiana Creole", "Jamaican Patois", "Seychellois Creole", "Mauritian Creole", 
            "Papiamento", "Sranan Tongo", "Tok Pisin", "Bislama", "Solomon Islands Pijin", "Rotuman", "Niuean", 
            "Tokelauan", "Tuvaluan", "Marshallese", "Chamorro", "Palauan", "Chuukese", "Pohnpeian", "Yapese", 
            "Kosraean", "Nauruan", "Gilbertese", "Māori", "Hawaiian", "Rapa Nui", "Tahitian", "Samoan", "Tongan", 
            "Fijian", "Rotuman", "Niuean", "Tokelauan", "Tuvaluan", "Kiribati", "Nauruan", "Palauan", "Chamorro", 
            "Marshallese", "Chuukese", "Pohnpeian", "Yapese", "Kosraean", "Bislama", "Tok Pisin", 
            "Solomon Islands Pijin"
        ]);
        #endregion

        #region API
        #region Boolean
        public IEnumerable<bool> GetRandomBoolean(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (_rand.NextSingle() <= 0.5f);
            }
        }
        #endregion

        #region IntegerNumber
        public IEnumerable<sbyte> GetRandomI8(int count)
        {
            byte[] bytes = new byte[count];
            _rand.NextBytes(bytes);
            return Array.ConvertAll(bytes, (b) => unchecked((sbyte)b));
        }

        public IEnumerable<byte> GetRandomU8(int count)
        {
            byte[] bytes = new byte[count];
            _rand.NextBytes(bytes);
            return bytes;
        }

        public IEnumerable<int> GetRandomI32(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.Next();
            }
        }

        public IEnumerable<int> GetRandomI32(int count, int min, int max)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.Next(min, max + 1);
            }
        }

        public IEnumerable<uint> GetRandomU32(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (uint)_rand.NextInt64(0, uint.MaxValue);
            }
        }

        public IEnumerable<uint> GetRandomU32(int count, uint min, uint max)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (uint)_rand.NextInt64(min, max + 1);
            }
        }
        #endregion

        #region FloatingNumber
        public IEnumerable<float> GetRandomF32(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.NextSingle();
            }
        }

        public IEnumerable<double> GetRandomF64(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.NextDouble();
            }
        }
        #endregion

        #region String
        public IEnumerable<string> GetRandomCountries(int count, bool canRepeat = false)
        {
            if (canRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return _countries.Value[_rand.Next(_countries.Value.Length)];
                }
            }
            else
            {
                string[] countries = new string[_countries.Value.Length];
                Array.Copy(_countries.Value, countries, _countries.Value.Length);
                _rand.Shuffle(countries);

                for (int i = 0; i < count; i++)
                {
                    yield return countries[i];
                }
            }
        }

        public IEnumerable<string> GetRandomCapitals(int count, bool canRepeat = false)
        {
            if (canRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return _capitals.Value[_rand.Next(_capitals.Value.Length)];
                }
            }
            else
            {
                string[] capitals = new string[_capitals.Value.Length];
                Array.Copy(_capitals.Value, capitals, _capitals.Value.Length);
                _rand.Shuffle(capitals);

                for (int i = 0; i < count; i++)
                {
                    yield return capitals[i];
                }
            }
        }

        public IEnumerable<string> GetRandomLanguages(int count, bool canRepeat = false)
        {
            if (canRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return _languages.Value[_rand.Next(_languages.Value.Length)];
                }
            }
            else
            {
                string[] languages = new string[_languages.Value.Length];
                Array.Copy(_languages.Value, languages, _languages.Value.Length);
                _rand.Shuffle(languages);

                for (int i = 0; i < count; i++)
                {
                    yield return languages[i];
                }
            }
        }

        public IEnumerable<string> GetRandomPersons(int count, Sex sex)
        {
            string[] firstNames;
            if (sex == Sex.Male)
            {
                firstNames = new string[_firstNamesMale.Value.Length];
                Array.Copy(_firstNamesMale.Value, firstNames, _firstNamesMale.Value.Length);
                _rand.Shuffle(firstNames);
            }
            else if (sex == Sex.Female)
            {
                firstNames = new string[_firstNamesFemale.Value.Length];
                Array.Copy(_firstNamesFemale.Value, firstNames, _firstNamesFemale.Value.Length);
                _rand.Shuffle(firstNames);
            }
            else
            {
                firstNames = new string[_firstNamesMale.Value.Length + _firstNamesFemale.Value.Length];
                Array.Copy(_firstNamesMale.Value, firstNames, _firstNamesMale.Value.Length);
                Array.Copy(_firstNamesFemale.Value, 0, firstNames, _firstNamesMale.Value.Length, _firstNamesFemale.Value.Length);
                _rand.Shuffle(firstNames);
            }

            for (int i = 0; i < count; i++)
            {
                yield return $"{firstNames[_rand.Next(firstNames.Length)]} {_lastNames.Value[_rand.Next(_lastNames.Value.Length)]}";
            }
        }

        public IEnumerable<string> GetRandomPrices(int count, int max, CultureInfo culture = null)
        {
            culture ??= CultureInfo.InvariantCulture;

            int maxCents = (max + 1) * 100;

            for (int i = 0; i < count; i++)
            {
                int totalCents = _rand.Next(0, maxCents + 1); 
                decimal price = totalCents / 100m;

                yield return price.ToString("C2", culture);
            }
        }
        #endregion

        #region Enum
        public IEnumerable<TEnum> GetRandomEnumValues<TEnum>(int count) where TEnum : struct, Enum
        {
            TEnum[] values = Enum.GetValues<TEnum>();
            for (int i = 0; i < count; i++)
            {
                yield return values[_rand.Next(values.Length)];
            }
        }
        #endregion

        #region Other
        public IEnumerable<(decimal Lat, decimal Lng)> GetRandomCoordinates(int count)
        {
            const decimal minLat = -90m, maxLat = 90m;
            const decimal minLng = -180m, maxLng = 180m;

            for (int i = 0; i < count; i++)
            {
                decimal lat = minLat + (decimal)(_rand.NextDouble() * (double)(maxLat - minLat));
                decimal lng = minLng + (decimal)(_rand.NextDouble() * (double)(maxLng - minLng));
                yield return (Math.Round(lat, 6), Math.Round(lng, 6));
            }
        }
        #endregion
        #endregion
    }
}
