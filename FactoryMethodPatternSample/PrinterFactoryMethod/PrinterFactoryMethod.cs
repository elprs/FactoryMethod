using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.PrinterFactoryMethod
{
    static class PrinterFactory
    { 
        public static PrinterStore SellPrinter(string color)
        {
            switch (color)
            {
                case  "red":
                    return new Kotsovolos();
                case "orange":
                    return new Public();
                default:
                    return new Kotsovolos();
            }
        }

        public static void CustomerChoosing()
        {
            Console.WriteLine("What color of a shop do you want to buy a printer from?");
            var color = Console.ReadLine();
            var printerStore = SellPrinter(color.Trim());

            Console.WriteLine("You can find the printer at {0}, it costs on average {1:n}", printerStore.GetType().Name, printerStore.TotalCost / printerStore.Printers.Count);
            Console.Read();
        }
    }

}
