namespace DesignPatterns.Creational.Builder._01;

public interface IBuilder
{
    void BuildName();
    void BuildDescription();
    Product Build();
}