using System;
using System.IO;
namespace C_14._12._15_буквы_и_цифры__в_файле_max
{
    class Program
    {
        static void Main()
        {
            const string x = "йцукенгшщзхъфывапролджэячсмитьбюqwertyuiopasdfghjklzxcvbnm";
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            string[] words = str.Split(new Char[] { ' ', '\t', ',', '.', '!', '?' });
            int cntWords = words.Length;
            int[] counters = new int[cntWords];
            StreamWriter f;
            f = new StreamWriter("1.txt");
            for (int i = 0; i < cntWords; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (x.IndexOf(words[i][j]) != -1)
                        counters[i]++;
                }
            }
            int maxletters = counters[0];
            for (int i = 1; i < cntWords; i++)
            {
                if (counters[i] > maxletters)
                {
                    maxletters = counters[i];
                }
            }
            Console.WriteLine("Слово с наибольшим количеством букв: ");
            if (maxletters == 0)
            {
                Console.WriteLine("Отсутствует");
            }
            else
            {
                for (int i = 0; i < cntWords; i++)
                {
                    if (counters[i] == maxletters)
                        f.WriteLine(words[i]);
                }
                f.Close();

            }

            Console.ReadKey();
        }
    }
}
