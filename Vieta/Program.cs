using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Программа создана студентом: Илья Ермошин");
            Console.WriteLine(new string('-', 20));
            double b, c;
            int temp = 0;
            int[] x = new int[2];
            int[] a = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите значение переменной:  " + (char)(('a') + i));
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 10));

            b = (double)-a[1] / a[0];
            c = (double)a[2] / a[0];

            Console.WriteLine("x1+x2=" + b);
            Console.WriteLine("x1*x2=" + c);
            Console.WriteLine(new string('-', 10));

            for (int i = -1000; i < 1000; i++)
                for (int j = -1000; j <= i; j++)
                {
                    if (i * j == c && i + j == b)
                    {
                        Console.WriteLine("x1=" + i + "\nx2=" + j);
                        i = 1001;
                        temp = 1;
                    }
                }
            if (temp == 0)
                Console.WriteLine("Уравнение корней не имеет!");
            Console.ReadKey();
        }
    }
}
