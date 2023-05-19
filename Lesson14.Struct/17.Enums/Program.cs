Console.OutputEncoding = System.Text.Encoding.UTF8;

// Enum.GetValues() - metodu Array tipli nəticə qaytarır.
// Bununla bərabər massivin hər bir elementinə enum-ın üzvü veriləcək.

// enum-ın elementlərini massivə mənimsədirik.
Array array = Enum.GetValues(typeof(EnumType));

// Massivdəki elementlər haqqında məlumat əldə edirik.
Console.WriteLine("Bu enum-ın {0} sayda üzvü var \n", array.Length);

// enum-ın bütün elementlərinin ekranda əks elətdirilməsi
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Konstantanın adı: {0}, dəyəri {0:D}", array.GetValue(i));
}

enum EnumType
{
    Zero,  // = 0 
    One = 1,
    one = One,
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