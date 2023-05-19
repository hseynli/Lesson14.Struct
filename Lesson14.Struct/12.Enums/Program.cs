Console.WriteLine(EnumType.One);

// C#-da təyin olunmuş bütün tam ədəd tipli verilənlərin tipindən istifadə etmək olar:
// (byte, sbyte, short, ushort, int, uint, long, ulong)
// .net aliaslarından istifadə etmək olmaz:
// (Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64)
enum EnumType //: Int32 // Xəta.
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}