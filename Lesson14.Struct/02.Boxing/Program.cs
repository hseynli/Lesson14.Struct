MyStruct my;
my.Method();
// Boxing.
IInterface boxed = my;

boxed.Method();

// UnBoxing.
MyStruct unBoxed = (MyStruct)boxed;

Console.WriteLine("Done!\n");

interface IInterface
{
    void Method();
}

struct MyStruct : IInterface
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}