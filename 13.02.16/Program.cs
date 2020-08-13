using System;

namespace _13._02._16
{
    class Program
    {
        static void Main()
        {
            int i=0,j=1, n;
            int[] a = new int[] { 1,3,0,2,5,0,0,7,4,6,8,0,0};
            n = a.Length;
            Console.WriteLine(n);
            for (i = 0; i < n; i++)
                Console.Write(a[i]+"  ");
            Console.WriteLine();
            for (i = 0; i < n-j; i++)
            {
                // n-1*j
                if (a[i]==0)
                {
                    j++;
                    a[i] = a[n - j];
                    a[n - j] = 0;
                }
            }
            for(i=0;i< n;i++)
                Console.Write(a[i] + "  ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
