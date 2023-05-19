Console.OutputEncoding = System.Text.Encoding.UTF8;

// Konstantanın adı əsasında elementi tapırıq.
object element = Enum.Parse(typeof(EnumType), "Infinite");
EnumType number = (EnumType)element;

Console.WriteLine("Konstantanın dəyəri {0}: {1}", number, (byte)number);

// Enum.IsDefined() - qeyd edilən ad əsasında elementin olub olmadığını yoxlayır 
bool flag = Enum.IsDefined(typeof(EnumType), "one");

if (flag == true)
    Console.WriteLine("Hə, belə element var.");
else
    Console.WriteLine("Yox, belə element yoxdur.");


enum EnumType
{
    Zero,  // = 0 
    One = 1,
    one = One,
    Two = 2,
    Three, // = 3
    Four,  // = 4
    Five = 5,
    Six = Nine,
    //Seven,
    Eight = 8,
    Nine,
    Ten = 10,
    Infinite = 255
}