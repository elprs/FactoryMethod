using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.PrinterFactoryMethod
{
    abstract class PrinterStore
    {
        public List<Printer> Printers { get;  }

        public decimal TotalCost => Printers.Sum(printer => printer.Price());

        public PrinterStore()
        {
            Printers = SelectedPrinters();
        }

        protected abstract List<Printer> SelectedPrinters();
    }


    class Kotsovolos : PrinterStore
    {
        protected override List<Printer> SelectedPrinters()
        {
            return new List<Printer>
            {
                new LEDPrinter(),
                new LEDPrinter(),
                new ThermalPrinter()
            };
        }
    }

    class Public : PrinterStore
    {
        protected override List<Printer> SelectedPrinters()
        {
            return new List<Printer>
           {
               new ThermalPrinter(),
               new PDFPrinter(),
               new LaserPrinter(),
               new LaserPrinter()
           };
        }
    }

}
