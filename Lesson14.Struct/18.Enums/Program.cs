Console.OutputEncoding = System.Text.Encoding.UTF8;

EnumType x = EnumType.Five;
EnumType y = EnumType.One;

//if (x < y)                      // Birinci variant yoxlama.
if (EnumType.Five < EnumType.One) // İkinci variant yoxlama.
    Console.WriteLine("X = {0} (kiçikdir) Y = {1}.", x, y);
else
    Console.WriteLine("Y = {0} (kiçikdir) X = {1}.", y, x);


enum EnumType
{
    Zero,  // = 0 
    One = 1,
    one = 1,
    Two = 2,
    Three, // = 3
    Four,  // = 4
    Five = 5,
    //Six,
    Seven,
    Eight = 8,
    Nine,
    Ten = 10,
    Infinite = 255
}