using System;
namespace Сортировка_методом_пузырька
{
    class Program
    {
        static void Main()
        {
            int j, n=10, i, b;
            int [] a = new int[10];
            Random rnd = new Random();
            for (i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1,30);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("-----------------");
            for (j = 1; j < n; j++)
                {
                    for (i = 1; i < n - j; i++)
                        if(a[i] > a[i+1])
                        {
                            b = a[i];
                            a[i] = a[i+1];
                            a[i+1] = b;
                    }
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
