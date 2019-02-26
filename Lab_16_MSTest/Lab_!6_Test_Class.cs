using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_16_NUnit_XUnit_tests;

namespace Lab_16_MSTest
{
    [TestClass]
    public class Lab_16_Test_Class
    {
        [TestInitialize]
        public void initialize()
        {
            System.Console.WriteLine("Initializing Tests");
        }

        [TestMethod]
        public void TestLab16UsingMSTest()
        {
            //arrange
            var expected = 215.0;
            var instance01 = new TestMeNow();


            //act
            var actual = instance01.TestThiMethodWorks(2, 3, 3);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void cleanup()
        {
            System.Console.WriteLine("Cleaning up after tests have run");
        }
    }
}
