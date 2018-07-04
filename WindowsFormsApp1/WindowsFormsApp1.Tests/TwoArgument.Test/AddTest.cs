using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.TwoArgument.Test
{
    class AddTest
    {
        [TestFixture]
        public class TestClass
        {
            [Test]
            public void TestMetod()
            {
                ITwoArgumentsCalculate calculator = new AddCalculator();
                double result = calculator.Calculate(1, 1);

                Assert.AreEqual(2,result);
            }
        
        }

    }
}
