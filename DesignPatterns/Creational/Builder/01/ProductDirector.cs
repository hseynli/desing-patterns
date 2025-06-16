namespace DesignPatterns.Creational.Builder._01;

// The Director is only responsible for executing the building steps in a
// particular sequence. It is helpful when producing products according to a
// specific order or configuration. Strictly speaking, the Director class is
// optional, since the client can control builders directly.

public class ProductDirector(IBuilder builder)
{
    public void ConstructProduct()
    {
        builder.BuildName();
        builder.BuildDescription();
    }

    public void ConstructOnlyeProductName()
    {
        builder.BuildName();
    }
}