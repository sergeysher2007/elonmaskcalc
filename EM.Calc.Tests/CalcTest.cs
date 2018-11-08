using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EM.Calc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {

            // arrange
            var calc = new Core.Calc();
            var sum = 10;

            // act
            var result = calc.Sum(new[] { 5, 3, 2 });

            // assert
            Assert.AreEqual(sum, result);
        }

        [TestMethod]
        public void TestPiu()
        {

            // arrange
            var calc = new Core.Calc();
            var piu = 30;

            // act
            var result = calc.Piu(new[] { 5d, 3, 2 });

            // assert
            Assert.AreEqual(piu, result);
        }

    }
}
