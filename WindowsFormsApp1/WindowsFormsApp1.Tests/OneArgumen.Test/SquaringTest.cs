using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    class SquaringTest
    {
        [TestFixture]
        public class TestClass
        { 
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new AddCalculator();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }


        }
    }

}

