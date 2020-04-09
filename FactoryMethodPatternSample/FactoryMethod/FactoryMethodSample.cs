using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.FactoryMethod
{
    static class FactoryMethodSample
    {
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

        public static void SandwitchSample()
        {
            Console.Write("Where are you from? ");
            var country = Console.ReadLine();
            var sandwich = MakeSandwich(country.Trim());

            //sandwich.Ingredients.Add(new Mustard());

            Console.WriteLine($"Here, I made you a {sandwich.GetType().Name}, it costs {sandwich.TotalCost}");
            Console.Read();
        }
    }
}
