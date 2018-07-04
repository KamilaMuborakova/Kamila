using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.TwoArgument.Test
{
    class MultiplyTest
    {
        [TestFixture]
        public class TestClass
        {

            [Test]
            public void TestMetod()
            {
                ITwoArgumentsCalculate calculator = new Multiplay();
                double result = calculator.Calculate(2, 2);

                Assert.AreEqual(4, result);
            }
        }
    }

}
