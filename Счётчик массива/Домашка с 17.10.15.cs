using System;
namespace _17._10._15
{
    class Program
    {
        static void Main()
        {
            int i = 0,n=10;
            int[] a= new int[n];
            Random rnd = new Random();
            for (i = 1; i < n; i++)
            {
                a[i] = rnd.Next(1,20);
                Console.Write("{0} ",i);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
