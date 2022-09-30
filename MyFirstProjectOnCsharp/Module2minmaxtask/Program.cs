using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2minmaxtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] B = new int[3, 4];
            Random random = new Random();
            int indexIminvalue = 0; int indexJminvalue = 0;
            int indexImaxvalue = 0; int indexJmaxvalue = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.Next(-10, 10);
                }
            }
            int minvalue = B[0, 0]; int maxvalue = B[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (minvalue > B[i, j]) { minvalue = B[i, j]; indexIminvalue = i; indexJminvalue = j; }
                    if (maxvalue < B[i, j]) { maxvalue = B[i, j]; indexImaxvalue = i; indexJmaxvalue = j; }
                }
            }
            Console.WriteLine($"MinValue:{ minvalue}по индексам{indexIminvalue}{indexJminvalue}");
            Console.WriteLine($"MaxValue:{ maxvalue}по индексам{indexImaxvalue}{indexJmaxvalue}");
            if (minvalue != maxvalue)
            {
                if ((indexIminvalue > indexImaxvalue && indexJminvalue > indexJmaxvalue) || (indexIminvalue > indexImaxvalue) || (indexIminvalue == indexImaxvalue && indexJminvalue > indexJmaxvalue))
                {
                    int temp = indexImaxvalue;
                    indexImaxvalue = indexIminvalue;
                    indexIminvalue = temp;
                    temp = indexJmaxvalue;
                    indexJmaxvalue = indexJminvalue;
                    indexJminvalue = temp;
                }
                if ((indexImaxvalue == indexIminvalue && indexJmaxvalue - indexJminvalue == 1) || (indexImaxvalue - indexIminvalue == 1 && indexJminvalue == 3 && indexJmaxvalue == 0))
                {
                    sum = 0;
                }
                else
                {
                    for (int i = indexIminvalue; i <= indexImaxvalue; i++)
                    {
                        if (i == indexIminvalue && indexIminvalue == indexImaxvalue)
                        {
                            for (int j = indexJminvalue + 1; j < 4; j++)
                            {
                                sum += B[i, j];
                            }
                        }
                        else if (i == indexIminvalue && indexIminvalue != indexImaxvalue)
                        {
                            for (int j = indexJminvalue + 1; j < 4; j++)
                            {
                                sum += B[i, j];
                            }
                        }
                        else if (i == indexImaxvalue)
                        {
                            for (int j = 0 + 1; j < indexJmaxvalue; j++)
                            {
                                sum += B[i, j];
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                sum += B[i, j];
                            }
                        }
                    }
                }
                Console.WriteLine($"Сумма между минимальным и максиммальным элементом: {sum} ");

            }
            else
            {
                Console.WriteLine("Чудо 12 эелементов одинаковы!");
            }
        }
    }
}
