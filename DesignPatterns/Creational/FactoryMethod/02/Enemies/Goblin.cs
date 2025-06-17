namespace DesignPatterns.Creational.FactoryMethod._02.Enemies;

public class Goblin : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Goblin Attack!");
    }

    public void Scream()
    {
        Console.WriteLine("Goblin Scream!");
    }
}