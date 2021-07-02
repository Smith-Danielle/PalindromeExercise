using System;
using System.Collections.Generic;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }
        public bool IsAPalindrome(string input)
        {
            bool answer;
            var inputNew = input.ToList();
            inputNew.Reverse();
            var inputString = string.Join("", inputNew);
            Console.WriteLine(inputString);
            if (inputString == input)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }
    }
}
