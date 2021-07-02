using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("level", true)]
        [InlineData("noon", true)]
        [InlineData("danielle", false)]
        [InlineData("hey", false)]
        public void Test1(string input1, bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(input1);

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
