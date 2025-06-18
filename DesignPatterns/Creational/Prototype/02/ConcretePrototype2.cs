namespace DesignPatterns.Creational.Prototype._02;

public class ConcretePrototype2 : IPrototype
{
    public IPrototype Clone()
    {
        return new ConcretePrototype2();
    }
}
