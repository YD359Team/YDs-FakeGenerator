# YDs FakeGenerator

Generate various data with this library!

## Features

- Use `Generator` class for generate multiple data with needed count
- Use `SingleGenerator` class for generate single data
- Work with him via `Instance` property or create new instance manual
- Easy string dataset for generating random names, countries, cities, languages etc.
- Small size, offline work and fully AI free

## Available types

### Boolean

- Boolean (true or false)

###	Numbers

- Integer numbers (int8, uint8, int16, uint16, int32, uint32, int64, uint64)
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

### DateTime

- Date

### Other

- Enum values
- Locations

## Examples

Generating 10 random DateTime between 01.01.1900 and 01.01.2000

```csharp
foreach (DateTime date in Generator.Instance.Date(10, new DateTime(1900, 1, 1), new DateTime(2000, 1, 1))
{
   Console.WriteLine(date);
}
```

Generating 25 random gmail mails:

```csharp
foreach (string mail in Generator.Instance.FillMask(25, "#######@gmail.com", MaskReplacers.AnyAsciiLettersOrDecimalDigit))
{
   Console.WriteLine(mail);
}
```
