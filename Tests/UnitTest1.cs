using System;
using NUnit.Framework;
using SVCalc;

namespace Tests
{
    public class Tests
    {
        private SVCalc.SVCalc tmp = new SVCalc.SVCalc();


        [Test]
        public void Test_smallnumber_Pass()
        {
            Assert.AreEqual(tmp.CalculateSV(1), 0.0500000007f);
        }

        [Test]
        public void Test_highnumberpass()
        {
            Assert.AreEqual(tmp.CalculateSV(10000), 2000);
        }

        [Test]
        public void Test_negative_ThrowArgumentexeption()
        {
            Assert.Throws<ArgumentException>((() => tmp.CalculateSV(-1)));
        }



    }
}