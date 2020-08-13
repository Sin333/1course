using System;
using System.IO;

namespace _21._11._15_First
{
    class Program
    {
        static void Main()
        {
            int i=4, j=4,sum=0;
            char[] Job = new char[i];
            int[,] a = new int[i, j];
            int[,] b = new int[i, j];
            Random rnd = new Random();
            Console.WriteLine("Исходный массив:");
            StreamWriter f;
            f = new StreamWriter("1.txt");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                {
                    a[i, j] = rnd.Next(0, 9);
                    if (i == j) sum += a[i, j];
                    f.Write("   "+a[i, j]);
                    Console.Write("   "+a[i,j]);
                }
            }
            f.Close();
            for(i=0; i<17; i++)
            {
                new char[i]= a[i, j];
            }
            StreamReader r;
            int read_f;
            r = new StreamReader("1.txt");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                {
                    b[i,j]=Convert.ToInt32(r.Read());
                    Console.Write("   " + a[i, j]);
                }
            }
            read_f = Convert.ToInt32(r.ReadLine());
            Console.WriteLine(read_f);
            r.Close();
            Console.WriteLine("Сумма диагонали матрицы:"+sum);
            /*         
                        StreamWriter f;
                        string[] str = new string[2];
                        f = new StreamWriter("1.txt");
                        str[0] = "Во поле береза стояла";
                        str[1] = "Во поле кудрявая стояла";
                        str[2] = "Люли-люли стояла";
                        f.WriteLine(str[0]);
                        f.WriteLine(str[1]);
                        f.WriteLine(str[2]);
                        f.Close();

                        StreamReader r;
                        string read_f;
                        r = new StreamReader("1.txt");
                        read_f = Convert.ToString(r.ReadLine());
                        Console.WriteLine(read_f);
                        r.Close();
                        */
            Console.ReadKey();
        }
    }
}
