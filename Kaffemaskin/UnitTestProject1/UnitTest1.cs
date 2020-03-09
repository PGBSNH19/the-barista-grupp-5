using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coffe;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCreateLatteWithCreateBewerage()
        {
            //Latte = Milk and Espresso
            ICoffee latte = new CoffeMaker().AddMilk().AddEspresso().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual("Latte", latte.CoffeeType);
        }

        [TestMethod]
        public void TestMethodEspressoWithCreateBewerage()
        {
            //Espresso = Espresso
            ICoffee espresso = new CoffeMaker().AddEspresso().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual("Espresso", espresso.CoffeeType);
        }

        [TestMethod]
        public void TestMethodCappuccinoWithCreateBewerage()
        {
            //Cappuccino = Milk, Espresso and Milk foam
            ICoffee cappuccino = new CoffeMaker().AddMilk().AddEspresso().AddMilkFoam().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual("Cappuccino", cappuccino.CoffeeType);
        }

        [TestMethod]
        public void TestMethodAmericanoWithCreateBewerage()
        {
            //Americano = Espresso and water
            ICoffee americano = new CoffeMaker().AddEspresso().AddWater().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual("Americano", americano.CoffeeType);
        }

        [TestMethod]
        public void TestMethodMochaWithCreateBewerage()
        {
            //Mocha = Espresso, milk and chocolate syrup
            ICoffee mocha = new CoffeMaker().AddEspresso().AddMilk().AddChocolateSyrup().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual("Mocha", mocha.CoffeeType);
        }

        [TestMethod]
        public void TestMethodMacchiatoWithCreateBewerage()
        {
            //Macchiato = Espresso and milk foam
            ICoffee macchiato = new CoffeMaker().AddEspresso().AddMilkFoam().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual("Macchiato", macchiato.CoffeeType);
        }

        [TestMethod]
        public void TestMethodCreateBewerage()
        {
            //Macchiato = Espresso and milk foam
            string a = "Espresso";
            ICoffee macchiato = new CoffeMaker().AddEspresso().AddMilkFoam().CreateBewerage((x, y) => x.Ingredients.SequenceEqual(y.Ingredients));
            Assert.AreEqual( a, macchiato.Ingredients[0]);
        }
    }
}
