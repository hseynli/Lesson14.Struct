// EnumType tipində olan dəyişənə diapazona daxil olan ixtiyari dəyəri mənimsətmək olar
EnumType five = (EnumType)5;

Console.WriteLine(five);


enum EnumType : byte
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}