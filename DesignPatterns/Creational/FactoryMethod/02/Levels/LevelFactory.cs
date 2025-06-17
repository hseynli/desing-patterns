namespace DesignPatterns.Creational.FactoryMethod._02.Levels;

// Simple factory for creating a level
public static class LevelFactory
{
    public static Level CreateLevel(int levelNumber)
    {
        return levelNumber switch
        {
            1 => new CaveLevel(),
            2 => new HauntedHouseLevel(),
            _ => throw new Exception(),
        };
    }
}