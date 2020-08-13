using System;
using System.Collections.Generic;

namespace AlgoritmTEST
{
    ////Graph
    class Graph
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 45 };
    }
    //(Точка)
    class Vertex
    {
        int weight;
        string number;
        public Vertex(string number,int weight)
        {
            this.number = number;
            this.weight = weight;
        }
    }
    //(Ребро)
    class Edge
    {
        int v1,v2,weight;
        public Edge(int v1, int v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }
    }
    class Program
    {
        //SWAP
        static void swap(ref int first_value,ref int second_value)
        {
            int tmp = first_value;
            first_value = second_value;
            second_value = tmp;
        }
        //MERGE
        static void sort_merge(int[] a)
        {
            if (a.Length > 1)
            {
                int middle = a.Length / 2;
                int[] first = new int[middle];
                int[] last = new int[a.Length - middle];
                sort_merge(first);
                sort_merge(last);
                merge(first, last, a);
            }
        }
        static void merge(int[] first,int[] last,int[] a) // :)
        {
            int temp1=0, temp2=0, temp3=0;
            while(temp1<first.Length && temp2<last.Length)
            {
                if(first[temp1]<last[temp2])
                {
                    a[temp3] = first[temp1];
                }
                else
                {
                    a[temp3] = last[temp2];
                }
                temp1++; temp2++; temp3++;
            }
            while (temp1 < first.Length)
            {
                a[temp3] = first[temp1];
                temp1++;temp3++;
            }
            while (temp2 < last.Length)
            {
                a[temp3] = last[temp2];
                temp2++;temp3++;
            }
        }
        //SHEKER
        static void sort_sheker(int[] massive)
        {
            int left = 0, right = massive.Length-1;
            bool bflag = true;
            while (left < right && bflag == true)
            {
                bflag = false;
                for (int i = left; i < right; i++)
                { //двигаемся слева направо
                    if (massive[i] > massive[i + 1])
                    {
                        swap(ref massive[i], ref massive[i + 1]);
                        bflag = true;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                { //двигаемся справа налево
                    if (massive[i - 1] > massive[i])
                    {
                        swap(ref massive[i], ref massive[i - 1]);
                        bflag = true;
                    }
                }
                left++;
            }
        }
        //COMB
        static void sort_COMB(int[] massive)
        {
            int left = 0, right = massive.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                { //двигаемся слева направо
                    if (massive[i] > massive[i + 1])
                    {
                        swap(ref massive[i], ref massive[i + 1]);
                    }
                }
                for (int i = right; i > left; i--)
                { //двигаемся справа налево
                    if (massive[i - 1] > massive[i])
                    {
                        swap(ref massive[i], ref massive[i - 1]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //SORT///////////////////////////////////////
            Console.WriteLine("------SORT------");
            int[] massive = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rnd.Next(0, 9);
                Console.Write(massive[i]+" ");
            }
            Console.WriteLine();
            //Слиянием
            //sort_merge(massive);
            //Шайкер
            sort_sheker(massive);
            //Вывод
            for (int i = 0; i < massive.Length; i++)
                Console.Write(massive[i] + "   ");
            Console.WriteLine();
            //List///////////////////////////////////////
            Console.WriteLine("------List------");
            List TestList = new List(10);
            //TestList.InsertBegin(4);
            TestList.Print();
            //END////////////////////////////////////////
            Console.ReadKey();
        }
    }
}
