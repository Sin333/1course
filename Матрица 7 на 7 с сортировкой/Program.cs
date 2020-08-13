using System;
namespace _24._10._15_Матрица_7_на_7_с_сортировкой
{
    class Program
    {
        static void Main()
        {
            int i, j,x,y;
            int[,] a = new int[7, 7];
            Random rnd = new Random();
            Console.WriteLine("---------------Добро пожаловать---------------");
            Console.WriteLine("Исходная Матрица:");
            for(x=0;x<7;x++)
            {
                Console.WriteLine();
                for (y=0;y<7;y++)
                {
                    a[x, y] = rnd.Next(10, 99);
                    Console.Write("   " + a[x, y]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Отсортированная матрица:");
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (x = 0; x < 7; x++)
                {
                    for (j = x+1; j < 7; j++)
                    {
                        if (a[i, x] > a[i, j])
                        {
                            y = a[i, x];
                            a[i, x] = a[i, j];
                            a[i, j] = y;
                        }
                    }
                    Console.Write("   "+a[i, x]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------Действие выполнено-------------------");
            Console.WriteLine("---------------------До свидания---------------------");
            Console.ReadLine();
        }
    }
}
