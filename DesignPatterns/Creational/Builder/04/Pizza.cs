namespace DesignPatterns.Creational.Builder._04;

public record Pizza(Dough Dough, string Sauce, string Cheese, List<string> Toppings)
{
    public class Builder : IDoughStep, ISauceStep, ICheeseStep, IToppingsStep
    {
        private Dough _dough = default!;
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private List<string> _toppings = [];

        private Builder()
        {
        }

        public static IDoughStep Empty() => new Builder();

        public ISauceStep SetDough(Action<Dough.Builder> buildDoughAction)
        {
            var doughBuilder = new Dough.Builder();
            buildDoughAction(doughBuilder);
            _dough = doughBuilder.Build();

            return this;
        }

        public ICheeseStep SetSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }

        public IToppingsStep SetCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }

        public IToppingsStep AddTopping(string topping)
        {
            _toppings.Add(topping);

            return this;
        }

        public Pizza Build()
        {
            return new Pizza(_dough, _sauce, _cheese, _toppings);
        }
    }

    public interface IDoughStep
    {
        ISauceStep SetDough(Action<Dough.Builder> doughBuilderAction);
    }

    public interface ISauceStep
    {
        ICheeseStep SetSauce(string sauce);
    }

    public interface ICheeseStep
    {
        IToppingsStep SetCheese(string cheese);
    }

    public interface IToppingsStep
    {
        IToppingsStep AddTopping(string topping);
        Pizza Build();
    }
}