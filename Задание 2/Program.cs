using System;
namespace Задание_2
{
    class Program
    {
        static void Main()
        {
            int i, j, a1 = 0;
            int[,] a = new int[4, 4];
            Random rnd = new Random();
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                    Console.Write("   " + a[i, j]);
                }
            }
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                {
                    if (a[i, j] > a1)
                    {
                        a1 = a[i, j];
                        if (j == 3)x
                        {
                            Console.WriteLine("   " + a1);
                        }
                    }
                }
                    }
            Console.ReadKey();
        }
    }
}