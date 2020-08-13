using System;
namespace _10._10._15_1
{
    class Program
    {
        static void Main()
        {
            int i, j;
            int[,] a = { { 0, 2 }, { 2, 5 } };
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 2; j++)
            {
                    Console.Write(" {0} ", a[i,j] );
            }
        }
        Console.WriteLine("");
        Console.ReadKey();
        }
    }
}
