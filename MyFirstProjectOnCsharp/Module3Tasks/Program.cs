using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 2 Palidrom
            string text;
            Console.WriteLine("Введите текст для проверки на полиндром");
            text = Console.ReadLine();
            if (Palindrome.PalindromeTest(text) == text) Console.WriteLine("Это Палиндром");
            else Console.WriteLine("Это не палиндром!");
            #endregion
        }
    }

    class Palindrome
    {
        public static string PalindromeTest(string text)
        {
            char[] testText = text.ToCharArray(); Array.Reverse(testText);
            string finaltext = new string( testText);
            return finaltext;
        }
    }
}
