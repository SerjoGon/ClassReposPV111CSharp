using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Csharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //module2 Task2 
            #region Task2 
            Random random = new Random();
            int[,] massnumbers = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    massnumbers[i, j] = random.Next(-100, 100);
                }
            }
            int min = massnumbers[0, 0];
            int max = massnumbers[0, 0];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (min > massnumbers[i, j]) min = massnumbers[i, j];
                    if (max < massnumbers[i, j]) max = massnumbers[i, j];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (massnumbers[i, j] >= min || massnumbers[i, j] <= max) sum += massnumbers[i, j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", massnumbers[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Сумма элементов массива между минимальным и максимальным значением:{0}", sum);

            #endregion

            #region TASK3 Сaesar 's cipher
            //var cipher = new CeasarCipher();
            //Console.WriteLine("Напиши любой текст, я попробую его зашифровать!");
            //var message = Console.ReadLine();
            //Console.WriteLine("Введите ключ Шифра:");
            //var secretkey = Convert.ToInt32(Console.ReadLine());
            //var encryptedText = cipher.Encrypt(message, secretkey);
            //Console.WriteLine("Зашифрованный текст: {0}",encryptedText);
            //Console.WriteLine("Расшифрованный текст: {0}",cipher.Decrypt(encryptedText,secretkey));
            #endregion
        }

    }
    //class CeasarCipher
    //{
    //    const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    //    private string CodeEncode(string text, int k)
    //    {
    //        var fullAlphabet = alphabet + alphabet.ToLower();
    //        var LetterLength = fullAlphabet.Length;
    //        var cipherResult = "";
    //        for(int i = 0; i < text.Length; i++)
    //        {
    //            var c = text[i];
    //            var index = fullAlphabet.IndexOf(c);
    //            if(index < 0)
    //            {
    //                //если символ не знаком, оставляем его в исходном виде
    //                cipherResult += c.ToString();
    //            }
    //            else
    //            {
    //                var codeIndex = (LetterLength + index + k)%LetterLength;
    //                cipherResult += fullAlphabet[codeIndex];
    //            }
    //        }
    //        return cipherResult;
    //    }
    //    public string Encrypt(string Message, int key)
    //    {
    //        return CodeEncode(Message, key);
    //    }
    //    public string Decrypt(string encryptedMessage, int key)
    //    {
    //        return CodeEncode(encryptedMessage, -key);
    //    }
    //}
}
