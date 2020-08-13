using System;
namespace _24._10._15_Матрица_7_на_7_с_сортировкой
{
    class Program
    {
        static void Main()
        {
            int i,j;
            int[,] a = new int[7, 7];
            Random rnd = new Random();
            Console.WriteLine("------------------Добро пожаловать------------------");
            for (i=0;i<7;i++)
            {
                for(j=0;j<7;j++)
                {
                    a[i,j] = rnd.Next(1, 99);
                    //Console.Write("a[{0};{1}]= ", i, j);
                    //a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------Действие выполнено-------------------");
            Console.WriteLine("---------------------До свидания---------------------");
            Console.ReadLine();
        }
    }
}