using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    class SquaringTest
    {
        [TestFixture]
        public class TestClass
        { 
            [TestCase(2, 4)]
            [TestCase(0,0)]
            [TestCase(-3,9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new AddCalculator();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }


        }
    }

}

