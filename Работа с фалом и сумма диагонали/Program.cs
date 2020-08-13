using System;
using System.IO;
namespace _28._11._15_Текст
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, summ = 0, n = 4;
            int[,] a = new int[n, n], z = new int[n, n];
            Random rnd = new Random();
            StreamWriter f;
            f = new StreamWriter("1.txt");
            for (i = 0; i < n; i++)
            {
                for (x = 0; x < n; x++)
                {
                    a[i, x] = rnd.Next(10);
                    f.Write(a[i, x]);
                }
                f.WriteLine();
            }
            f.Close();

            StreamReader r;
            r = new StreamReader("1.txt");
            string d, s;
            for (i = 0; i < n; i++)
            {
                d = Convert.ToString(r.ReadLine());
                for (x = 0; x != 1; x++)
                {
                    s = d.Substring(i, 1);
                    z[i, i] = Convert.ToInt32(s);
                    summ += z[i, i];
                }
            }
            Console.WriteLine("Сумма диагонали матрицы:  "+summ);
            r.Close();
            Console.ReadLine();
        }
    }
}
