namespace DesignPatterns.Creational.Prototype._01;

record Person(string Name, List<string> Hobbies)
{
    public Person ShallowClone()
    {
        //return this with { };
        return new Person(this);
    }

    public Person DeepClone()
    {
        //return new(Name, [.. Hobbies]);
        return new Person(Name, new List<string>(Hobbies));
    }
}