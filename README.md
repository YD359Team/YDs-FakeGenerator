# YDs FakeGenerator

Generate various data with this library!

## Features

- Use `Generator` class for generate multiple data with needed count
- Use `SingleGenerator` class for generate single data
- Work with him via `Instance` property or create new instance manual
- Easy string dataset for generating random names, countries, cities and languages.
- Small size, offline work and fully AI free

## Available types

### Boolean

- Boolean (true or false)

###	Numbers

- Integer numbers (int8, uint8, int16, uint16, int32, uint32)
- Floating numbers (float32, float64)

### String

- FillMask (use any format like `+#(###)###-##-##` for phone number)
- Countries
- Capitals
- Languages
- Names (male, female, all)
- Persons (male, female, all)
- Animals
- Prices (use any `CultureInfo`)

### Other

- Enum values
- Locations

## Examples

Generating 25 random gmail mails:

```csharp
foreach (string mail in Generator.Instance.FillMask(25, "#######@gmail.com", MaskReplacers.AnyAsciiLettersOrDecimalDigit))
{
   Console.WriteLine(mail);
}
```
