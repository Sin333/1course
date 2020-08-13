using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._12._15_Замена_символа_в_слове
{
    class Program
    {
        static void Main(string[] args)
        {
            const string x = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            const string p = "0123456789";
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            string[] words = str.Split(new Char[] { ' ', '\t', ',', '.', '!', '?' });
            int cntWords = words.Length;
            int[] counters = new int[cntWords];
            for (int i = 0; i < cntWords; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (x.IndexOf(words[i][j]) != -1)
                    {
                        Console.Write(words[i][j]);
                    }
                    if (p.IndexOf(words[i][j]) != -1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
            }
            Console.ReadKey();
        }
    }
}