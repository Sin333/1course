using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._16_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,end=0,first,second=0;
            int[] a = new int[] {2,3,0,2,5,0,0,7,4,6,8, 2, 2, 2};
            int n = a.Length;
            for (i=0;i< n;i++)
                Console.Write(a[i]+"  ");
            for (i = 0; i < n; i++)
            {
                first = 0;
                for (j = i+1; j < n; j++)
                {
                    if (a[i] == a[j])
                        first++;
                }
                if (first > second)
                {
                    second = first;
                    end = a[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(end);
            Console.ReadKey();
        }
    }
}
