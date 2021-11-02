using System;
using System.Numerics;

namespace Adesso.HomeTask.MathLib
{
    public interface IFactorialCalculator
    {
        BigInteger CalculateFactorial(int number);
        BigInteger CalculateDoubleFactorial(int number);
    }
}
