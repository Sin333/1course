using System;

namespace Homework2
{
    class Program
    {
        static void Main()
        {
            int x, i, j;
            int[] a = new int[20];
            Random rnd = new Random();
            for (i = 0; i < 20; i++)
            {
                a[i] = rnd.Next(0001,9999);
            }
            Console.WriteLine();
            Console.Write("Массив порядке возрастания:");
            for (i = 0; i < 20; i++)
            {
                    for (j = i + 1; j < 20; j++)
                    {
                        if (a[i] > a[j] && a[i]!=0024)
                        {
                            x = a[i];
                            a[i] = a[j];
                            a[j] = x;
                        }
                    }
                    Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Программу сделал: Ермошин Илья");
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
