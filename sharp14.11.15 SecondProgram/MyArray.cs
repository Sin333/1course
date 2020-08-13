using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp14._11._15_SecondProgram
{
    class MyArray
    {
        public int x;
        public MyArray(int x)
        {
            this.x = x;
        }
        ~MyArray()
        {
            Console.WriteLine("Destructor: " + x);
        }
        public void Generator(int i)
        {
            MyArray c = new MyArray(i);
        }
    }
}