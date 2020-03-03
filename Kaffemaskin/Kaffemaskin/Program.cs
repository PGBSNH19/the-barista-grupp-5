using System;
using System.Collections.Generic;

namespace Kaffemaskin
{
    class Program : Espresso
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var espresso = new Espresso().makeCoffee(5).choseBean("afroica", 5, "arabica");
            Console.WriteLine(espresso.ToString());



        }

        public void Start()
        {
           
        }

    }
    class Espresso
    {
       ////public string origin { get; set; }
       ////public  string roastLevel { get; set; }
       ////public  string beanType { get; set; }
        
       
            private Cup obj = new Cup();
        public Espresso choseBean(string origin, int roastLevel, string beanType)
        {

            obj.Origin = origin;
            obj.RoastLevel = roastLevel;
            obj.BeanType = beanType;
            return this;
        }
       public Espresso makeCoffee(int inputStrenght)
        {

            obj.Strenght = inputStrenght;
            return this;
        }


    }

    //public class Bean
    //{
    //    public string Origin { get; set; }
    //    public int RoastLevel { get; set; }
    //    public string BeanType { get; set; }
    //}


    //class CoffeeMaker
    //{
    //    public int Strenght { get; set; }

    //}

    class Cup
    {
        public string Origin { get; set; }
        public int RoastLevel { get; set; }
        public string BeanType { get; set; }
        public int Strenght { get; set; }

    }
}
