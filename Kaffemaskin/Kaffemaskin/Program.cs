using System;
using System.Collections.Generic;

namespace Coffe
{
    public interface ICoffee
    {

        string CoffeeType { get; }

        ICoffee AddChocolateSyrup();
        ICoffee AddEspresso();
        ICoffee AddMilk();
        ICoffee AddMilkFoam();
        ICoffee AddWater();
    }

        class Program
        {
            
            static void Main(string[] args)
            {
                ICoffee coffee = new CoffeMaker().AddMilk().AddEspresso().AddMilkFoam();
            }

            
        }

        public class CoffeMaker : ICoffee
        {
            
            private IEnumerable<Ingredient> Ingredients = new List<Ingredient>();
            public string CoffeeType { get; }
            public List<CoffeType> Recpies;
            
            public ICoffee AddChocolateSyrup()
            {
                ((List<Ingredient>)Ingredients).Add(new Ingredient() { name = "Chocolate syrup" });
                return this;
            }

            public ICoffee AddEspresso()
            {
                ((List<Ingredient>)Ingredients).Add(new Ingredient() { name = "Espresso" });
                return this;
            }
            
            public ICoffee AddMilk()
            {
                ((List<Ingredient>)Ingredients).Add(new Ingredient() { name = "Milk" });
                return this;
            }

            
            public ICoffee AddMilkFoam()
            {
                ((List<Ingredient>)Ingredients).Add(new Ingredient() { name = "Milk foam" });
                return this;
            }

            public ICoffee AddWater()
            {
                ((List<Ingredient>)Ingredients).Add(new Ingredient() { name = "Water" });
                return this;
            }
            
            public void CreateRecipies()
            {

                Recpies.Add(new CoffeType() { coffeetype = "Cappuccino" }) ;
                Recpies.Add(new CoffeType() { coffeetype = "Americano" });
                Recpies.Add(new CoffeType() { coffeetype = "Espresso" });
                Recpies.Add(new CoffeType() { coffeetype = "Macchiato" });
                Recpies.Add(new CoffeType() { coffeetype = "Mocha" });
                Recpies.Add(new CoffeType() { coffeetype = "Latte" });

            }
        }

        public class Ingredient
        {
            public string name;
        }

        public class CoffeType
        {
            public string coffeetype;
            List<Ingredient> Ingredients = new List<Ingredient>();
        }
}

