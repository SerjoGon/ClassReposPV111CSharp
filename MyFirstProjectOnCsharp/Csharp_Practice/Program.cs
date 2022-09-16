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
            Random random = new Random();
            int[,] massnumbers = new int[5,5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    massnumbers[i,j] = random.Next(-100,100);
                }
            }
            int min = massnumbers[0,0];
            int max = massnumbers[0,0];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(min > massnumbers[i,j])min = massnumbers[i,j];
                    if(max < massnumbers[i,j])max = massnumbers[i,j];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (massnumbers[i, j] >= min || massnumbers[i,j]<=max)sum += massnumbers[i,j] ;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t",massnumbers[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Сумма элементов массива между минимальным и максимальным значением:{0}",sum);
        }

    }
}
