Console.OutputEncoding = System.Text.Encoding.UTF8;

MethodEnum(EnumType.Five);

EnumType digit = EnumType.Ten;
MethodEnum(digit);

int i = (int)(++digit);
Console.WriteLine(i);

Console.WriteLine(digit);             // Dəyişən dəyişildi.
Console.WriteLine((int)EnumType.Ten); // Konstanda dəyişilmədi.

digit++;
digit = digit + 5;

// Yolverilməzdir.
//digit = ++EnumType.One;
//digit = EnumType.One + EnumType.Two; 


// Metodun arqumenti enum qəbul edir
void MethodEnum(EnumType e)
{
    switch (e)
    {
        case EnumType.Zero:
            Console.WriteLine("Ədəd 0");
            break;
        case EnumType.Two:
            Console.WriteLine("Ədəd 2");
            break;
        case EnumType.Five:
            Console.WriteLine("Ədəd 5");
            break;
        case EnumType.Ten:
            Console.WriteLine("Ədəd 10");
            break;

        default: break;
    }
}


enum EnumType
{
    Zero,  // = 0 
    One,   // = 1
    one = One,
    Two = 2,
    Three, // = 3
    Four,  // = 4
    Five = 5,
    Six = Nine,
    //Seven,
    Eight = 8, // Əgər dəyəri birbaşa yazmasaq, onda bu sətirdə xəta baş verəcəkdir!
    Nine,
    Ten = 10,
    Infinite = 255
}