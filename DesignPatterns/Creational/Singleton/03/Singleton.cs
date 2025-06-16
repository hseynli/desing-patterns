namespace DesignPatterns.Creational.Singleton._03;

internal sealed class Singleton
{
    private static readonly Lazy<Singleton> _lazyInstance = new(() => new());

    public static Singleton Instance => _lazyInstance.Value;

    private Singleton()
    {
        Console.WriteLine("Instantiating singleton");
    }
}