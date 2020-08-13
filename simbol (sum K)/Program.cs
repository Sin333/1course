using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._12._15_simbol
{
    class Program
    {
        static void Main()
        {
            int i;
            const string Rusby = "KkКк";
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            int cntWords = str.Length;
            int counters = 0;

            for(i=0;i<cntWords;i++)
            {
                if (Rusby.IndexOf(str[i]) != -1)
                    counters++;
            }
            Console.WriteLine("к встречается {0} раз ",counters);
            Console.ReadLine();
        }
    }
}
