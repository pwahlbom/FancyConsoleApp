using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FancyConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tax = TaxCalculator.Calculate(345.55m);
            Console.WriteLine(tax);
            Console.ReadLine();
        }
    }
}
