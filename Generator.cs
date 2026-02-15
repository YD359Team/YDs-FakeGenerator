using System.Globalization;
using System.Text;
using YDs_FakeGenerator.Enums;
using YDs_FakeGenerator.Helpers;

namespace YDs_FakeGenerator
{
    /// <summary>
    /// Multiple data generator
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Shared instance of <see cref="Generator"/>
        /// </summary>
        public static Generator Instance => field ??= new();

        private readonly Random _rand = new();

        #region API
        #region Boolean
        public IEnumerable<bool> Bool(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (_rand.NextSingle() <= 0.5f);
            }
        }
        #endregion

        #region IntegerNumber
        public IEnumerable<sbyte> Int8(int count)
        {
            byte[] bytes = new byte[count];
            _rand.NextBytes(bytes);
            return Array.ConvertAll(bytes, (b) => unchecked((sbyte)b));
        }

        public IEnumerable<byte> UInt8(int count)
        {
            byte[] bytes = new byte[count];
            _rand.NextBytes(bytes);
            return bytes;
        }

        public IEnumerable<short> Int16(int count)
        {
            byte[] bytes = new byte[2 * count];
            _rand.NextBytes(bytes);
            for (int i = 0; (i < (2 * count)); i+= 2)
            {
                yield return BitConverter.ToInt16(bytes, i);
            }
        }

        public IEnumerable<ushort> UInt16(int count)
        {
            byte[] bytes = new byte[2 * count];
            _rand.NextBytes(bytes);
            for (int i = 0; (i < (2 * count)); i += 2)
            {
                yield return BitConverter.ToUInt16(bytes, i);
            }
        }

        public IEnumerable<int> Int32(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.Next();
            }
        }

        public IEnumerable<int> Int32(int count, int min, int max)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.Next(min, max + 1);
            }
        }

        public IEnumerable<uint> UInt32(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (uint)_rand.NextInt64(0, uint.MaxValue);
            }
        }

        public IEnumerable<uint> UInt32(int count, uint min, uint max)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (uint)_rand.NextInt64(min, max + 1);
            }
        }
        #endregion

        #region FloatingNumber
        public IEnumerable<float> Float32(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.NextSingle();
            }
        }

        public IEnumerable<double> Float64(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return _rand.NextDouble();
            }
        }
        #endregion

        #region String
        public IEnumerable<string> Countries(int count, bool canRepeat = false)
        {
            if (canRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return StaticDataset.Countries.Value[_rand.Next(StaticDataset.Countries.Value.Length)];
                }
            }
            else
            {
                string[] countries = new string[StaticDataset.Countries.Value.Length];
                Array.Copy(StaticDataset.Countries.Value, countries, StaticDataset.Countries.Value.Length);
                _rand.Shuffle(countries);

                for (int i = 0; i < count; i++)
                {
                    yield return countries[i];
                }
            }
        }

        public IEnumerable<string> Capitals(int count, bool canRepeat = false)
        {
            if (canRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return StaticDataset.Capitals.Value[_rand.Next(StaticDataset.Capitals.Value.Length)];
                }
            }
            else
            {
                string[] capitals = new string[StaticDataset.Capitals.Value.Length];
                Array.Copy(StaticDataset.Capitals.Value, capitals, StaticDataset.Capitals.Value.Length);
                _rand.Shuffle(capitals);

                for (int i = 0; i < count; i++)
                {
                    yield return capitals[i];
                }
            }
        }

        public IEnumerable<string> Languages(int count, bool canRepeat = false)
        {
            if (canRepeat)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return StaticDataset.Languages.Value[_rand.Next(StaticDataset.Languages.Value.Length)];
                }
            }
            else
            {
                string[] languages = new string[StaticDataset.Languages.Value.Length];
                Array.Copy(StaticDataset.Languages.Value, languages, StaticDataset.Languages.Value.Length);
                _rand.Shuffle(languages);

                for (int i = 0; i < count; i++)
                {
                    yield return languages[i];
                }
            }
        }

        public IEnumerable<string> Names(int count, Sex sex)
        {
            string[] firstNames;
            if (sex == Sex.Male)
            {
                firstNames = new string[StaticDataset.FirstNamesMale.Value.Length];
                Array.Copy(StaticDataset.FirstNamesMale.Value, firstNames, StaticDataset.FirstNamesMale.Value.Length);
                _rand.Shuffle(firstNames);
            }
            else if (sex == Sex.Female)
            {
                firstNames = new string[StaticDataset.FirstNamesFemale.Value.Length];
                Array.Copy(StaticDataset.FirstNamesFemale.Value, firstNames, StaticDataset.FirstNamesFemale.Value.Length);
                _rand.Shuffle(firstNames);
            }
            else
            {
                firstNames = new string[StaticDataset.FirstNamesMale.Value.Length + StaticDataset.FirstNamesFemale.Value.Length];
                Array.Copy(StaticDataset.FirstNamesMale.Value, firstNames, StaticDataset.FirstNamesMale.Value.Length);
                Array.Copy(StaticDataset.FirstNamesFemale.Value, 0, firstNames, StaticDataset.FirstNamesMale.Value.Length, StaticDataset.FirstNamesFemale.Value.Length);
                _rand.Shuffle(firstNames);
            }

            for (int i = 0; i < count; i++)
            {
                yield return firstNames[_rand.Next(firstNames.Length)];
            }
        }

        public IEnumerable<string> Persons(int count, Sex sex)
        {
            string[] firstNames;
            if (sex == Sex.Male)
            {
                firstNames = new string[StaticDataset.FirstNamesMale.Value.Length];
                Array.Copy(StaticDataset.FirstNamesMale.Value, firstNames, StaticDataset.FirstNamesMale.Value.Length);
                _rand.Shuffle(firstNames);
            }
            else if (sex == Sex.Female)
            {
                firstNames = new string[StaticDataset.FirstNamesFemale.Value.Length];
                Array.Copy(StaticDataset.FirstNamesFemale.Value, firstNames, StaticDataset.FirstNamesFemale.Value.Length);
                _rand.Shuffle(firstNames);
            }
            else
            {
                firstNames = new string[StaticDataset.FirstNamesMale.Value.Length + StaticDataset.FirstNamesFemale.Value.Length];
                Array.Copy(StaticDataset.FirstNamesMale.Value, firstNames, StaticDataset.FirstNamesMale.Value.Length);
                Array.Copy(StaticDataset.FirstNamesFemale.Value, 0, firstNames, StaticDataset.FirstNamesMale.Value.Length, StaticDataset.FirstNamesFemale.Value.Length);
                _rand.Shuffle(firstNames);
            }

            for (int i = 0; i < count; i++)
            {
                yield return $"{firstNames[_rand.Next(firstNames.Length)]} {StaticDataset.LastNames.Value[_rand.Next(StaticDataset.LastNames.Value.Length)]}";
            }
        }

        public IEnumerable<string> Prices(int count, int max, CultureInfo culture = null)
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
        public IEnumerable<TEnum> EnumValues<TEnum>(int count) where TEnum : struct, Enum
        {
            TEnum[] values = Enum.GetValues<TEnum>();
            for (int i = 0; i < count; i++)
            {
                yield return values[_rand.Next(values.Length)];
            }
        }
        #endregion

        #region Other
        public IEnumerable<(decimal Lat, decimal Lng)> Coordinates(int count)
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

        #region Fill
        public IEnumerable<string> FillMask(int count, string mask, MaskReplacers maskReplacers, char replacement = '#')
        {
            for (int i = 0; i < count; i++)
            {
                StringBuilder buffer = new(mask.Length);

                for (int j = 0; j < mask.Length; j++)
                {
                    if (mask[j] == replacement)
                    {
                        buffer.Append(FillMaskHelper.GetMaskReplacerChar(maskReplacers));
                    }
                    else
                    {
                        buffer.Append(mask[j]);
                    }
                }

                yield return buffer.ToString();
            }
        }
        #endregion
        #endregion
    }
}
