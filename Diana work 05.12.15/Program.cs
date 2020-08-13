using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Complex
    {
        protected int real;
        protected int imaginary;
        public Complex(int a, int b)
        {
            real = a;
            imaginary = b;
        }

        public static Complex Sum(Complex a, Complex b)
        {
            int r = a.real + b.real;
            int im = a.imaginary + b.imaginary;
            return new Complex(r, im);
        }

        public static Complex Mult(Complex a, Complex b)
        {
            int r = a.real * b.real - a.imaginary * b.imaginary;
            int im = a.real * b.imaginary + a.imaginary * b.real;
            return new Complex(r, im);
        }

        public static Complex Parse(string s)
        {
            string[] numbers = s.Split(' ');
            int re = int.Parse(numbers[0]);
            int im = int.Parse(numbers[1]);
            Complex a = new Complex(re, im);
            return a;
        }

        public static bool Equals(Complex a, Complex b)
        {
            if (a.real == b.real && a.imaginary == b.imaginary)
                return true;
            else
                return false;

        }


        public static Complex operator +(Complex a, Complex b)
        {
            return Sum(a, b);
        }



        public override string ToString()
        {
            return real.ToString() + ((imaginary > 0) ? "+" : "") + imaginary + "i";
        }
    }
    class HyperComplex : Complex
    {
        int j;
        public HyperComplex(int a, int b, int c)
            : base(a, b)
        {
            j = c;
        }
        public static HyperComplex Sum(HyperComplex a, HyperComplex b)
        {
            int r = a.real + b.real;
            int im = a.imaginary + b.imaginary;
            int c = a.j + b.j;
            return new HyperComplex(r, im, c);
        }

        public override string ToString()
        {
            return real.ToString() + ((imaginary > 0) ? "+" : "") + imaginary + "i" + ((j > 0) ? "+" : "") + j + "j";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Complex a = Complex.Parse(s);
            Console.WriteLine(a);




            Complex x = new Complex(6, 3);
            Complex y = new Complex(4, 2);
            Complex sum = x + y;
            Console.WriteLine(sum);


            Complex sum = Complex.Sum(x, y);
            Console.WriteLine(sum);
            Complex mult = Complex.Mult(x, y);
            Console.WriteLine(mult);
            HyperComplex x1 = new HyperComplex(3, -5, 1);
            HyperComplex x2 = new HyperComplex(-2, 0, 7);
            HyperComplex sumh = HyperComplex.Sum(x1, x2);
            Console.WriteLine(sumh.ToString());
            Console.ReadKey();
        }
    }
}
