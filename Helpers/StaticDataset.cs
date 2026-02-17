using System;
using System.Collections.Generic;
using System.Text;

namespace YDs_FakeGenerator.Helpers
{
    internal static class StaticDataset
    {
        public static readonly char[] MathOperators = ['+', '-', '*', '/', '=', '%'];

        public static readonly char[] Punctuations = ['.', ',', '!', '?', ';', ':'];

        public static readonly char[] AsciiLetters = [
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a',
            'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
            't', 'u', 'v', 'w', 'x', 'y', 'z'];

        public static readonly Lazy<string[]> FirstNamesMale = new(() => [
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
            "Peter",
            "Stan",
            "Tom", "Tyler",
            "Quentin",
            "Zak", "Zein"
        ]);

        public static readonly Lazy<string[]> FirstNamesFemale = new(() => [
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

        public static readonly Lazy<string[]> LastNames = new(() => [
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

        public static readonly Lazy<string[]> Countries = new(() => [
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

        public static readonly Lazy<string[]> Capitals = new(() => [
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

        public static readonly Lazy<string[]> Languages = new(() => [
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

        public static readonly Lazy<string[]> Animals = new(() => [
            "Dog", "Cat", "Horse", "Cow", "Sheep", "Goat", "Pig", "Chicken", "Duck", "Goose", "Rabbit", "Hamster", 
            "Guinea Pig", "Mouse", "Rat", "Ferret", "Parrot", "Canary", "Goldfish", "Budgerigar", "Lion", "Tiger", 
            "Leopard", "Cheetah", "Jaguar", "Panther", "Bear", "Wolf", "Fox", "Coyote", "Hyena", "Elephant", "Rhino", 
            "Hippopotamus", "Giraffe", "Zebra", "Kangaroo", "Koala", "Wombat", "Platypus", "Echidna", "Panda", "Red Panda", 
            "Monkey", "Gorilla", "Chimpanzee", "Orangutan", "Gibbon", "Lemur", "Sloth", "Armadillo", "Anteater", "Ocelot", 
            "Lynx", "Bobcat", "Puma", "Cougar", "Moose", "Deer", "Elk", "Reindeer", "Caribou", "Bison", "Buffalo", "Antelope", 
            "Gazelle", "Impala", "Wildebeest", "Zebra", "Okapi", "Camel", "Dromedary", "Llama", "Alpaca", "Vicuña", "Guanaco",
            "Hedgehog", "Porcupine", "Squirrel", "Chipmunk", "Beaver", "Otter", "Badger", "Weasel", "Marten", "Mink", "Skunk", 
            "Raccoon", "Coati", "Meerkat", "Mongoose", "Bat", "Whale", "Dolphin", "Porpoise", "Shark", "Ray", "Stingray",
            "Octopus", "Squid", "Cuttlefish", "Seal", "Sea Lion", "Walrus", "Polar Bear", "Penguin", "Ostrich", "Emu", "Cassowary",
            "Kiwi", "Flamingo", "Peacock", "Eagle", "Hawk", "Falcon", "Owl", "Vulture", "Condor", "Toucan", "Parrot", "Macaw", 
            "Cockatoo", "Iguana", "Chameleon", "Gecko", "Komodo Dragon", "Crocodile", "Alligator", "Caiman", "Gharial", "Turtle", 
            "Tortoise", "Snake", "Python", "Boa", "Anaconda", "Rattlesnake", "Cobra", "Viper", "Frog", "Toad", "Salamander", "Newt", 
            "Axolotl", "Butterfly", "Moth", "Bee", "Wasp", "Ant", "Ladybug", "Dragonfly", "Grasshopper", "Cricket", "Cockroach", 
            "Scorpion", "Spider", "Tarantula", "Crab", "Lobster", "Shrimp", "Starfish", "Jellyfish", "Sea Urchin", "Sea Cucumber", 
            "Clam", "Oyster", "Snail", "Slug"
        ]);

        public static readonly Lazy<string[]> Lorem = new(() => [
            "Lorem", "ipsum", "dolor", "sit", "amet,", "consectetur", "adipiscing", "elit,", "sed", "do", "eiusmod", "tempor", "incididunt", "ut",
            "labore", "et", "dolore", "magna", "aliqua.", "Ut", "enim", "ad", "minim", "veniam,", "quis", "nostrud", "exercitation", "ullamco",
            "laboris", "nisi", "ut", "aliquip", "ex", "ea", "commodo", "consequat.", "Duis", "aute", "irure", "dolor", "in", "reprehenderit", "in",
            "voluptate", "velit", "esse", "cillum", "dolore", "eu", "fugiat", "nulla", "pariatur.", "Excepteur", "sint", "occaecat", "cupidatat",
            "non", "proident,", "sunt", "in", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id", "est", "laborum."
        ]);
    }
}
