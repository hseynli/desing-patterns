public class Program
{
    public static void Main_Delegate(string[] args)
    {
        Run(person =>
        {
            person.Id = 1;
            person.Name = "John Doe";
        });
    }

    static void Run(Action<Person> action)
    {
        Person person = new();
        action.Invoke(person);
        Console.WriteLine(person);
    }
}

record Person
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}