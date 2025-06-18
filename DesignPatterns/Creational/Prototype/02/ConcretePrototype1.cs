namespace DesignPatterns.Creational.Prototype._02;

public class ConcretePrototype1 : IPrototype
{
    public IPrototype Clone()
    {
        return new ConcretePrototype1();
    }
}