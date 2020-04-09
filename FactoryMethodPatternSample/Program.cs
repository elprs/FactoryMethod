using System;

namespace FactoryMethodPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethod.FactoryMethodSample.SandwitchSample();
            //PrinterFactoryMethod.PrinterFactory.CustomerChoosing();

            // AbstractFactory.AbstractFactoryDemo.Demo();

            MenuAbstractFactory.AbstractFactoryDemo.Demo();
          


            Console.ReadLine();
        }

        //static Sandwich MakeSandwich(string country)
        //{
        //    switch (country)
        //    {
        //        case "USA":
        //            return new HotDog();
        //        default:
        //            return new Souvlaki();
        //    }
        //}
    }
}
