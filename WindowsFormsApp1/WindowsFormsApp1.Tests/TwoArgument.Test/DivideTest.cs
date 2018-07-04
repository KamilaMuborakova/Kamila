using NUnit.Framework;

namespace WindowsFormsApp1.Tests.TwoArgument.Test

{
    class DivideTest
    { 
        [TestFixture]
        public class TestClass
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Divide();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        }
    }
   
        }
    