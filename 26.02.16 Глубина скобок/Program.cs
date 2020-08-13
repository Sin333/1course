using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._16_Глубина_скобок
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j=0,max=0;
            string equation = "(())()";
            for (i = 0; i < equation.Length; i++)
            {
                if (equation[i] == '(')
                {
                    j++;
                    if(max<j)
                    max = j;
                }
                if (equation[i] == ')')
                {
                    j--;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
