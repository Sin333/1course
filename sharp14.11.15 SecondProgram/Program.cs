using System;
namespace sharp14._11._15_SecondProgram
{
        class Program
    {
        static void Main()
        {
            MyArray ob = new MyArray(0);
            for(int i=1;i<1000000;i++)
            {
                ob.Generator(i);
            }
            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
