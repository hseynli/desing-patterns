namespace CommonRunner;

internal class ReturnInterface
{
    public static void Main()
    {
        MyClass myClass = new MyClass();
        IMyInterface myInterface = myClass.MyMethod();
        MyClass result = myInterface as MyClass;
        Console.WriteLine(result is null);
        Console.WriteLine(myInterface.GetType());


        Console.WriteLine("\nDone!");
    }
}

interface IMyInterface
{
    IMyInterface MyMethod();
}

interface IMyInterface2
{
    IMyInterface2 MyMethod2();
}

class MyClass : IMyInterface, IMyInterface2
{
    public IMyInterface MyMethod()
    {
        return this;
    }
    public IMyInterface2 MyMethod2()
    {
        return this;
    }
}