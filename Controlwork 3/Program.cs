//using System;
//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, j,r=0, sum=0,max=0,x=0;
//            int[,] a = new int[3, 3];
//            Random rnd = new Random();
//            Console.WriteLine("Исходный массив 6x6 : ");
//            for (i = 0; i < 3; i++)
//            {
//                Console.WriteLine();
//                for (j = 0; j < 3; j++)
//                {
//                    a[i, j] = rnd.Next(1, 10);
//                    Console.Write(a[i, j] + " ");
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("Максимальные Числа в столбцах: ");
//                for (j = 0; j < 3; j++)
//            {
//                max = 0;
//                sum = 0;
//                r = 0;
//                for (i = 0; i < 3; i++)
//                {
//                    x = i;
//                    for(i=0;i<3;i++)
//                    {
//                        if (max < a[i, j])
//                            max = a[i, j];
//                    }
//                    i = x;
//                    //Console.WriteLine("max" + max);
//                    if (i < 1)
//                        sum +=a[0,j]+a[1,j]+a[2,j]- max;
//                    //Console.WriteLine("sum"+sum);
//                        if (a[i, j] == max && r<1)
//                        {
//                            r+=1;
//                            if (max > sum)
//                            {
//                                Console.WriteLine("a=({0},{1})", i, j);
//                            }
//                            else
//                            {
//                                Console.WriteLine("Max a[i,j] < sum-a[i,j] столбца:" + j);
//                            }
//                        }
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Программу выполнил: Ермошин Илья");
//            Console.ReadKey();
//        }
//    }
//}
using System;
namespace ns
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3];
            int temp;
            int ji=0;
            int max;
            Random rnd = new Random();
            Console.WriteLine("Исходный массив 6x6 :\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <3; j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                    //a[i, j] = int.Parse(Console.ReadLine());
                    Console.Write(a[i, j] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                temp = 0;
                max = a[0, i];
                for (int j = 0; j < 3; j++)
                {
                    temp += a[j, i];
                    if (a[j, i] > max)
                    {
                        max = a[j, i];
                        ji= j;
                    }
                }
                if (max > temp - max)
                    Console.WriteLine("a({0}, {1})", i, ji);
                else
                    Console.Write("max a[i,j]< sum-max, Столбец:"+i + "\n");
            }
            Console.ReadKey();
        }
    }
}
