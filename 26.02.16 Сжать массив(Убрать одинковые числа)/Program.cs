using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._16_Сжать_массив_Убрать_одинковые_числа_
{
    class Program
    {
        static void Main()
        {
            int i=0, j=0;
            int[] a = new int[] { 1, 2, 3, 3, 3, 5, 6,7,6,6,6,6,6,0 };
            while(i!=a.Length)
            {
                j = 0;
                while(j<a.Length)
                {
                    if (i != j && j+1!=a.Length)
                    {
                        if (a[i] == a[j])
                            a[j] = 0;
                    }
                    j++;
                }
                i++;
            }

            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }

                }
                Console.WriteLine(a[i]);
            }
                    Console.ReadKey();
        }
    }
}