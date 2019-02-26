using NUnit.Framework;
using Lab_16_NUnit_XUnit_tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
     
            
        public void Lab_16_NUnit_Test_01()
        {
            //arrange
            var expected = 36.0;
            var instance02 = new TestMeNow();

            //act
            var actual = instance02.TestThiMethodWorks(2, 3, 2);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}