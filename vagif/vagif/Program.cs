using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vagif
{
    class QueueNote
    {
        public int value;
        public QueueNote next;
        public QueueNote(int _value)
        {
            value = _value;
        }
        public QueueNote()
        {

        }
    }

    class Queue
    {
        public QueueNote begin;
        //Конструктор
        public Queue(int value1)
        {
            begin = new QueueNote(value1);
        }
        public Queue()
        {

        }

        //Mетоды

        //Проверка на пустоту списка
        public bool Empty()
        {
            return begin == null;
        }
        //Поиск элемента
        public int Peek(int k)
        {
            if (Empty())
            {
                Console.WriteLine("Очередь пуста");
                return 0;
            }
            else
            {
                if(begin!=null)
                {

                }
                return begin.value;
            }
        }
        //Удаляет первый элемент очереди
        public void Dequeue()
        {
            if (Empty())
            {
                Console.WriteLine("Error Queue is Empty");
                return;
            }
            else
            {
                while(begin.next!=null)
                {
                    begin.value = begin.next.value;
                    begin = begin.next;
                }
            }
        }
        public bool Contains(int k)
        {
            QueueNote tmp = begin;
            while (tmp != null)
            {
                if (k == tmp.value)
                {
                    return true;
                }
                else
                    tmp = tmp.next;
            }
            return false;
        }
        //Добавляет эл-т в конец очереди
        public void Enqueue(int k)
        {
            QueueNote end = new QueueNote(k);
            if (Empty())
            {
                begin = end;
                return;
            }

            QueueNote tmp = begin;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = end;
        }
        //Вывод списка
        public void Print()
        {
            QueueNote current = begin;
            while (current != null)
            {
                Console.Write(current.value + "  ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(5);
            qu.Enqueue(4);
            //qu.Dequeue();
            qu.Enqueue(6);
            qu.Print();
            //qu.Peek(4);
            //qu.Print();

            Console.ReadKey();
        }
    }
}
