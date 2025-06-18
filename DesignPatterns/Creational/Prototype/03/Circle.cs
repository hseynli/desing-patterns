namespace DesignPatterns.Creational.Prototype._03;

public class Circle(int radius, Color color) : IShape
{
    public IShape Clone()
    {
        return new Circle(radius, color.Clone());
    }
}