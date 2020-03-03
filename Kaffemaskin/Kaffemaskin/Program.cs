using System;

namespace Kaffemaskin
{
    class Program : Espresso
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Espresso.choseBean("afroica", 3, "arabica");
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

        public object choseBean(string origin, int roastLevel, string beanType)
        {
            var Bean = new Bean() {
                Origin = origin,
                RoastLevel = roastLevel,
                BeanType = beanType
            };

            return Bean;
        }

        public void makeCoffee()
        {

        }

    }

    public class Bean
    {
        public string Origin { get; set; }
        public int RoastLevel { get; set; }
        public string BeanType { get; set; }
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
