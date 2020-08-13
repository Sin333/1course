using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main()
        {
            int a,b=1, i=int.Parse(Console.ReadLine());
            for (a = 1; a <= i; a++)
            {
                b=a*b;
                Console.WriteLine("a=" + a + " b=" + b);
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
    }