using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.HomeTask.MathLib
{
    public static class FactorialCalculatorFactory
    {
        public static IFactorialCalculator GetFactorialCalculator(CalculatorOptions options)
        {
            return options.Recursive ? new RecursiveFactorialCalculator() : new IterativeFactorialCalculator();
        }
    }
}
