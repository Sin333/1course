using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmTEST
{
    //Элемент
    class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode back;
        public ListNode(int _value)
        {
            this.value = _value;
        }
        public ListNode()
        {

        }
    }
    //Список
    class List
    {
        public ListNode begin;
        public List()
        {

        }
        public List(int _value)
        {
            begin = new ListNode();
            begin.value = _value;
        }
        //Method

        //Empty
        public bool Empty()
        {
            if (begin == null)
            {
                Console.Write("Error! This List is Empty: ");
                return true;
            }
            else
                return false;
        }

        //Print
        public void Print()
        {
            if(!Empty())
            {
                ListNode tmp = begin;
                while(tmp!=null)
                {
                    Console.Write(tmp.value);
                    tmp = tmp.next;
                }
                Console.WriteLine();
            }
        }

        //InsertBegin
        public void InsertBegin(int k)
        {
            ListNode tmp = begin;
            if(Empty())
            {
                begin.value = k;
            }
            else
            {
                tmp.value = begin.value;
                tmp.next = begin.next;
                begin.value = k;
                begin.next = tmp;
            }
        }
    }
}
