using System;
using Xunit;
using PalindromeExercise; //header

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
     
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hi", false)]
        [InlineData("eye", true)]
        public void Tests(string strWord, bool expected)
        {
            //Arrage
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(strWord);
            //Assert
            Assert.Equal(expected, actual);



        }
    }
}
