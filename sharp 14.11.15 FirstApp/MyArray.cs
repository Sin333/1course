using System;
namespace Matrix
{
    class MyArray
    {
        public int N;
        public int[,] Values;

        public void Input(int n)
        {
            N = n;
            Values = new int[N, N];
            for (int i = 0; i < Values.GetLength(0); i++)
            {
                for (int j = 0; j < Values.GetLength(1); j++)
                {
                    Values[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        //ВАЖНО!!!!
        public MyArray(int n)
        {
            N = n;
            Values = new int[N, N];
        }
        public MyArray() { }
        //КОНЕЧНО MyArray
        public void Print()
        {
            for (int i = 0; i < Values.GetLength(0); i++)
            {
                for (int j = 0; j < Values.GetLength(1); j++)
                {
                    Console.Write(Values[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public MyArray Transp()
        {
            MyArray x = new MyArray();
            x.Values = new int[Values.GetLength(1), Values.GetLength(0)];
            for (int i = 0; i < Values.GetLength(0); i++)
            {
                for (int j = 0; j < Values.GetLength(1); j++)
                {
                    x.Values[j, i] = Values[i, j];
                }
            }
            return x;
        }

        public int SumOfElements()
        {
            int sum = 0;
            for (int i = 0; i < Values.GetLength(0); i++)
            {
                for (int j = 0; j < Values.GetLength(1); j++)
                {
                    sum += Values[i, j];
                }
            }
            return sum;
        }
    }
}
