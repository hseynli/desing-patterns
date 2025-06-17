using DesignPatterns.Creational.DifferenceAbstractFactoryAndFactoryMethod.AbstractFactory;
using DesignPatterns.Creational.DifferenceAbstractFactoryAndFactoryMethod.FactoryMethod;

namespace DesignPatterns.Creational.DifferenceAbstractFactoryAndFactoryMethod;

/*
 1. Factory Method
 •	Creates ONE type of object
 •	"I just want a vehicle"
 */

// Factory Method - Creates ONE type of object
public abstract class Creator
{
    // This single method creates ONE type of product
    public abstract IVehicle CreateVehicle();
}

public class CarCreator : Creator
{
    public override IVehicle CreateVehicle() => new Car();
}

public class MotorcycleCreator : Creator
{
    public override IVehicle CreateVehicle() => new Motorcycle();
}

// Usage
public class FactoryMethodUsage
{
    public static void Usage()
    {
        Creator creator = new CarCreator();
        IVehicle myCar = creator.CreateVehicle();
    }
}

/*
 2. Abstract Factory
 •	Creates MULTIPLE related objects
 •	"I want a complete vehicle set (car AND motorcycle) of the same style"
 */

// Abstract Factory - Creates MULTIPLE related objects
public interface IVehicleFactory
{
    // Multiple methods create DIFFERENT products of the same family
    ICar CreateCar();
    IMotorcycle CreateMotorcycle();
}

// Usage
public class AbstractFactoryMethodUsage
{
    public static void Usage()
    {

        //IVehicleFactory luxuryFactory = new LuxuryVehicleFactory();

        // Get multiple products from the SAME factory
        //ICar luxuryCar = luxuryFactory.CreateCar();
        //IMotorcycle luxuryMotorcycle = luxuryFactory.CreateMotorcycle();
    }
}