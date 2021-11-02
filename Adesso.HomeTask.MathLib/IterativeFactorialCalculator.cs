using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.HomeTask.MathLib
{
    public class IterativeFactorialCalculator : IFactorialCalculator
    {
        public BigInteger CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("can't calculate factorial of a negative value");
            BigInteger result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public BigInteger CalculateDoubleFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("can't calculate factorial of a negative value");
            BigInteger result = 1;            
            for (int i = number % 2 == 0 ? 2 : 3; i <= number; i+=2)
            {
                result *= i;
            }
            return result;
        }
    }
}
