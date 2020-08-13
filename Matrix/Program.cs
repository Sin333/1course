using System;
namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int k=0, Sum=0;
            int[,] a = new int[4, 4];
            Console.WriteLine("---------------Добро пожаловать---------------");
            Random rnd = new Random();
            for (int i = 0; i<4; i++)
            {
                Sum = 0;
                for (int j=0; j<4; j++)
                {
                        Sum += a[i, j];
                    a[i, j] = rnd.Next(1, 50);
                    Console.Write(a[i,j]+"\t");

                }
                Console.WriteLine();
                if (k < Sum)
                    k = Sum;
            }
            Console.WriteLine("Sum max=" + k + Sum);

            Console.WriteLine("---------------------До свидания---------------------");
            Console.ReadLine();
        }
    }
}