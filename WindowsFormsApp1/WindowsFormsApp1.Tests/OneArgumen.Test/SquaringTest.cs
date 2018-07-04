using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests.OneArgumen.Test
{
    class SquaringTest
    {
        [TestFixture]
        public class TestClass
        {

            [Test]
            public void TestMetod()
            {
                IOneArgumentCalculate calculator = new Squaring();
                double result = calculator.Calculate(4);

                Assert.AreEqual(16, result);
            }
        }
    }

}
