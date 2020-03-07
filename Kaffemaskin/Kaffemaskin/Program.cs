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
        public List<string> Ingredients = new List<string>();
        public string CoffeeType { get; set; }

        public ICoffee AddChocolateSyrup()
        {
            ((List<string>)Ingredients).Add("Chocolate syrup");
            return this;
        }

        public ICoffee AddEspresso()
        {
            ((List<string>)Ingredients).Add("Espresso");
            return this;
        }

        public ICoffee AddMilk()
        {
            ((List<string>)Ingredients).Add("Milk");
            return this;
        }

        public ICoffee AddMilkFoam()
        {
            ((List<string>)Ingredients).Add("Milkfoam");
            return this;
        }

        public ICoffee AddWater()
        {
            ((List<string>)Ingredients).Add("Water");
            return this;
        }

        public ICoffee CreateBewerage()
        {
            if (Ingredients.Count <= 2 && Ingredients.Contains("Milk") && Ingredients.Contains("Espresso"))
            {
                CoffeeType = "Latte";
            }
            else if (Ingredients.Contains("Espresso") && Ingredients.Contains("Milk") && Ingredients.Contains("Milk foam"))
            {
                CoffeeType = "Cappuccino";
            }
            return this;
        }
    }

    class CoffeeType
    {

    }

    class Cappuccino
    {

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