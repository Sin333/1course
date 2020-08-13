using System;


namespace massiv
{
    class Program
    {
        static void Main()
        {
            //int[] a;
            //int b = 0, o, i, Max = 0;
            //Random rnd = new Random();
            //a = new int[20];
            //for (i = 1; i < 20; i++)
            //{
            //    a[i] = rnd.Next(20) - 5;

            //    if (a[i] > Max)
            //    {
            //        Max = a[i];
            //    }
            //    Console.WriteLine(a[i]);
            //    b = a[i] - Max;
            //}
            //Console.WriteLine("Max значение ={0}", Max);
            //Console.WriteLine("Отклонение от Max ={0}", b);
            //Console.WriteLine("-----------");
            int[,] a = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = rnd.Next(0, 9);
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(a[9,0]);
            Console.WriteLine(a[9,8]);
            Console.ReadKey();
        }
    }
}