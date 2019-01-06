using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata;

namespace kata_tests
{
    [TestClass]
    public class Kata_tests
    {
        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual(null, Kata.Divisors(1));
            Assert.AreEqual(null, Kata.Divisors(13));

        }

        [TestMethod]
        public void SmallNumberTest()
        {
            CollectionAssert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
            CollectionAssert.AreEqual(new int[] { 2, 4, 8 }, Kata.Divisors(16));
            CollectionAssert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
            CollectionAssert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata.Divisors(24));
        }

        [TestMethod]
        public void BigNumberTest()
        {
            CollectionAssert.AreEqual(new int[] { 2, 7, 14, 83, 166, 581, 1162, 1321, 1399, 2642, 2798, 9247, 9793, 18494, 19586, 109643, 116117, 219286, 232234, 767501, 812819, 1535002, 1625638, 1848079, 3696158, 12936553, 25873106, 153390557, 306781114, 1073733899 }, Kata.Divisors(2147467798));
        }
    }
}
