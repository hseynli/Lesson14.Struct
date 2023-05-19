Console.OutputEncoding = System.Text.Encoding.UTF8;

// Yeni tarixin yaradılması. DateTime(yy, mm, dd)
DateTime newYearDate = new DateTime(2024, 1, 1);
DateTime today = DateTime.Now;

// Tarix aralığını müəyyən edir.
TimeSpan left = newYearDate - today;
Console.WriteLine("Yeni ilə " + left.Days + " gün qalıb");
Console.WriteLine("Yeni ilə " + left.TotalHours + " saat qalıb");

// Yeni tarixin və saatın yaradılması. DateTime(yy, mm, dd, hh, min, sec)
DateTime newDate = new DateTime(2023, 12, 05, 20, 11, 11);

Console.WriteLine(newDate);                         
Console.WriteLine(newDate.TimeOfDay);               
                                                    

// Hər hansı string tipində müəyyən edilmiş tarixin DateTime tipinə çevrilməsi
Console.WriteLine(DateTime.Parse("3/12/2012"));

Console.WriteLine(DateTime.Parse("05 march 2012"));  // Ayı kompyuterin lokal dilində yazmaq lazımdır.