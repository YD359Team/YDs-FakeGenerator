namespace YDs_FakeGenerator.Enums
{
    public enum MaskReplacers : byte
    {
        BinaryDigits = 0,
        DecimalDigits,
        OctDigits,
        HexDigits,
        LowerAsciiLetters,
        UpperAsciiLetters,
        AsciiMathOperators,
        AsciiPunctuations,
        AnyAsciiLetters,
        AnyAsciiLettersOrDecimalDigit,
        Any = 0xFF
    }
}
