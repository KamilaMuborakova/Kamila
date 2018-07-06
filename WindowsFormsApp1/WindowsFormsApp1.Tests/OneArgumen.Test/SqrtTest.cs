using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    class SqrtTest
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase(4, 2)]
            [TestCase(0, 0)]
            [TestCase(16, 4)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sqrt();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult);
            }


        }

    }
}