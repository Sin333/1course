using System;
namespace Search_max_слова
{
    class Program
    {
        public static int strCount(string str,string search)
        {
            int result=0;
            for (int i = 0; i < search.Length; i++)
            {
                if (str.Contains(search[i].ToString()))
                {
                    
                    result += str.Split(search[i]).Length -1;
                };
            }
            return result;
        }
        public static void Main(string[] args)
        {
            string str;
            Console.Write("Введите строку");
            str = Console.ReadLine();
            int result= strCount(str, " .,?!';:");
            Console.WriteLine(result);
                Console.ReadKey();
        }
    }
}