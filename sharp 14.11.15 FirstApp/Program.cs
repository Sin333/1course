// out-
// ref-
using System;
namespace sharp_14._11._15_FirstApp
{
    class Program
    {
        public void Meth()
        {
            int i = 0;
            for (i = 0; i < 10; i++)
                if (i == 5)
                    return;
            Console.WriteLine(i);
        }
        public bool IsPrime(int x)
        {
            double t = Math.Sqrt(x);
            for(int i=2;i<=t; i++)
            {
                if(x%i!=0)
                {
                    return false;
                }
            }
            return true;
        }
        public int NOZ (int a,int b)
        {
            int max;
            if (IsPrime(a) || IsPrime(b))
                return 1;
            max = a < b ? a : b;  // ?-Если да, то...
            for (int i = 2; i < max / 2 + 1; i++)
            {
                if (a % i == 0 || (b % i == 0)) // ||-Или
                    return i;
            }
            return 1;
        }
        public static void Sqr(ref int i)
        {
            i = i * i;
        }
        public static int Parts(double n, out double r)
        {
            int whole = (int)n;
            r = n - whole;
            return whole;
        }

            static void Main()
        {
            /*MyArray x = new MyArray();
            x.Input(3);
            Console.WriteLine("Array");
            x.Print();

            MyArray y = x.Transp();
            y.Print();
            int sum=y.SumOfElements();
            Console>WriteLine("sum="+sum);*/
            double r;
            int p = Parts(4.6785, out r);
            Console.WriteLine("p=" + p +"   r=" + r);
            int a = 5;
            Console.WriteLine("a="+a);
            Sqr(ref a);
            Console.WriteLine("a="+a);

            MyArray x = new MyArray(6);
            //x.Values = new int[8, 8];                          // Создаст новую матрицу и удалит старную MyArray матрицу

            Console.ReadKey();
        }
        }
    }