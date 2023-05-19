Enum one = EnumType.One;
Console.WriteLine(one);

EnumType digit = EnumType.Zero;
Enum zero = digit;
Console.WriteLine(zero);

Console.WriteLine(new string('-', 10));

for (EnumType number = EnumType.Zero; number <= EnumType.Three; number++)
{
    Console.WriteLine(number);
}

// Bütün enum tiplər Enum klasıdan miras alır.
enum EnumType : byte
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}