using System;
namespace While_DO
{
    class Program
    {
        static void Main()
        {
            int i=0,j=0, c=0;
            int[,]a= new int [4,4];
            Random rnd = new Random();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a[i,j] = rnd.Next(0,9);
                }
            }
            Console.Write("Исходная матрица: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                    Console.Write("    " + a[i, j]);
            }
                do
                {
                if (i > 3)
                {
                    break;
                }
                c = c + a[i, j];
                    i++;
                    j++;
55666
                }
                while (i<4 && j<4);
            Console.WriteLine();
            Console.WriteLine("Сумма диагонали матрицы равна: " + c);
            Console.ReadKey();
        }
    }
}
