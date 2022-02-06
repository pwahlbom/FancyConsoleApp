using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class TaxCalculator
    {
        public static decimal Calculate(decimal price)
        {
            return price * 0.08m;
        }
    }
}
