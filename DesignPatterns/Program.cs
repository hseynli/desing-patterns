using DesignPatterns.Creational.AbstractFactory._01.Factories;
using DesignPatterns.Creational.AbstractFactory._01.Products;
using DesignPatterns.Creational.AbstractFactory._02.CaveLevel;
using DesignPatterns.Creational.AbstractFactory._02.Common;
using DesignPatterns.Creational.AbstractFactory._02.HauntedHouseLevel;
using DesignPatterns.Creational.Builder._01;
using DesignPatterns.Creational.Builder._03;
using DesignPatterns.Creational.FactoryMethod._01;
using DesignPatterns.Creational.FactoryMethod._02.Levels;
using DesignPatterns.Creational.FactoryMethod._03;
using DesignPatterns.Creational.Prototype._01;
using DesignPatterns.Creational.Prototype._02;
using DesignPatterns.Creational.Prototype._03;
using DesignPatterns.Creational.Singleton._01;
using Dumpify;

//Runner.RunSingletions();
//Runner.RunBuilders();
//Runner.RunAbstractFactories();
//Runner.RunFabricMethods();
Runner.RunPrototypes();

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
        RunStepBuilder();

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

    public static void RunAbstractFactories()
    {
        RunSimpleAbstractFactory();
        RunRealExampleAbstractFactory();

        void RunSimpleAbstractFactory()
        {
            // Using the abstract factory pattern
            AbstractFactory abstractFactory = new ConcreteFactory();

            Product1 product1 = abstractFactory.CreateProduct1();
            Product2 product2 = abstractFactory.CreateProduct2();

            // Not using the abstract factory pattern
            ConcreteProduct1 concreteProduct1 = new();
            ConcreteProduct2 concreteProduct2 = new();
        }

        void RunRealExampleAbstractFactory()
        {
            SetupEnvironment(new CaveLevelElementFactory());
            SetupEnvironment(new HauntedHouseLevelElementFactory());

            void SetupEnvironment(ILevelElementFactory levelFactory)
            {
                IEnemy enemy = levelFactory.CreateEnemy();
                IWeapon weapon = levelFactory.CreateWeapon();
                IPowerUp powerUp = levelFactory.CreatePowerUp();
            }            
        }
    }

    public static void RunFabricMethods()
    {
        RunSimpleFactoryMethod();
        RunRealExampleFactoryMethod();
        RunDocumentCreatorExample();

        void RunSimpleFactoryMethod()
        {
            Password password = PasswordFactory.Generate();
            IPassword password2 = PasswordFactory2.Generate(length: 4);
        }

        void RunRealExampleFactoryMethod()
        {
            Level level1 = LevelFactory.CreateLevel(levelNumber: 1);
            level1.EncounterEnemy();

            Level level2 = new HauntedHouseLevel();
            level2.EncounterEnemy();
        }

        void RunDocumentCreatorExample()
        {
            DocumentCreator creator = new PDFDocumentCreator();
            creator.OpenDocument(); // Creates and opens a PDF document

            creator = new WordDocumentCreator();
            creator.OpenDocument(); // Creates and opens a Word document
        }
    }

    public static void RunPrototypes()
    {
        RunSimplePrototype();
        RunOriginalPrototype();
        RunFigmaExample();

        void RunSimplePrototype()
        {
            Person person = new Person("Farid", ["Fold Laundry"]);

            Person shallowCopy = person.ShallowClone();
            Person deepCopy = person.DeepClone();

            shallowCopy.Hobbies.Add("Mop floors");
            deepCopy.Hobbies.Add("Clean fridge");

            person.Dump();
        }

        void RunOriginalPrototype()
        {
            // IPrototype prototype = new ConcretePrototype1();
            IPrototype prototype = new ConcretePrototype2();

            var prototypeClone = prototype.Clone();
        }

        void RunFigmaExample()
        {
            // canvas
            var rectangle = new Rectangle(width: 100, height: 100, Color.LightGray);

            CopyDrag(rectangle);
            CopyDrag(new Circle(radius: 50, Color.LightGray));

            void CopyDrag(IShape shape)
            {
                IShape newShape = shape.Clone();
            }
        }
    }
}