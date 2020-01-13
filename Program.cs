using System;
using System.Text.RegularExpressions;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a word:");
            string newWord = Console.ReadLine();
            PalindromeValidation word = new PalindromeValidation();
            if (word.CheckPalindrome(newWord))
            {
                Console.WriteLine("Your word is palindrome");
            }
            else Console.WriteLine("Your word is not palindrome");
        }
    }
}

