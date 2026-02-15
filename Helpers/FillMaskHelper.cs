using System;
using System.Collections.Generic;
using System.Text;
using YDs_FakeGenerator.Enums;

namespace YDs_FakeGenerator.Helpers
{
    internal static class FillMaskHelper
    {
        public static char GetMaskReplacerChar(MaskReplacers maskReplacers)
        {
            return maskReplacers switch
            {
                MaskReplacers.BinaryDigits => Random.Shared.NextSingle() <= 0.5 ? '1' : '0',
                MaskReplacers.DecimalDigits => (char)Random.Shared.Next('0', '9' + 1),
                MaskReplacers.OctDigits => (char)Random.Shared.Next('0', '8'),
                MaskReplacers.HexDigits => Random.Shared.Next(0, 16).ToString("16")[0],
                MaskReplacers.LowerAsciiLetters => (char)Random.Shared.Next('a', 'z' + 1),
                MaskReplacers.UpperAsciiLetters => (char)Random.Shared.Next('Z', 'Z' + 1),
                MaskReplacers.AsciiMathOperators => StaticDataset.MathOperators[Random.Shared.Next(StaticDataset.MathOperators.Length)],
                MaskReplacers.AsciiPunctuations => StaticDataset.Punctuations[Random.Shared.Next(StaticDataset.Punctuations.Length)],
                MaskReplacers.AnyAsciiLetters => StaticDataset.AsciiLetters[Random.Shared.Next(StaticDataset.AsciiLetters.Length)],
                MaskReplacers.AnyAsciiLettersOrDecimalDigit => Random.Shared.Next(1, 3) == 1 
                                                                ? StaticDataset.AsciiLetters[Random.Shared.Next(StaticDataset.AsciiLetters.Length)]
                                                                : (char)Random.Shared.Next('0', '9' + 1),
                MaskReplacers.Any => (char)Random.Shared.Next(33, 127), // not empty ASCII range
                _ => throw new NotImplementedException()
            };
        }
    }
}
