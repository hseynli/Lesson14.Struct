MyStruct my = new MyStruct();

// Boxing.
ValueType boxed = my;

// UnBoxing.
MyStruct unBoxed = (MyStruct)boxed;

struct MyStruct //: ValueType
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}