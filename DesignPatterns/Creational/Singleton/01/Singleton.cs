namespace DesignPatterns.Creational.Singleton._01;

internal sealed class Singleton
{
    private static Singleton _instance = default!;
    public static Singleton Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    private Singleton()
    {
        Console.WriteLine("Instantiating singleton");
    }
}