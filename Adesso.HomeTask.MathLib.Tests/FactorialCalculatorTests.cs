using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Adesso.HomeTask.MathLib.Tests
{
    public abstract class FactorialCalculatorTests
    {
        protected IFactorialCalculator calculator;

        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        public void CalculateFactorial_WithZeroAndOneInput_ReturnsOne(int input)
        {
            BigInteger result = calculator.CalculateFactorial(input);

            result.ShouldBe(1);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        public void CalculateDoubleFactorial_WithZeroAndOneInput_ReturnsOne(int input)
        {
            BigInteger result = calculator.CalculateDoubleFactorial(input);

            result.ShouldBe(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-1)]
        [DataRow(-199)]
        public void CalculateFactorial_WithNegativInput_ThrowsException(int input)
        {
            calculator.CalculateFactorial(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-1)]
        [DataRow(-199)]
        public void CalculateDoubleFactorial_WithNegativInput_ThrowsException(int input)
        {
            calculator.CalculateDoubleFactorial(input);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(100)]
        public void CalculateFactorial_WithCorrectInput_ReturnsCorrectResult(int input)
        {
            BigInteger expectedResult = Range(input, 1, -1).Aggregate(new BigInteger(1), (a, b) => a * b);

            BigInteger result = calculator.CalculateFactorial(input);

            result.ShouldBe(expectedResult);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(2000)]
        public void CalculateDoubleFactorial_WithCorrectInput_ReturnsCorrectResult(int input)
        {
            BigInteger expectedResult = Range(input, 1, -2).Aggregate(new BigInteger(1), (a, b) => a * b);

            BigInteger result = calculator.CalculateDoubleFactorial(input);

            result.ShouldBe(expectedResult);
        }

        private static IEnumerable<BigInteger> Range(int start, int finish, int step)
        {
            for (int i = start; i >= finish; i += step)
            {
                yield return i;
            }
        }
    }
    
}
