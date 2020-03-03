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
        
        int strenght;
        int waterVolume;
        string filter;

        double cupVolume;
        double milk;
        bool sugar;

        public Espresso choseBean(string origin, int roastLevel, string beanType)
        {
            var Bean = new Bean()
            {
                Origin = origin,
                RoastLevel = roastLevel,
                BeanType = beanType
            };




            return this;
        }
       public Espresso makeCoffee(int inputStrenght)
        {
            var coffeMaker = new CoffeeMaker()
            {
                Strenght = inputStrenght,
            };

            return this;
        }


    }

    public class Bean
    {
        public string Origin { get; set; }
        public int RoastLevel { get; set; }
        public string BeanType { get; set; }
    }


    class CoffeeMaker
    {
        public int Strenght { get; set; }

    }

    //class Cup
    //{
    //    double cupVolume;
    //    double milk;
    //    bool sugar;

    //}
}
