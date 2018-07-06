using NUnit.Framework;

namespace WindowsFormsApp1.Tests.TwoArgument.Test

{
    class DivideTest
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase(12, 3, 4)]
            [TestCase(8, 4, 2)]
            [TestCase(10, 2, 5)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Divide();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }

}
    