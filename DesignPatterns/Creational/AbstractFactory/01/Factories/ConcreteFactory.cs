﻿using DesignPatterns.Creational.AbstractFactory._01.Products;

namespace DesignPatterns.Creational.AbstractFactory._01.Factories;

public class ConcreteFactory : AbstractFactory
{
    public override Product1 CreateProduct1()
    {
        return new ConcreteProduct1();
    }

    public override Product2 CreateProduct2()
    {
        return new ConcreteProduct2();
    }
}