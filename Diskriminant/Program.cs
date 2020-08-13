using System;
namespace Дискриминант
{
    class Program
    {
        static void Main()
        {
            double a, b, c, x1, x2, D,x;
            Console.WriteLine("Вести значение букв для вычесления формулы D = b * b - 4 * a * c;");
            Console.WriteLine("Ведите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите с");
            c = Convert.ToDouble(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D > 1)
            {
                x1 = (b + Math.Sqrt(D)) / (2 * a);
                x2 = (b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}, x2= {1}",x1,x2);
            }
            else
            {
                if (D == 0)
                {
                    x = b / (2 * a);
                Console.WriteLine("x = {0}", x);
                }
                else
                    Console.WriteLine("Корней нет"); 
            }       
            Console.ReadKey();
        }
    }
}