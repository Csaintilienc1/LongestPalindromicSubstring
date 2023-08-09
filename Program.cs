using System;

namespace LongestPalindromicSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            longestPalindromicSubstring test = new();

            Console.WriteLine(test.longestPalSubstring("abbabbaaba"));

        }
    }
}
