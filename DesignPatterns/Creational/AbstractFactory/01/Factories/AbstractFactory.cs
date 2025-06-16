using DesignPatterns.Creational.AbstractFactory._01.Products;

namespace DesignPatterns.Creational.AbstractFactory._01.Factories;

public abstract class AbstractFactory
{
    public abstract Product1 CreateProduct1();
    public abstract Product2 CreateProduct2();
}