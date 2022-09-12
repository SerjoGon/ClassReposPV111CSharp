using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASKONE 
            /* 
             Random random = new Random();
             int countOne = 0, countTwo = 0, countUniq = 0;
             int[] massive = new int[20];
             int[]uniq  = new int[20];
             for(int i = 0;i < massive.Length;i++)
             {
                 massive[i] = random.Next(100);
             }
             for(int i = 0; i < massive.Length;i++  )
             {
                 if(massive[i]%2 == 0 || massive[i] == 0) { countOne++; }
                 else { countTwo++; }
                 Console.WriteLine(massive[i]);
             }
             for(int i = 0; i < massive.Length;i++  )
             {
                 foreach(int j in massive)
                 {
                     if(i == j)
                     {
                         countUniq++;
                         if(countUniq>1)
                         {
                             countUniq = 0;
                             uniq[i] = 0;
                             break;
                         }
                         else { uniq[i] = 1; }
                     }
                 }
             }
                 Console.WriteLine("Количество четных элементов: {0}",countOne);
                 Console.WriteLine("Количество нечетных элементов: {0}",countTwo);
             for(int i = 0; i <= 20; i++) { if(uniq[i] == 1) { Console.WriteLine(i.ToString()); } } */
            #endregion

            #region TASKTWO
            /*Random random = new Random();
            int counter = 0;

            int[] massive = new int[20];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(100);
            }
            Console.WriteLine("Введите число от 0 до 1000. Будут показаны все элементы меньше вашего числа.");
            try 
            {
                string number = Console.ReadLine();
                int z = Int32.Parse(number);
                for(int i = 0; i < massive.Length; i++)
                {
                    if(massive[i] < z||massive[i] == 0)
                    {
                        counter++;
                    }
                }
            Console.WriteLine("чисел меньше {0} найдено {1} штук",number, counter);
            }
            catch (Exception)
            {
                Console.WriteLine("Только числа!");
            }*/
            #endregion
            #region TASKTREE
            int[] massive2 = new int[12] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            int counter = 0;
            string numbersText = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < massive2.Length; i++)
            {
                sb.Append(massive2[i]);
            }
            numbersText = sb.ToString();
            Console.WriteLine("Массив для поиска числового вхождения: \n" + numbersText);
            string searchText = Console.ReadLine();
            for (int i = 0; i < numbersText.Length; i++)
            {
                if (numbersText.Contains(searchText))
                {
                    int indexContain = numbersText.IndexOf(searchText);
                    counter++;
                    numbersText = numbersText.Remove(0, indexContain + 1);
                }
                else
                {
                    Console.WriteLine("Искомой подстроки не обнаружено!");
                    break;
                }
            }
            Console.WriteLine("Искомая подстрока найдена{0} раз(а) ", counter);
            #endregion
        }
    }
}
