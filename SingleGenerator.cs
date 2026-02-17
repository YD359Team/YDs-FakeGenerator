using System.Globalization;
using System.Text;
using YDs_FakeGenerator.Enums;
using YDs_FakeGenerator.Helpers;

namespace YDs_FakeGenerator
{
    /// <summary>
    /// Single data generator
    /// </summary>
    public class SingleGenerator
    {
        private static readonly Lazy<SingleGenerator> _instance = new(() => new());
        /// <summary>
        /// Shared instance of <see cref="SingleGenerator"/>
        /// </summary>
        public static SingleGenerator Instance => _instance.Value;

        private readonly ThreadLocal<Random> _rand;

        public SingleGenerator(int? seed = null)
        {
            _rand = new(() => new());
        }

        #region API
        #region Boolean
        public bool Bool()
        {
            return (_rand.Value.NextSingle() <= 0.5f);
        }
        #endregion

        #region IntegerNumber
        public sbyte Int8()
        {
            byte[] bytes = new byte[1];
            _rand.Value.NextBytes(bytes);
            return unchecked((sbyte)bytes[0]);
        }

        public byte UInt8()
        {
            byte[] bytes = new byte[1];
            _rand.Value.NextBytes(bytes);
            return bytes[0];
        }

        public short Int16()
        {
            byte[] bytes = new byte[2];
            _rand.Value.NextBytes(bytes);
            return BitConverter.ToInt16(bytes, 0);
        }

        public ushort UInt16()
        {
            byte[] bytes = new byte[2];
            _rand.Value.NextBytes(bytes);
            return BitConverter.ToUInt16(bytes, 0);
        }

        public int Int32()
        {
            return _rand.Value.Next();
        }

        public int Int32(int min, int max)
        {
            return _rand.Value.Next(min, max == int.MaxValue ? max : max + 1);
        }

        public uint UInt32()
        {
            return (uint)_rand.Value.NextInt64(0, uint.MaxValue);
        }

        public uint UInt32(uint min, uint max)
        {
            return (uint)_rand.Value.NextInt64(min, max == uint.MaxValue ? max : max + 1);
        }

        public long Int64()
        {
            return _rand.Value.NextInt64();
        }

        public ulong UInt64()
        {
            return unchecked((ulong)_rand.Value.NextInt64());
        }
        #endregion

        #region FloatingNumber
        public float Float32()
        {
            return _rand.Value.NextSingle();
        }

        public double Float64()
        {
            return _rand.Value.NextDouble();
        }
        #endregion

        #region String
        public string Country()
        {
            return StaticDataset.Countries.Value[_rand.Value.Next(StaticDataset.Countries.Value.Length)];
        }

        public string Capital()
        {
            return StaticDataset.Capitals.Value[_rand.Value.Next(StaticDataset.Capitals.Value.Length)];
        }

        public string Language()
        {
            return StaticDataset.Languages.Value[_rand.Value.Next(StaticDataset.Languages.Value.Length)];
        }

        public string Name(Sex sex)
        {
            if (sex == Sex.Male)
            {
                return StaticDataset.FirstNamesMale.Value[_rand.Value.Next(StaticDataset.FirstNamesMale.Value.Length)];
            }
            else if (sex == Sex.Female)
            {
                return StaticDataset.FirstNamesFemale.Value[_rand.Value.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }
            else
            {
                return _rand.Value.NextSingle() <= 0.5f
                    ? StaticDataset.FirstNamesMale.Value[_rand.Value.Next(StaticDataset.FirstNamesMale.Value.Length)]
                    : StaticDataset.FirstNamesFemale.Value[_rand.Value.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }
        }

        public string Person(Sex sex)
        {
            string firstName;
            if (sex == Sex.Male)
            {
                firstName = StaticDataset.FirstNamesMale.Value[_rand.Value.Next(StaticDataset.FirstNamesMale.Value.Length)];
            }
            else if (sex == Sex.Female)
            {
                firstName = StaticDataset.FirstNamesFemale.Value[_rand.Value.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }
            else
            {
                firstName = _rand.Value.NextSingle() <= 0.5f
                    ? StaticDataset.FirstNamesMale.Value[_rand.Value.Next(StaticDataset.FirstNamesMale.Value.Length)]
                    : StaticDataset.FirstNamesFemale.Value[_rand.Value.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }

            return $"{firstName} {StaticDataset.LastNames.Value[_rand.Value.Next(StaticDataset.LastNames.Value.Length)]}";
        }

        public string Animal()
        {
            return StaticDataset.Animals.Value[_rand.Value.Next(StaticDataset.Animals.Value.Length)];
        }

        public string Prices(int max, CultureInfo culture = null)
        {
            culture ??= CultureInfo.InvariantCulture;

            int maxCents = (max + 1) * 100;

            int totalCents = _rand.Value.Next(0, maxCents + 1);
            decimal price = totalCents / 100m;

            return price.ToString("C2", culture);
        }

        public string Lorem(int wordsCount)
        {
            if (wordsCount <= StaticDataset.Lorem.Value.Length)
            {
                return string.Join(' ', StaticDataset.Lorem.Value.Take(wordsCount));
            }

            List<string> words = new(wordsCount);
            for (int i = 0; i < wordsCount; i++)
            {
                words.Add(StaticDataset.Lorem.Value[i % StaticDataset.Lorem.Value.Length]);
            }
            return string.Join(' ', words);
        }
        #endregion

        #region DateTime
        public DateTime Date()
        {
            return DateTime.FromBinary(_rand.Value.NextInt64(DateTime.MinValue.Ticks, DateTime.MaxValue.Ticks));
        }

        public DateTime Date(DateTime min, DateTime max)
        {
            return DateTime.FromBinary(_rand.Value.NextInt64(min.Ticks, max.Ticks));
        }
        #endregion

        #region Enum
        public TEnum EnumValue<TEnum>() where TEnum : struct, Enum
        {
            TEnum[] values = Enum.GetValues<TEnum>();
            return values[_rand.Value.Next(values.Length)];
        }
        #endregion

        #region Other
        public (decimal Lat, decimal Lng) Coordinate()
        {
            const decimal minLat = -90m, maxLat = 90m;
            const decimal minLng = -180m, maxLng = 180m;

            decimal lat = minLat + (decimal)(_rand.Value.NextDouble() * (double)(maxLat - minLat));
            decimal lng = minLng + (decimal)(_rand.Value.NextDouble() * (double)(maxLng - minLng));
            return (Math.Round(lat, 6), Math.Round(lng, 6));
        }
        #endregion

        #region Fill
        public string FillMask(string mask, MaskReplacers maskReplacers, char replacement = '#')
        {
            StringBuilder buffer = new(mask.Length);

            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == replacement)
                {
                    buffer.Append(FillMaskHelper.GetMaskReplacerChar(maskReplacers));
                }
                else
                {
                    buffer.Append(mask[i]);
                }
            }

            return buffer.ToString();
        }
        #endregion
        #endregion
    }
}
