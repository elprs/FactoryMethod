using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSample.PrinterFactoryMethod
{
    abstract class Printer
    {
        public string PrinterBrand { get; set; }
        public abstract string Print();
        public abstract decimal Price();
    }


    class LEDPrinter : Printer
    {
        public new string PrinterBrand = "HP";
        public override string Print()
        {
            return "The LED printing is ready";
        }

        public override decimal Price()
        {
            return 30.0m;
        }
    }
    class ThermalPrinter : Printer
    {
        public new string PrinterBrand = "HP";
        public override string Print()
        {
            return "The Thermal printing is ready";
        }
        public override decimal Price()
        {
            return 50.0m;
        }
    }
    class PDFPrinter : Printer
    {
        public new string PrinterBrand = "Canon";
        public override string Print()
        {
            return "The PDF printing is ready";
        }
        public override decimal Price()
        {
            return 40.0m;
        }
    }
    class ThreeDPrinter : Printer
    {
        public new string PrinterBrand = "Brother";
        public override string Print()
        {
            return "The 3D printing is ready";
        }
        public override decimal Price()
        {
            return 100.0m;
        }
    }
    class LaserPrinter : Printer
    {
        public new string PrinterBrand = "Epson";
        public override string Print()
        {
            return "The Laser printing is ready";
        }
        public override decimal Price()
        {
            return 60.0m;
        }
    }

}
