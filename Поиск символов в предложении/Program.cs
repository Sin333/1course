using System;

namespace _19._12._15_поиск_символов_в_предложении
{
    class Program
    {
        static void Main(string[] args)
        {
            const string x = "АаУуОоЫыИиЭэёЁеЕ";
            string str;
            int f = 0;
            Console.WriteLine("----------------------------Добрый день!--------------------------------");
            Console.WriteLine("Эта программа высчитывает и выписывает кол-во гласных букв в предложении");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("Введите строку: ");
            str = Console.ReadLine(); //Ввод предложения
            int cntWords = str.Length;
            Console.Write("Гласные буквы: ");
            for (int i = 0; i < cntWords; i++)
            {
                if (x.IndexOf(str[i]) != -1)
                {
                    Console.Write(str[i]+" "); //Выписывание гласных букв
                    f++; //Счётчик кол-ва гласных
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество гласных букв: "+f);
            Console.ReadKey();
        }
    }
}