using System;

namespace massiv
{
    class Program
    {
        static void Main()
        {
            int[] a;
            int x=0, b=0, i;
            Random rnd = new Random();
            a = new int[20];
            for (i = 1; i < 20; i++)
            {
                //a[i] = rnd.Next(200) - 100;
                //if (a[i] < 0)
                //    x = x + a[i];
                //if (a[i] > 0)
                //    b = b + a[i];
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Сумма всех + чисел{0}", b);
            Console.WriteLine("Сумма всех - чисел{0}",x);
            Console.ReadKey();
        }
    }
}
