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
            /*
            string text;
            Console.WriteLine("Введите текст для проверки на полиндром");
            text = Console.ReadLine();
            if (Palindrome.PalindromeTest(text) == text) Console.WriteLine("Это Палиндром");
            else Console.WriteLine("Это не палиндром!");
            */
            #endregion
            #region Task 6 Shop

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
    class Shop
    {
        string _nameShop;
        string _addressShop;
        string _profShop;
        string _phoneShop;
        string _emailShop;
        //GetSet Methods
        public string Name
        {
            get => _nameShop; set => _nameShop = value;
        }
        public string Address
        {
            get => _addressShop;  set => _addressShop = value;
        }
        public string ProfShop
        {
            get => _profShop; set => _profShop = value;
        }
        public string PhoneNumb
        {
            get => _phoneShop; set => _phoneShop = value;
        }
        public string EmailShop
        {
            get => _emailShop; set => _emailShop = value;
        }
        //Constructor
        public Shop(string name, string address, string profshop, string phoneshope, string email )
        {
            _nameShop = name;
            _addressShop = address;
            _profShop = profshop;
            _phoneShop = phoneshope;
            _emailShop = email;
        }

    }
}
