using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, max, x = 0;
            int[,] a = new int[4, 4];
            int[] b = new int[5];
            Random rnd = new Random();
            Console.WriteLine("Исходный массив 4x4 : ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                    Console.Write(a[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Максимальные Числа в строках: ");
            max = a[0, 0];
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
                b[i] = max;
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Программу выполнил: Ермошин Илья");
            Console.ReadKey();
        }
    }
}