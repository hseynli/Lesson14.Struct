short a = 25;

// Boxing - struktur tipin referance tipə çevrilməsi.
object o = a;

// UnBoxing - referance tipin struktur tipə çevrilməsi.
short b = (short)o;

// UnBoxing ancaq əvvəlcədən Boxing olunduğu tipə mənimsədilməlidir.
//byte s = (byte)o;

Console.WriteLine("Done!\n");