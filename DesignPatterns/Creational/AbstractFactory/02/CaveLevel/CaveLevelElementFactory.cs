using _3._2.CaveLevel;
using DesignPatterns.Creational.AbstractFactory._02.Common;

namespace DesignPatterns.Creational.AbstractFactory._02.CaveLevel;

public class CaveLevelElementFactory : ILevelElementFactory
{
    public IEnemy CreateEnemy()
    {
        return new Goblin();
    }

    public IPowerUp CreatePowerUp()
    {
        return new Crystal();
    }

    public IWeapon CreateWeapon()
    {
        return new Axe();
    }
}