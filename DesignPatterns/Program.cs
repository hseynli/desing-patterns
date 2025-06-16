using DesignPatterns.Creational.Builder._01;
using DesignPatterns.Creational.Builder._03;
using DesignPatterns.Creational.Singleton._01;

//Runner.RunSingletions();
Runner.RunBuilders();

Console.WriteLine("\nDone!");

static class Runner
{
    public static void RunSingletions()
    {
        RunSingletonWithRaceCondition();
        RunSingletonThreadSafe();
        RunSingletonLazy();

        void RunSingletonWithRaceCondition()
        {
            ParallelEnumerable.Range(0, 1000).ForAll(_ =>
            {
                Singleton singleton = Singleton.Instance;
            });
        }

        void RunSingletonThreadSafe()
        {
            ParallelEnumerable.Range(0, 1000).ForAll(_ =>
            {
                DesignPatterns.Creational.Singleton._02.Singleton singleton = DesignPatterns.Creational.Singleton._02.Singleton.Instance;
            });
        }

        void RunSingletonLazy()
        {
            ParallelEnumerable.Range(0, 1000).ForAll(_ =>
            {
                DesignPatterns.Creational.Singleton._03.Singleton singleton = DesignPatterns.Creational.Singleton._03.Singleton.Instance;
            });
        }
    }

    public static void RunBuilders()
    {
        RunSimpleBuilder();
        RunFluentBuilder();
        RunFluentBuilderWithChaining();

        void RunSimpleBuilder()
        {
            IBuilder builder = new SimpleProductBuilder();
            ProductDirector director = new ProductDirector(builder);
            director.ConstructProduct();
            Product product = builder.Build();
            Console.WriteLine($"Product Name: {product.Name}, Description: {product.Description}");

            Console.WriteLine(new string('-', 120));

            //Or without using the director
            IBuilder builderWithoutDirector = new SimpleProductBuilder();
            builderWithoutDirector.BuildName();
            builderWithoutDirector.BuildDescription();
            product = builderWithoutDirector.Build();
            Console.WriteLine($"Product Name: {product.Name}, Description: {product.Description}");
        }

        void RunFluentBuilder()
        {
            DesignPatterns.Creational.Builder._02.Product product = new DesignPatterns.Creational.Builder._02.Product.Builder()
                .SetName("Simple product")
                .SetDescription("This is a simple product")
                .Build();
        }

        void RunFluentBuilderWithChaining()
        {
            Pizza product = new Pizza.Builder()
                        .AddTopping("Olives")
                        .AddTopping("Onions")
                        .SetSauce("Spicy tomato sauce")
                        .SetCheese("Vegan cheese")
                        .SetDough(dough => dough
                            .SetThickness(3)
                            .SetFlour("whole wheat"))
                        .Build();
        }

        void RunStepBuilder()
        {
            DesignPatterns.Creational.Builder._04.Pizza product = DesignPatterns.Creational.Builder._04.Pizza.Builder.Empty()
                .SetDough(dough => dough
                    .SetThickness(3)
                    .SetFlour("whole wheat"))
                .SetSauce("Spicy tomato sauce")
                .SetCheese("Vegan cheese")
                .AddTopping("Olives")
                .AddTopping("Onions")
                .Build();
            Console.WriteLine($"Pizza with {product.Dough.Flour} dough, {product.Sauce} sauce, {product.Cheese} cheese and toppings: {string.Join(", ", product.Toppings)}");
        }
    }
}