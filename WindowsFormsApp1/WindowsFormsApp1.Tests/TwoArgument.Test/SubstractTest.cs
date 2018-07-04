using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.TwoArgument.Test
{
    class SubstractTest
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Substract();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }


        }
    }
    }

