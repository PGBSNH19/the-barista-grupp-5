using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffe
{
    public interface ICoffee
    {
        IList<string> Ingredients { get; set; }
        string CoffeeType { get; }

    }

    public interface ICoffeeMaker
    {
        ICoffeeMaker AddChocolateSyrup();
        ICoffeeMaker AddEspresso();
        ICoffeeMaker AddMilk();
        ICoffeeMaker AddMilkFoam();
        ICoffeeMaker AddWater();
        ICoffeeMaker CreateBewerage(Func<ICoffee, ICoffee, bool> func);
        ICoffeeMaker Serve();
    }

    public interface Test
    {
        public List<string> Recipies { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICoffeeMaker coffee = new CoffeMaker().AddMilk().AddEspresso().AddMilkFoam().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients)).Serve();
        }
    }

    public class CoffeMaker : ICoffeeMaker, ICoffee
    {
        public IList<string> Ingredients { get; set; } = new List<string>();
        public string CoffeeType { get; set; }
        public IList<CoffeeRecipie> Recipies = new List<CoffeeRecipie>();

        public ICoffeeMaker AddChocolateSyrup()
        {
            (Ingredients).Add("Chocolate syrup");
            return this;
        }

        public ICoffeeMaker AddEspresso()
        {
            (Ingredients).Add("Espresso");
            return this;
        }

        public ICoffeeMaker AddMilk()
        {
            (Ingredients).Add("Milk");
            return this;
        }

        public ICoffeeMaker AddMilkFoam()
        {
            (Ingredients).Add("Milk foam");
            return this;
        }

        public ICoffeeMaker AddWater()
        {
            (Ingredients).Add("Water");
            return this;
        }

        public ICoffeeMaker CreateBewerage(Func<ICoffee, ICoffee, bool> func)
        {

            Recipies.Add(new CoffeeRecipie() { CoffeeType = "Latte", Ingredients = new List<string> { "Espresso", "Milk" } });
            Recipies.Add(new CoffeeRecipie() { CoffeeType = "Espresso", Ingredients = new List<string> { "Espresso" } });
            Recipies.Add(new CoffeeRecipie() { CoffeeType = "Americano", Ingredients = new List<string> { "Espresso", "Water" } });
            Recipies.Add(new CoffeeRecipie() { CoffeeType = "Cappuccino", Ingredients = new List<string> { "Espresso", "Milk", "Milk foam" } });
            Recipies.Add(new CoffeeRecipie() { CoffeeType = "Mocha", Ingredients = new List<string> { "Chocolate syrup", "Espresso", "Milk" } });
            Recipies.Add(new CoffeeRecipie() { CoffeeType = "Macchiato", Ingredients = new List<string> { "Espresso", "Milk foam" } });

            var orderIngredients = Ingredients.OrderBy(p => p).ToList();
            this.Ingredients = orderIngredients;

            foreach (var item in Recipies)
            {
                if (func.Invoke(this, item) == true)
                {
                    this.CoffeeType = item.CoffeeType;
                }
            }

            if (this.CoffeeType == null)
            {
                this.CoffeeType = "Your own speciality";
            }
            return this;
        }
        public ICoffeeMaker Serve()
        {
            Console.Write($"You have served {this.CoffeeType}\n\nIngredients:\n\n");
            foreach (var item in Ingredients)
            {
                Console.Write($"{item}\n");
            }
            return this;
        }
    }

    public class CoffeeRecipie : ICoffee
    {
        public IList<string> Ingredients { get; set; }
        public string CoffeeType { get; set; }

    }
}