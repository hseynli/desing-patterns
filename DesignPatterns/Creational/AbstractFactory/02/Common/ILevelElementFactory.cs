namespace DesignPatterns.Creational.AbstractFactory._02.Common;

public interface ILevelElementFactory
{
    IEnemy CreateEnemy();
    IWeapon CreateWeapon();
    IPowerUp CreatePowerUp();
}