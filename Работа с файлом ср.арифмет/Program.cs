using System;
using System.IO;

namespace Arifmet_Matrix_2x2
{
        class Program
        {
        static void Main()
        {
            int j, i, n = 4;
            double x = 0, y = 0;
            double[,] a = new double[n, n];
            Random rnd = new Random();
            StreamWriter f = new StreamWriter("1.txt");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(-10, 10);
                    f.Write(a[i, j] + "\t");
                    Console.Write(a[i, j]+"\t");
                    x += a[i, j];
                }
                f.WriteLine();
                Console.WriteLine();
            }
            f.Close();
            y = x / (n * n);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Среднее арифметическое = " + y);
            Console.WriteLine("---------------------------------------");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n;j ++)
                {
                    if (a[i, j] < 0)
                        a[i, j] = y;
                    Console.Write(a[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        }
    }
