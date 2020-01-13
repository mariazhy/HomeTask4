using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4
{
    class PalindromeValidation
    {
       public bool CheckPalindrome(string wordValidated)
        {
            int Length = wordValidated.Length;
            for (int i = 0; i < Length / 2; i++)
            {
                if (wordValidated[i] != wordValidated[Length - i - 1])
                {
                    return false;
                }
            } 
            return true;
        }
    }
}
