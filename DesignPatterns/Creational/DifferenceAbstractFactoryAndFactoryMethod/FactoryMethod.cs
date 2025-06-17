namespace DesignPatterns.Creational.DifferenceAbstractFactoryAndFactoryMethod.FactoryMethod;

// This example follows the same Factory Method pattern structure as your document example, but with vehicles instead of documents.
// The pattern enables you to create different types of vehicles (Car, Motorcycle) through their respective creator classes,
// while keeping the client code independent of concrete vehicle classes.

// Product interface
public interface IVehicle
{
    void Start();
    void Stop();
}

// Concrete products
public class Car : IVehicle
{
    public void Start() => Console.WriteLine("Starting car engine");
    public void Stop() => Console.WriteLine("Stopping car engine");
}

public class Motorcycle : IVehicle
{
    public void Start() => Console.WriteLine("Starting motorcycle engine");
    public void Stop() => Console.WriteLine("Stopping motorcycle engine");
}

// Creator with factory method
public abstract class VehicleCreator
{
    // Factory Method
    public abstract IVehicle CreateVehicle();

    // Operation using factory method
    public void TestVehicle()
    {
        IVehicle vehicle = CreateVehicle();
        vehicle.Start();
    }
}

// Concrete creators
public class CarCreator : VehicleCreator
{
    public override IVehicle CreateVehicle() => new Car();
}

public class MotorcycleCreator : VehicleCreator
{
    public override IVehicle CreateVehicle() => new Motorcycle();
}