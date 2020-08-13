using System;

namespace PapkaProg5
{
    class Program
    {
        static void Main()
        {
            int x, i, j;
            int[] a = new int[20];
            int[] z = new int[20];
            Random rnd = new Random();
            for (i = 0; i < 20; i++)
            {
                a[i] = rnd.Next(1, 200);
            }
            Console.WriteLine();
            Console.Write("Четные числа в порядке возрастания:");
            for (i = 0; i < 20; i++)
            {
                if (a[i] % 2 == 0)
                {
                    for (j = i + 1; j < 20; j++)
                    {
                        if (a[i] > a[j] && a[j] % 2 == 0)
                        {
                            x = a[i];
                            a[i] = a[j];
                            a[j] = x;
                            z[i] = 1;
                        }

                    }
                }
                else
                {
                    for (j = i + 1; j < 20; j++)
                    {
                        if (a[i] < a[j] && a[j] % 2 == 1)
                        {
                            x = a[i];
                            a[i] = a[j];
                            a[j] = x;
                            z[i] = 2;
                        }
                    }
                }


                if (z[i] == 1)
                    Console.Write(" {0}", a[i]);

            }
            Console.WriteLine();
            Console.Write("Нечетные числа в порядке убывания:");
            for (i = 0; i < 20; i++)
            {
                if (z[i] == 2)
                    Console.Write(" {0}", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Программа сделана Ермошиным Ильей");
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
