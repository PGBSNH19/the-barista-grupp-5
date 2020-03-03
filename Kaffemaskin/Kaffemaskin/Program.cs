using System;

namespace Kaffemaskin
{
    class Program : Espresso
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Espresso.choseBean(origin, roastLevel, beanType);
        }

        public void Start()
        {
           
        }

    }
    class Espresso
    {
       public static string origin { get; set; }
       public static string roastLevel { get; set; }
       public static string beanType { get; set; }
        
        int strenght;
        int waterVolume;
        string filter;

        double cupVolume;
        double milk;
        bool sugar;

        public static object choseBean(string origin, string roastLevel, string beanType)
        {
            var Bean = new Bean() {
                origin = origin,
                roastLevel = roastLevel,
                beanType = beanType
            };

            return Bean;
        }

        public void makeCoffee()
        {

        }

    }

    class Bean
    {
        string origin;
        string roastLevel;
        string beanType;
        bool grind;
    }


    //class CoffeeMaker
    //{
    //    int strenght;
    //    int waterVolume;
    //    string filter;
    //}

    //class Cup
    //{
    //    double cupVolume;
    //    double milk;
    //    bool sugar;

    //}
}
