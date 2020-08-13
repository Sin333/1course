using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_14._14._15.Элементы_из_слова
{
    class Program
    {
        static void Main()
        {
            const string Rusby = "йцукенгшщзхъфывапролджэячсмитьбю.";
            string str;
            Console.Write("Введите строку");
            str = Console.ReadLine();

            string[] words = str.Split(new Char[] { ' ', '\t', ',', '.', '!', '?' });
            int cntWords = words.Length;
            int[] counters = new int[cntWords];
            for (int i = 0; i < cntWords; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                    if(Rusby.IndexOf(words[i][j]) !=-1)
                    counters[i]++;//кол-во букв
            }
            int maxletters = counters[0];
            Console.WriteLine(maxletters);
            //for(int i=1;i<cntWords;i++)
            //{
            //    if (counters[i] > maxletters)
            //        maxletters = counters[i]; //сравнение длины и буквы
            //}
            //Console.WriteLine("Слово с наибольшим кол-вом букв");
            //if(maxletters==0)
            //    Console.WriteLine("No");
            //else
            //    for(int i=0;i<cntWords;i++)
            //    {
            //        if(counters[i]==maxletters)
            //            Console.WriteLine(words[i]);
            //    }
            Console.ReadKey();
        }
    }
}
