using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{ 
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        { 
            var result = _math.Add(1, 3);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {  
            var result = _math.Max(5, 3);

            Assert.That(result,  Is.EqualTo(5));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {  
            var result = _math.Max(4, 8);

            Assert.That(result, Is.EqualTo(8));
        }


        [Test]
        public void Max_ArgumentAreEqual_ReturnTheSameArgument()
        { 
            var result = _math.Max(4, 4);

            Assert.That(result, Is.EqualTo(4));
        }

    }
}
