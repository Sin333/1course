using System;
namespace Некит
{
    class Program
    {
        static void Main()
        {
            int i, j, s, sum = 0, n = 3, y = 0;
            int[,] a = new int[n, n];
            Random rnd = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    sum = sum + a[i, j];
                    if (i == n - 1)
                    {
                        Console.Write("sum=" + sum);
                        // for(s=0; s<n; s++) 
                        // { 
                        if (a[i, j] > sum - a[i, j])
                            y = a[i, j];
                        // } 
                        Console.WriteLine();
                        Console.WriteLine("a=({0},{1})", i, j);
                        sum = 0;
                        y = 0;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
