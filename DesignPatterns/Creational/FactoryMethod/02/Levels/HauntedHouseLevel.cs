using DesignPatterns.Creational.FactoryMethod._02.Enemies;

namespace DesignPatterns.Creational.FactoryMethod._02.Levels;

public class HauntedHouseLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }
}