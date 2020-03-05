using System;
using System.Collections.Generic;

namespace Coffe
{
    public interface ICoffee
    {
       
        string CoffeeType { get; set; }

        ICoffee AddChocolateSyrup();
        ICoffee AddEspresso();
        ICoffee AddMilk();
        ICoffee AddMilkFoam();
        ICoffee AddWater();
        ICoffee CreateBewerage();

    }

        class Program
        {
            
            static void Main(string[] args)
            {
                ICoffee coffee = new CoffeMaker().AddEspresso().AddMilk().CreateBewerage();
            }

            
        }

        public class CoffeMaker : ICoffee
        {
            
            private IEnumerable<Ingredient> Ingredients = new List<Ingredient>();
            public string CoffeeType { get; set; }
            
            
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
            
            public ICoffee CreateBewerage()
            {
            
                List<string> test = new List<string>();

                foreach (var item in Ingredients)
                {
                    test.Add(item.name);
                }
               
                if(test.Count <= 2 && test.Contains("Milk") && test.Contains("Espresso"))
                {
                    CoffeeType = "Latte";
                }
                else if(test.Contains("Espresso") && test.Contains("Milk") && test.Contains("Milk foam"))
                {
                    CoffeeType = "Cappuccino";
                }
                return this;
            }
        }

        public class Ingredient
        {
            public string name;

        

        
        }

        
    class Cappuccino
    {
        List<Object> ingredient = new List<Object>();
    }
    class Americano
    {

    }
    class Espresso
    {

    }
    class Macchiato
    {

    }
    class Mocha
    {

    }
    class Latte
    {

    }
}

