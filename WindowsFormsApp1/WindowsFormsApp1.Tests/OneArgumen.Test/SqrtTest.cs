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

            [Test]
            public void TestMetod()
            {
                IOneArgumentCalculate calculator = new Sqrt();
                double result = calculator.Calculate(4);

                Assert.AreEqual(2, result);
            }
        }
    }

}
