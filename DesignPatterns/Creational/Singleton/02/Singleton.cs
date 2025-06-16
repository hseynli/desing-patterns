namespace DesignPatterns.Creational.Singleton._02;

internal sealed class Singleton
{
    private static Singleton _instance = default!;
    private static object _lock = new();

    public static Singleton Instance
    {
        get
        {
            if (_instance is null)
            {
                Console.WriteLine("Locking");

                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }

    private Singleton()
    {
        Console.WriteLine("Instantiating singleton");
    }
}