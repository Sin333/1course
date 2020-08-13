using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Спиралька
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, i=0, j=0, Height=5, Length=5;
            Console.WriteLine("Введите размер длины матрицы");
            //Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер высоты матрицы");
            //Height = int.Parse(Console.ReadLine());
            int[,] a = new int[Height, Length];
            Random rnd = new Random();
            for ( i = 0; i < Height; i++)
            {
                for (j = 0; j < Length; j++)
                {
                        a[i, j] = rnd.Next(1,9);
                        Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            i = 0;j = 0;
            do
            {
                /*
                                
                */
                Console.WriteLine();
                while (i + k != Height)
                {
                    Console.Write(a[i, j] + "  ");
                    if (k % 2 == 0)
                    {
                        //Вниз
                        i++;
                        if (i == (Height- k))
                        {
                            i--;
                            j++;
                            break;
                        }
                    }
                    else
                    {
                        //Верх
                        i--;
                        //&& k==1
                        if (i == k-2)
                        {
                            i++;
                            j--;
                            break;
                        }
                    }
                }
                Console.WriteLine();
                while (j + k != Length)
                {
                    Console.Write(a[i, j] + "  ");
                    if (k % 2 == 0)
                    {
                        //Право
                        j++;
                        if (j == (Length- k))
                        {
                            j--;
                            i--;
                            break;
                        }
                    }
                    else
                    {
                        //Лево
                        j--;
                        if(j==k-1)
                        {
                            j++;
                            i++;
                            break;
                        }
                    }
                }
                k++;
                if ((i == j) && (i==((Height-1)/2)) && (j==((Length-1)/2)))
                    break;
            }
            while (i != 10);
            Console.Write(a[i, j]);
            Console.ReadKey();
        }
    }
}
