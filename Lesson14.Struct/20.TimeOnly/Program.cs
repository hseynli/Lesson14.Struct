TimeOnly time1 = new TimeOnly(4, 30);
Console.WriteLine(time1);   // 4: 30

TimeOnly time2 = new TimeOnly(14, 23, 30);
Console.WriteLine(time2);   // 14: 23

TimeOnly time3 = new TimeOnly(14, 23, 30);
Console.WriteLine(time3.Hour);       // 14
Console.WriteLine(time3.Minute);     // 23
Console.WriteLine(time3.Second);     // 30