namespace DesignPatterns.Creational.DifferenceAbstractFactoryAndFactoryMethod.AbstractFactory;

// Product interfaces
public interface ICar
{
    void Start();
    void Stop();
}

public interface IMotorcycle
{
    void Start();
    void Stop();
}

// Economy concrete products
public class EconomyCar : ICar
{
    public void Start() => Console.WriteLine("Starting economy car engine");
    public void Stop() => Console.WriteLine("Stopping economy car engine");
}

public class EconomyMotorcycle : IMotorcycle
{
    public void Start() => Console.WriteLine("Starting economy motorcycle engine");
    public void Stop() => Console.WriteLine("Stopping economy motorcycle engine");
}

// Luxury concrete products
public class LuxuryCar : ICar
{
    public void Start() => Console.WriteLine("Starting luxury car engine with push button");
    public void Stop() => Console.WriteLine("Stopping luxury car engine with auto shutdown");
}

public class LuxuryMotorcycle : IMotorcycle
{
    public void Start() => Console.WriteLine("Starting luxury motorcycle engine with keyless ignition");
    public void Stop() => Console.WriteLine("Stopping luxury motorcycle engine with soft shutdown");
}

// Abstract Factory
public interface IVehicleFactory
{
    ICar CreateCar();
    IMotorcycle CreateMotorcycle();
}

// Concrete Factories
public class EconomyVehicleFactory : IVehicleFactory
{
    public ICar CreateCar() => new EconomyCar();
    public IMotorcycle CreateMotorcycle() => new EconomyMotorcycle();
}

public class LuxuryVehicleFactory : IVehicleFactory
{
    public ICar CreateCar() => new LuxuryCar();
    public IMotorcycle CreateMotorcycle() => new LuxuryMotorcycle();
}

// Client code
public class VehicleClient
{
    private readonly ICar _car;
    private readonly IMotorcycle _motorcycle;

    public VehicleClient(IVehicleFactory factory)
    {
        _car = factory.CreateCar();
        _motorcycle = factory.CreateMotorcycle();
    }

    public void TestVehicles()
    {
        Console.WriteLine("Testing vehicles from the same factory:");
        _car.Start();
        _motorcycle.Start();
        _car.Stop();
        _motorcycle.Stop();
    }
}