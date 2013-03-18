using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BasicNUnitTests
{
    [TestFixture]
    public class BasicNUnitTestClass
    {
        //Grundläggnde tester.
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;

            Assert.AreEqual(x, y);
        }

        //[Test]
        //public void NegativeTest()
        //{
        //    if (true)
        //        Assert.Fail("Detta är ett misslyckande, noooo!");
        //}

        [Test,ExpectedException(typeof(NotSupportedException))]
        public void ExpectedExeptionTest()
        {
            throw new NotSupportedException();
        }

        //[Test,Ignore]
        //public void NotImplementedExeption()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
