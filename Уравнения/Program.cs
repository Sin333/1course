using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уравнения
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j=0, k;
            Console.WriteLine("Read to equation:");
            string equation = Console.ReadLine();
            //Console.WriteLine(equation);
            for (i = 0; i < equation.Length; i++)
            {
                if(equation[i]=='(' && equation[i+1] !=('*' | '/') )
                    j++;
                if (equation[i] == ')')
                    j--;
            }
            if(j==0)
                Console.WriteLine("В введенном уравнении скобки раставлены верно!");
            else
                Console.WriteLine("Вы неправильно раставили скобки");
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
