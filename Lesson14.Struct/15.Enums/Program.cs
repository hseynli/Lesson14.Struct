Console.OutputEncoding = System.Text.Encoding.UTF8;
EnumType digit = EnumType.Ten;

// Enum.GetUnderlyingType() - metodu enum-ın hansı tipli ədələri saxlaya biləcəyini qaytarır.
Type @enum = digit.GetType();
Console.WriteLine("1. enum bu tipdən ibarətdir: {0}", @enum.Name);
Type @const = Enum.GetUnderlyingType(@enum);
Console.WriteLine(@const);

// typeof - operatoru System.Type klasının instance-nı qaytarır.
// O da öz növbəsində qəbul etdiyi arqumentdəki tip haqqında informasiyanı saxlayır.
Console.Write("2. enum təyin edən tip bundan ibarətdir: {0}: ");

Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));


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