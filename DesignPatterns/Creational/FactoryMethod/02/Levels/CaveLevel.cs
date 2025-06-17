using DesignPatterns.Creational.FactoryMethod._02.Enemies;

namespace DesignPatterns.Creational.FactoryMethod._02.Levels;

public class CaveLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }
}