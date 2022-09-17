using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork16_09Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startText;
            Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
            startText = Console.ReadLine();

            startText = Morse.ConverToMorse.TextToMorse(startText);
            Console.WriteLine("Ваш текст в виде азбуки Морзе:\t{0}" + startText);
        }
    }
}
namespace Morse
{
    class ConverToMorse
    {
        public static string TextToMorse(string alphaText)
        {
            char[] chars = alphaText.ToLower().ToCharArray();
            string[] MassiveMorse = new string[] { "*-", "-***", "*--", "--*", "-**", };
            string[] MassiveAlphabet = new string[] { "а", "б", "в", "г", "д", };
            string BetaText;
            int count = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                foreach(string str in MassiveAlphabet )
                {
                    if (chars[i] == str[0])
                    {
                        sb.Append(MassiveMorse[count]);
                    }
                    count++;
                }
                count = 0;
            }
            return BetaText = sb.ToString();
        }
        static string MorseToText()
        {
            return "";
        }
    }
}

