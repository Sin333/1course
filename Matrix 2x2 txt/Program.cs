using System;
using System.IO;

namespace Matrix_2x2_txt
{
    class Program
    {
        static void Main()
        {
            int j, i, max = 0,n = 4;
            int[,] a = new int[n, n], z = new int[n, n];
            Random rnd = new Random();
            StreamWriter f;
            f = new StreamWriter("1.txt");
            for(i=0; i< n;i++)
            {
                for(j=0;j< n;j++)
                {
                    a[i, j] = rnd.Next(-10, 10);
                    Console.Write(a[i, j] + "   ");
                    if (max<a[i,j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        a[i, j] = max;
                    }
                    f.Write(a[i, j]+"   ");
                }
                f.WriteLine();
            }
            f.Close();
            Console.WriteLine("max число равно:="+max);
            Console.ReadLine();
        }
    }
}
