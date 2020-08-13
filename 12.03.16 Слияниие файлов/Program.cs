using System;
using System.IO;

namespace _12._03._16_Слияниие_файлов
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum=2;
            string Name1="Вася",Name2="Петя",Name3="Толя";
            using (StreamWriter f = new StreamWriter("One.txt"))
            {
                f.WriteLine("One.txt");
                f.WriteLine(Sum);
                f.WriteLine(Name1+"\t"+Name2+"\t"+Name3);
            }
            using (StreamWriter g = new StreamWriter("Two.txt"))
            {
                g.WriteLine("Two.txt");
                g.WriteLine(Sum);
                g.WriteLine(Name3 + "\t" + Name2 + "\t" + Name1);
            }
            using (StreamWriter p = new StreamWriter("HOLO.txt"))
            {
                string str;
                using (StreamReader r1 = new StreamReader("One.txt"))
                {
                    while((str=r1.ReadLine()) !=null)
                    {
                        p.WriteLine(str);
                        Console.WriteLine(str);
                    }
                }
                using (StreamReader rr1 = new StreamReader("Two.txt"))
                {
                    while ((str = rr1.ReadLine()) != null)
                    {
                        p.WriteLine(str);
                        Console.WriteLine(str);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
