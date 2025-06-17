using DesignPatterns.Creational.FactoryMethod._02.Enemies;

namespace DesignPatterns.Creational.FactoryMethod._02.Levels;

public abstract class Level
{
    public abstract IEnemy CreateEnemy();

    public void EncounterEnemy()
    {
        IEnemy enemy = CreateEnemy();
        enemy.Scream();
        enemy.Attack();
    }
}