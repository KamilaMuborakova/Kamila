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

            [Test]
            public void TestMetod()
            {
                ITwoArgumentsCalculate calculator = new Substract();
                double result = calculator.Calculate(2, 2);

                Assert.AreEqual(0, result);
            }
        }
    }

}
