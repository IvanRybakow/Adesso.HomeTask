using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.HomeTask.MathLib.Tests
{
    [TestClass]
    public class RecursiveFactorialCalculatorTests : FactorialCalculatorTests
    {
        [TestInitialize]
        public void Initialize()
        {
            calculator = new RecursiveFactorialCalculator();
        }
    }
}
