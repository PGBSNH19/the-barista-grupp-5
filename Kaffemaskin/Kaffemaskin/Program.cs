using System;

namespace Kaffemaskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Start()
        {
            var bean = new Bean();
            var grinder = new Grinder();
            var coffeMaker = new CoffeeMaker();
            var cup = new Cup();
        }

    }
    class Espresso
    {
        string origin;
        string roastLevel;
        string beanType;
        bool grind;

        int strenght;
        int waterVolume;
        string filter;

        double cupVolume;
        double milk;
        bool sugar;

        public void choseBean()
        {

        }

    }
}
    //class Bean
    //{
    //    string origin;
    //    string roastLevel;
    //    string beanType;
    //    bool grind;
    //}


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
//}
