using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    class SqrtTest
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sqrt();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult);
            }


        }

    }
}