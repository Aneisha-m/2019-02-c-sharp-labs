using System;
using Xunit;
using Lab_16_NUnit_XUnit_tests;
namespace Lab_16_XUnit
{
    public class Lab_16_XUnit_Tests
    {
        [Fact]
        public void Lab_16_Test_Math_Power()
        {

            //arrange
            var expected = 16.0;
            var instance03 = new TestMeNow();
            //act
            var actual = instance03.TestThiMethodWorks(2,2,2);
            //assert
            Assert.Equal(expected, actual);

        }
    }
}
