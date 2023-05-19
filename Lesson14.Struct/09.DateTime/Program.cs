DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25);
Console.WriteLine(date1.ToLocalTime()); // 20.07.2015 21:30:25
Console.WriteLine(date1.ToUniversalTime()); // 20.07.2015 15:30:25
Console.WriteLine(date1.ToLongDateString()); // 20 July 2015 г.
Console.WriteLine(date1.ToShortDateString()); // 20.07.2015
Console.WriteLine(date1.ToLongTimeString()); // 18:30:25
Console.WriteLine(date1.ToShortTimeString()); // 18:30