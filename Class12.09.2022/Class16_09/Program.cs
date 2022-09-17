using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class16_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            int COUNTER = 0;
            Random r = new Random();
            AIGuess.RandomNuberAndHisBool rnahb = new AIGuess.RandomNuberAndHisBool();
            do
            {
                do
                {
                    Console.WriteLine("Введите число в диапазоне от 0 до 100:"); userNumber = Int32.Parse(Console.ReadLine());
                } 
                while (userNumber < 0 || userNumber > 100);
                ++COUNTER;
                rnahb = AIGuess.Guess.SimpleGues(0, 100, r, userNumber, rnahb);
                Console.WriteLine("Число {0} совпало с вашим ?{1} Попытка:{2} ",rnahb.RandomNumber, rnahb.HisBool.ToString(),COUNTER);
                Console.WriteLine("Попыток Автоподбора: {0}", AIGuess.Guess.EndlessnessGuess(0, 100, r, userNumber));
                if (rnahb.HisBool) break;
                Console.WriteLine("Нажмите Y для новой попытки, или любую другую для отмены.");

            }
            while (Console.ReadLine() == ConsoleKey.Y.ToString());

        }
    }
}

namespace AIGuess
{
    internal class Guess
    {
        public static RandomNuberAndHisBool SimpleGues(int min, int max, Random r, int userNumber, RandomNuberAndHisBool rnhab)
        {
            rnhab.RandomNumber = r.Next(min, max);
            rnhab.HisBool = (bool)(rnhab.RandomNumber == userNumber);
            return rnhab;
        }
        public static int EndlessnessGuess(int min, int max, Random r, int userNumber)
        {
            int buf = -1;
            int count = 0;
            while (buf != userNumber)
            {
                buf = r.Next(min, max);
                count++;
            }
            return count;

        }

    }
    internal class RandomNuberAndHisBool
    {
        public int RandomNumber { get; set; } = 0;
        public bool HisBool { get; set; } = false;
    }

}


