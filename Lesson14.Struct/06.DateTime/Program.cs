Console.OutputEncoding = System.Text.Encoding.UTF8;

DateTime now = DateTime.Now;

Console.WriteLine("İl ay gün (yazı ilə): {0:D}", now);
Console.WriteLine("Gün.ay.il : {0:d}", now);
Console.WriteLine("İl ay gün və saat (yazı ilə) (hh:mm:ss) : {0:F}", now);
Console.WriteLine("İl ay gün və saat (yazı ilə) (hh:mm) : {0:f}", now);
Console.WriteLine("Gün.ay.il saat(ss:mm:ss) : {0:G}", now);
Console.WriteLine("Gün.ay.il saat(ss:mm) : {0:g}", now);
Console.WriteLine("Cari ay və ayın günü: {0:M}", now);
Console.WriteLine("Cari ay və il : {0:Y}", now);
Console.WriteLine("Saat(ss:mm:ss) : {0:T}", now);
Console.WriteLine("Saat(ss:mm) : {0:t}", now);