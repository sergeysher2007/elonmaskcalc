using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EM.Calc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {

            //arrange
            var calc = new Core.Calc();
            var sum = 10;
            var raz = 0;
            var stp = 15625;

            //act
            var result1 = calc.Sum(new[] { 5, 3, 2 });
            var result2 = calc.Raz(new[] { 5, 3, 2 });
            var result3 = calc.Stp(new[] { 5, 3, 2 });
            //assert
            Assert.AreEqual(sum, result1);
            Assert.AreEqual(raz, result2);
            Assert.AreEqual(stp, result3);

        }
    }
}
