using System;
namespace Lnkr
{
    class Program
    {
        public static double Ln(double x)
        {
            return Math.Log(Math.Abs(x-2));
        }
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = Ln(Math.Abs(x-2));
            Console.WriteLine("y="+y);
            Console.ReadKey();
        }
    }
}
