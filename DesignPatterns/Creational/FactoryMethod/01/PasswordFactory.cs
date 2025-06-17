namespace DesignPatterns.Creational.FactoryMethod._01;

interface IPassword;

class SimplePassword : IPassword;
class ComplexPassword : IPassword;

// A concrete class that creates a concrete class
class PasswordFactory
{
    public static Password Generate(/* .. */)
    {
        // complex logic
        return new Password();
    }
}

// A concrete class that creates a concrete class from a set of defined classes
// using inheritance or interface implementation
class PasswordFactory2
{
    public static IPassword Generate(ushort length/* .. */)
    {
        // complex logic
        return length < 5
            ? new SimplePassword()
            : new ComplexPassword();
    }
}

// A static factory method - a static method defined in a concrete type, that creates that type
class Password
{
    // private Password()
    // {
    // }

    public static Password Generate(/* .. */)
    {
        // complex logic
        return new Password();
    }
}