using System;
namespace _14._11._15__1_
{
    class Program
    {
        static void Main()
        {
            int i;
            int[] nums = new int[10];
            for (i = 0; i < 10; i++)
                nums[i] = i;
            while(i>5)
            {
                Console.WriteLine(5+" ");
                i--;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
