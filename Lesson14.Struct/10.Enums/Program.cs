Console.WriteLine(EnumType.One);
Console.WriteLine((byte)EnumType.One);

EnumType digit = EnumType.Zero;
Console.WriteLine(digit);
Console.WriteLine((byte)digit);

// enum-lar özlərində tam ədədlər saxlayan adlı konstandadır.
// Default olaraq enum-ların tipi int olaraq götürülür.
// Bütün qeyd edilən tam tiplərdən istifadə etmək olar: (byte, sbyte, short, ushort, int, uint, long, ulong) 
enum EnumType : byte // Birbaşa byte tipindən istifadə edəcəyimiz göstəririk.
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}