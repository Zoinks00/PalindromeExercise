using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
   public class WordSmith
    {
        public bool IsAPalindrome(string strWord)
        {
            var reversed = "";// will fail if space between double quotes
           for (int x = strWord.Length -1; x >= 0; x--) //l
            {
                reversed += strWord[x]; //current position of strWord stored to reversed
            }
            if(reversed == strWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
