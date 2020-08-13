using System;

namespace _14._12._15_буквы__2
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            const int n = 50000;
            char[] massive = new char[n];
            int i, kol_b = 0;
            for(i=0;i< n;i++)
            {
                massive[i] = Convert.ToChar(rnd.Next('a', 'a' + 26));
                Console.Write(massive[i]+"   ");
            }
            for(i=0;i<n-1;i++)
                if ((massive[i] == 'c') & (massive[i + 1] == 'b'))
                    kol_b++;
            Console.Write(kol_b);
            Console.WriteLine("The end");
            Console.ReadKey();
        }
    }
}
