using System;
namespace _17._10._15
{
    class Program
    {
        static void Main()
        {
            int i=0, m=0, n=0;
            int []x= new int[10];
            int[] a= new int[10];
            Random rnd = new Random();
            for (i = 1; i < 10; i++)
            {
                a[i] = rnd.Next(20);
                Console.Write("{0} ",i);
                Console.WriteLine(a[i]);
               // if (i=3)
               // Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
