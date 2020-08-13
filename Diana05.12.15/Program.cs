using System;
namespace Diana05._12._15
{
        class Complex
        {
            public int x, i, n, m, z = 1;
            public string confirm;
            public Complex(int a, int b)
            {
                Console.Write("Хотите ли вы самостоятельно внести данные для этого комплексного числа? \nПо умлочанию выражение = {0} + {1}i \n(y/n) ", a, b);
                confirm = Convert.ToString(Console.ReadLine());
                if (confirm == "y")
                {
                    Console.Write("Введите вещественную часть: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите мнимую часть: ");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                a
                else
            {
                    x = a;
                    i = b;
                }
            }

            public static Complex first = new Complex(4, 6);
            public static Complex Second = new Complex(8, 10);

            public static HyperComplex firstH = new HyperComplex(4, 6, 10);
            public static HyperComplex SecondH = new HyperComplex(8, 10, 14);

            public static void Main()
            {
                int k = 0, h = 0, v, b;
                string y;
                Console.Write("Хотите сложить комплексные числа?(y/n) ");
                y = Convert.ToString(Console.ReadLine());
                if (y == "y")
                {
                    k = first.Plus();
                    h = first.Plus();
                    Console.WriteLine("{0} + {1}i", k, h);
                }
                Console.Write("Хотите умножить комплексные числа?(y/n) ");
                y = Convert.ToString(Console.ReadLine());
                if (y == "y")
                {
                    k = first.Umnoj();
                    h = first.Umnoj();
                    Console.WriteLine("{0} + {1}i", k, h);
                }
                Console.Write("Хотите сложить гиперкомплексные числа?(y/n) ");
                y = Convert.ToString(Console.ReadLine());
                if (y == "y")
                {
                    v = firstH.PlusH();
                    b = firstH.PlusH();
                    k = firstH.PlusH();
                    Console.WriteLine("{0} + {1}i + {2}j", v, b, k);
                }
                Console.WriteLine("Всё :)");
                Console.ReadLine();
            }

            public int Plus()
            {
                if (z == 1)
                {
                    n = first.x + Second.x;
                    z = 2;
                    return n;
                }
                if (z == 2)
                {
                    m = first.i + Second.i;
                    z = 1;
                    return m;
                }
                else
                {
                    return 1;
                }
            }

            public int Umnoj()
            {
                if (z == 1)
                {
                    n = (first.x * Second.x - first.i * Second.i);
                    z = 2;
                    return n;
                }
                if (z == 2)
                {
                    m = (first.x * Second.i + Second.x * first.i);
                    z = 1;
                    return m;
                }
                else
                {
                    return 1;
                }
            }
        }

        class HyperComplex
        {
            public int x, i, h, z = 1, n, m;
            public HyperComplex(int a, int b, int c)
            {
                string confirm;
                Console.Write("Хотите ли вы самостоятельно внести данные для этого гиепркомплексного числа? \nПо умлочанию выражение = {0} + {1}i + {2}j \n(y/n) ", a, b, c);
                confirm = Convert.ToString(Console.ReadLine());
                if (confirm == "y")
                {
                    Console.Write("Введите вещественную часть: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите мнимую часть: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите гипермнимую часть: ");
                    h = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    x = a;
                    i = b;
                    h = c;
                }
            }

            public int PlusH()
            {
                if (z == 1)
                {
                    n = Complex.firstH.x + Complex.SecondH.x;
                    z = 2;
                    return n;
                }
                if (z == 2)
                {
                    m = Complex.firstH.i + Complex.SecondH.i;
                    z = 3;
                    return m;
                }
                if (z == 3)
                {
                    m = Complex.firstH.h + Complex.SecondH.h;
                    z = 1;
                    return m;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
