using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.PrinterFactoryMethod
{
    abstract class PrinterStore
    {
        public List<PrinterTypes> Printers { get;  }

        public decimal TotalCost => Printers.Sum(printer => printer.Price());

        public PrinterStore()
        {
            Printers = SelectedPrinters();
        }

        protected abstract List<PrinterTypes> SelectedPrinters();
    }


    class Kotsovolos : PrinterStore
    {
        protected override List<PrinterTypes> SelectedPrinters()
        {
            return new List<PrinterTypes>
            {
                new LEDPrinter(),
                new LEDPrinter(),
                new ThermalPrinter()
            };
        }
    }

    class Public : PrinterStore
    {
        protected override List<PrinterTypes> SelectedPrinters()
        {
            return new List<PrinterTypes>
           {
               new ThermalPrinter(),
               new PDFPrinter(),
               new LaserPrinter(),
               new LaserPrinter()
           };
        }
    }

}
