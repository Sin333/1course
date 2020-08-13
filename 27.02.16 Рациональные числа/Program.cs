using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._16_Рациональные_числа
{
    class Rational
    {
        public int Num, Den;
        public Rational(int _num, int _den)
        {
            Num = _num;
            Den = _den;
        }
        //Умножение
        public Rational Mulltiplication(Rational Mulltiplication)
        {
            // this.Num это a.Num 
            // r.Num это b.Num
            int Top = this.Num * r.Num;
            int Botton = this.Den * r.Den;
            return new Rational(Top, Botton);
        }
        //Сложение
        public Rational Add(Rational Add)
        {
            int Up=0;
            int Down=0;
            if (this.Den == p.Den)
            {
                Up = this.Num + p.Num;
                Down = this.Den;
            }
            else
            {
                //Прировнять a.Den и b.Den
                //И Сложить дроби
            }
                return new Rational(Up, Down);
        }
        //Вычитание
        public Rational Minus(Rational Minus)
        {
            return new Rational();
        }
        //Вывод
        public void Print()
        {
            Console.WriteLine("Дробь: {0}/{1}", Num, Den);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Top1 = 5, Top2 = 7, Botton1 = 5, Botton2 = 5;
            Rational a = new Rational(Top1, Botton1);
            a.Print();
            Rational b = new Rational(Top2, Botton2);
            b.Print();

            Console.WriteLine();

            Console.WriteLine("Умножение");
            Rational Mulltiplication = a.Mulltiplication(b);
            Mulltiplication.Print();

            Console.WriteLine();

            Console.WriteLine("Сложение");
            Rational Add = a.Add(b);
            Add.Print();

            Console.WriteLine();

            Console.WriteLine("Вычитание");
            Rational Minus = a.Minus(b);
            Minus.Print();

            Console.ReadKey();
        }
    }
}