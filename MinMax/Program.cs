using System;
namespace MinMax
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int i,j=220 ,n=0,c=0;
            int[] a;
            a= new int[10];// a[i] Массив из 33 элементов
            for (i = 0; i < 10 ; i++)
            {
                a[i] = rnd.Next(220)-120;// Любое рандомное число из 220 минус -100
                if (n < a[i])
                    n = a[i];
                if (j > a[i])
                    j = a[i];
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Min= {0}", j);
            Console.WriteLine("Max={0}", n);           
            Console.WriteLine("Программа выполненна");
            Console.ReadKey();
        }
    }
}
