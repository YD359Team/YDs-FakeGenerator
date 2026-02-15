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
        /// <summary>
        /// Shared instance of <see cref="SingleGenerator"/>
        /// </summary>
        public static SingleGenerator Instance => field ??= new();

        private readonly Random _rand = new();

        #region API
        #region Boolean
        public bool Bool()
        {
            return (_rand.NextSingle() <= 0.5f);
        }
        #endregion

        #region IntegerNumber
        public sbyte I8()
        {
            byte[] bytes = new byte[1];
            _rand.NextBytes(bytes);
            return unchecked((sbyte)bytes[0]);
        }

        public byte U8()
        {
            byte[] bytes = new byte[1];
            _rand.NextBytes(bytes);
            return bytes[0];
        }

        public int I32()
        {
            return _rand.Next();
        }

        public int I32(int min, int max)
        {
            return _rand.Next(min, max + 1);
        }

        public uint U32()
        {
            return (uint)_rand.NextInt64(0, uint.MaxValue);
        }

        public uint U32(uint min, uint max)
        {
            return (uint)_rand.NextInt64(min, max + 1);
        }
        #endregion

        #region FloatingNumber
        public float F32()
        {
            return _rand.NextSingle();
        }

        public double F64()
        {
            return _rand.NextDouble();
        }
        #endregion

        #region String
        public string Country()
        {
            return StaticDataset.Countries.Value[_rand.Next(StaticDataset.Countries.Value.Length)];
        }

        public string Capital()
        {
            return StaticDataset.Capitals.Value[_rand.Next(StaticDataset.Capitals.Value.Length)];
        }

        public string Language()
        {
            return StaticDataset.Languages.Value[_rand.Next(StaticDataset.Languages.Value.Length)];
        }

        public string Name(Sex sex)
        {
            if (sex == Sex.Male)
            {
                return StaticDataset.FirstNamesMale.Value[_rand.Next(StaticDataset.FirstNamesMale.Value.Length)];
            }
            else if (sex == Sex.Female)
            {
                return StaticDataset.FirstNamesFemale.Value[_rand.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }
            else
            {
                return _rand.NextSingle() <= 0.5f
                    ? StaticDataset.FirstNamesMale.Value[_rand.Next(StaticDataset.FirstNamesMale.Value.Length)]
                    : StaticDataset.FirstNamesFemale.Value[_rand.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }
        }

        public string Person(Sex sex)
        {
            string firstName;
            if (sex == Sex.Male)
            {
                firstName = StaticDataset.FirstNamesMale.Value[_rand.Next(StaticDataset.FirstNamesMale.Value.Length)];
            }
            else if (sex == Sex.Female)
            {
                firstName = StaticDataset.FirstNamesFemale.Value[_rand.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }
            else
            {
                firstName = _rand.NextSingle() <= 0.5f
                    ? StaticDataset.FirstNamesMale.Value[_rand.Next(StaticDataset.FirstNamesMale.Value.Length)]
                    : StaticDataset.FirstNamesFemale.Value[_rand.Next(StaticDataset.FirstNamesFemale.Value.Length)];
            }

            return $"{firstName} {StaticDataset.LastNames.Value[_rand.Next(StaticDataset.LastNames.Value.Length)]}";
        }

        public string Prices(int max, CultureInfo culture = null)
        {
            culture ??= CultureInfo.InvariantCulture;

            int maxCents = (max + 1) * 100;

            int totalCents = _rand.Next(0, maxCents + 1);
            decimal price = totalCents / 100m;

            return price.ToString("C2", culture);
        }
        #endregion

        #region Enum
        public TEnum EnumValue<TEnum>() where TEnum : struct, Enum
        {
            TEnum[] values = Enum.GetValues<TEnum>();
            return values[_rand.Next(values.Length)];
        }
        #endregion

        #region Other
        public (decimal Lat, decimal Lng) Coordinate()
        {
            const decimal minLat = -90m, maxLat = 90m;
            const decimal minLng = -180m, maxLng = 180m;

            decimal lat = minLat + (decimal)(_rand.NextDouble() * (double)(maxLat - minLat));
            decimal lng = minLng + (decimal)(_rand.NextDouble() * (double)(maxLng - minLng));
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
