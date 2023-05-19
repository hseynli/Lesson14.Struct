Console.OutputEncoding = System.Text.Encoding.UTF8;

DateTime now = DateTime.Now;

Console.WriteLine("Carixi tarix və saat: {0}", now);
Console.WriteLine("İl: {0}", now.Year);
Console.WriteLine("Ay: {0}", now.Month);
Console.WriteLine("Ayın günü: {0}", now.Day);

Console.WriteLine("Cari saat - {0}:{1}:{2}", now.Hour, now.Minute, now.Second);

Console.WriteLine("Həftənin günü : {0}", now.DayOfWeek);
Console.WriteLine("İlin günü {0}", now.DayOfYear);

// Cari kompyuterin tarixi və saatı.
Console.WriteLine(DateTime.Now.Date);