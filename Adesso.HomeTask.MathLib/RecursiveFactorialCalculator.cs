using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.HomeTask.MathLib
{
    public class RecursiveFactorialCalculator : IFactorialCalculator
    {
        public BigInteger CalculateDoubleFactorial(int number)
        {
            if (number < 0)            
                throw new ArgumentException("can't calculate factorial of a negative value");
            if (number == 0)
                return 1;
            return number < 3 ? number : number * CalculateDoubleFactorial(number - 2);
        }

        public BigInteger CalculateFactorial(int number)
        {
            if (number < 0)            
                throw new ArgumentException("can't calculate factorial of a negative value");
            
            return number < 2 ? 1 : number * CalculateFactorial(number - 1);
        }
    }
}
