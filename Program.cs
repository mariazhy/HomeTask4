using System;
using System.Text.RegularExpressions;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a word:");
            string word = Console.ReadLine();
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            string wordReversed = new String(array);
            if (word == wordReversed)
            {
                Console.WriteLine("Your word is palindrome");
            }
            else Console.WriteLine("Your word is not palindrome");
        }
    }
}

