using System;
using System.Collections.Generic;
using example8.Models;

namespace example8
{
    class Program
    {
        static void Main(string[] args)
        {
            var printers = new Technics(new IPrintingDevice[]
            {
                new Printer(40),
                new LaserPrinter(25),
                new LaserPrinter(30)
            });

            
            printers.Add(new LaserPrinter(223));
            
            foreach (var printer in printers)
            {
                printer.RefillCartridge();
                printer.Print();
            }

            Console.ReadLine();
        }
    }
}