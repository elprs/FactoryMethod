using System;

namespace FactoryMethodPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //SanswirchShop
            Console.WriteLine("Where are you from?");
            var country = Console.ReadLine();
            var sanswitch = MakeSandwich(country.Trim());
            // an thelo pros8eto kai alla ilika:
            //sanswitch.Ingredients.Add(new Mustard());
            Console.WriteLine($"Here, I made you a {sanswitch.GetType().Name}, it costs {sanswitch.TotalCost}.Thank you! ");
            Console.WriteLine("=========================================");
            //FactoryMethod.FactoryMethodSample.Sample();

            AbstractFactory.AbstractFactoryDemo.Demo();

            Console.ReadLine();
        }

        static Sandwich MakeSandwich(string country)
        {
            switch (country)
            {
                case "USA":
                    return new HotDog();
                default:
                    return new Souvlaki();
            }
        }
    }
}
