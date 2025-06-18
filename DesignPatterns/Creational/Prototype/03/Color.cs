namespace DesignPatterns.Creational.Prototype._03;

public class Color(ushort red, ushort green, ushort blue) : IPrototype<Color>
{
    public static readonly Color LightGray = new(217, 217, 217);

    public Color Clone()
    {
        return new Color(red, green, blue);
    }
}