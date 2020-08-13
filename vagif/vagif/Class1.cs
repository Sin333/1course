using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vagif1
{
    class ListNote
    {
        public int value;
        public ListNote next;
        public ListNote(int _value)
        {
            value = _value;
        }
        public ListNote()
        {

        }
    }
    class Queue
    {
        public ListNote begin;
        //Конструкторы
        public int Peek()
        {
            if (begin != null)
                return begin.value;
            else
            {
                Console.WriteLine("Очередь пуста");
                return 0;
            }
        }//

        public int Dequeue()
        {
            ListNote tmp = begin;
            if (tmp != null)
            {
                int k = begin.value;
                begin = tmp.next;
                tmp = null;
                return k;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        }//
        public void Enqueue(int k)
        {
            ListNote end = new ListNote();
            end.value = k;

            if (Empty())
            {
                begin = end;
                return;
            }

            ListNote tmp = begin;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = end;

            //tmp.next = end;
        }
        public void Print()
        {
            ListNote current = begin;
            while (current != null)
            {
                Console.Write(current.value + "  ");
                current = current.next;
            }
            Console.WriteLine();
        }
        public bool Empty()
        {
            return begin == null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(5);
            qu.Enqueue(4);
            qu.Enqueue(6);
            qu.Print();
            //int k = qu.Peek();
            //Console.WriteLine(k);
            //k = qu.Dequeue();
            //Console.WriteLine(k);
            //qu.Print();

            Console.ReadKey();
        }
    }
}
