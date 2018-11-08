<<<<<<< HEAD
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
=======
﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
>>>>>>> 43667da4addc8419433d94f815557394f7a14378

namespace EM.Calc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {

<<<<<<< HEAD
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

=======
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
>>>>>>> 43667da4addc8419433d94f815557394f7a14378
    }
}
