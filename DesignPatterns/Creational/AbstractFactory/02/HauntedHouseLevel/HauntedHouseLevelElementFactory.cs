using DesignPatterns.Creational.AbstractFactory._02.Common;

namespace DesignPatterns.Creational.AbstractFactory._02.HauntedHouseLevel;

public class HauntedHouseLevelElementFactory : ILevelElementFactory
{
    public IEnemy CreateEnemy()
    {
        return new Ghost();
    }

    public IPowerUp CreatePowerUp()
    {
        return new Orb();
    }

    public IWeapon CreateWeapon()
    {
        return new Staff();
    }
}