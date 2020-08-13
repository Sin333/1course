using System;


namespace massiv
{
    class Program
    {
        static void Main()
        {
            int[] a;
            int b = 0, i;
            Random rnd = new Random();
            a = new int[20];
            for (i = 1; i < 20; i++)
            {
                a[i] = rnd.Next(20) - 10;

                if (a[i] > 0)
                {
                    if (a[i - 1] > 0)
                        b = b + 1;
                }
                Console.WriteLine(a[i]);
            }
                Console.WriteLine("-----------");
                Console.WriteLine("Кол-во + рядом стоящих = {0}", b);
                Console.ReadKey();
            }
        }
    }