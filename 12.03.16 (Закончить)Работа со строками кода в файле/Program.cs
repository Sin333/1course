using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12._03._16_Работа_со_строками_кода_в_файле
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя считывающего файла");
            string First = "Text";
            Console.WriteLine("Введите имя выводимого файла");
            string Second= "Second";
            Console.WriteLine("Введите ширину строки в файле");
            int n=10;
            using (StreamReader r1 = new StreamReader(First+".txt"))
            {
                string str;
                string[] stri = new string[n];
                using (StreamWriter r2 = new StreamWriter(Second+".txt"))
                {
                    for(int i=0;i< n;i++)
                    {
                        while ((str = r1.ReadLine()) != null)
                        {
                            //Разбить строку на слова
                            //Выводить их по (n)
                            //Не выводить пустые строки
                            r2.WriteLine(str);
                            Console.WriteLine(str);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}