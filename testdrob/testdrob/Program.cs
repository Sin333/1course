using System;
using System.Collections.Generic;

namespace _01._09
{
    class Drob
    {
        //UP number
        public int chislitel;
        //DOWN number
        public int znamenatel;

        public Drob()
        {
            chislitel = 0;
            znamenatel = 1;
        }

        public Drob(int ch, int zn)
        {
            if (zn == 0) throw new Exception("Знаменатель равен 0");
            chislitel = ch;
            znamenatel = zn;
        }
        public override string ToString()
        {
            string s = chislitel + "/" + znamenatel;
            return s;
        }

        public static Drob Parse(string s)
        {
            string[] strs = s.Split('/');
            int ch = int.Parse(strs[0]);
            int zn = int.Parse(strs[1]);
            return new Drob(ch, zn);
        }
        //Дробь-Дробь
        public static Drob operator +(Drob a, Drob b)
        {
            Drob res = new Drob(a.chislitel * b.znamenatel + a.znamenatel * b.chislitel, a.znamenatel * b.znamenatel);
            return res;
        }

        public static Drob operator -(Drob a, Drob b)
        {
            Drob res = new Drob(a.chislitel * b.znamenatel - b.chislitel * a.znamenatel, a.znamenatel * b.znamenatel);
            return res;
        }

        public static Drob operator *(Drob a, Drob b)
        {
            if (a.chislitel != 0 && b.chislitel != 0)
            {
                Drob res = new Drob(a.chislitel * b.chislitel, a.znamenatel * b.znamenatel);
                return res;
            }
            else
            {
                Drob res = new Drob(0, 1);
                return res;
            }
        }
        public static Drob operator /(Drob a, Drob b)
        {
            if (b.chislitel != 0)
            {
                Drob res = new Drob(a.chislitel * b.znamenatel, b.chislitel * a.znamenatel);
                return res;
            }
            throw new Exception("Действие невозможно");
        }

        // Число-Дробь
        public static Drob operator +(Drob a, int b)
        {
            Drob res = new Drob(a.chislitel + b * a.znamenatel, a.znamenatel);
            return res;
        }

        public static Drob operator -(Drob a, int b)
        {
            Drob res = new Drob(a.chislitel - b * a.znamenatel, a.znamenatel);
            return res;
        }

        public static Drob operator *(Drob a, int b)
        {
            //if (b != 0 && a.chislitel != 0)
            {
                Drob res = new Drob(a.chislitel * b, a.znamenatel);
                return res;
            }

        }
        public static Drob operator /(Drob a, int b)
        {
            if (b != 0)
            {
                Drob res = new Drob(a.chislitel, a.znamenatel * b);
                return res;
            }
            throw new Exception("Действие невозможно");

        }
        //Число-Дробь
        public static Drob operator +(int a, Drob b)
        {
            Drob res = new Drob(a * b.znamenatel + b.chislitel, b.znamenatel);
            return res;
        }
        public static Drob operator -(int a, Drob b)
        {
            Drob res = new Drob(a * b.znamenatel - b.chislitel, b.znamenatel);
            return res;
        }
        public static Drob operator *(int a, Drob b)
        {
            Drob res = new Drob(a * b.chislitel, b.znamenatel);
            return res;
        }
        public static Drob operator /(int a, Drob b)
        {
            if (b.chislitel != 0)
            {
                Drob res = new Drob(a * b.znamenatel, b.chislitel);
                return res;
            }
            throw new Exception("Действие невозможно");
        }
        // Сравнение
        //д-д
        public static bool operator <(Drob a, Drob b)
        {
            if (a.chislitel * b.znamenatel < a.znamenatel * b.chislitel)
                return true;
            else return false;

        }

        public static bool operator >(Drob a, Drob b)
        {

            if (a.chislitel * b.znamenatel > a.znamenatel * b.chislitel)
                return true;
            else return false;
        }
        public static bool operator <=(Drob a, Drob b)
        {
            if (a.chislitel * b.znamenatel <= a.znamenatel * b.chislitel)
                return true;
            else return false;
        }
        public static bool operator >=(Drob a, Drob b)
        {
            if (a.chislitel * b.znamenatel >= a.znamenatel * b.chislitel)
                return true;
            else return false;
        }
        public static bool operator ==(Drob a, Drob b)
        {
            if (a.chislitel * b.znamenatel == a.znamenatel * b.chislitel)
                return true;
            else return false;
        }
        public static bool operator !=(Drob a, Drob b)
        {
            if (a.chislitel * b.znamenatel == a.znamenatel * b.chislitel)
                return false;
            else return true;
        }
        //д-ч
        public static bool operator <(Drob a, int b)
        {
            if (a.chislitel < b * a.znamenatel)
                return true;
            else return false;
        }
        public static bool operator >(Drob a, int b)
        {
            if (a.chislitel > b * a.znamenatel)
                return true;
            else return false;

        }
        public static bool operator <=(Drob a, int b)
        {
            if (a.chislitel <= b * a.znamenatel)
                return true;
            else return false;
        }
        public static bool operator >=(Drob a, int b)
        {
            if (a.chislitel <= b * a.znamenatel)
                return true;
            else return false;
        }
        public static bool operator ==(Drob a, int b)
        {
            if (a.chislitel == b * a.znamenatel)
                return true;
            else return false;
        }
        public static bool operator !=(Drob a, int b)
        {
            if (a.chislitel != b * a.znamenatel)
                return true;
            else return false;
        }
        //ч-д
        public static bool operator <(int a, Drob b)
        {
            if (a * b.znamenatel < b.chislitel)
                return true;
            else return false;
        }
        public static bool operator >(int a, Drob b)
        {
            if (a * b.znamenatel > b.chislitel)
                return true;
            else return false;
        }
        public static bool operator >=(int a, Drob b)
        {
            if (a * b.znamenatel >= b.chislitel)
                return true;
            else return false;
        }
        public static bool operator <=(int a, Drob b)
        {
            if (a * b.znamenatel <= b.chislitel)
                return true;
            else return false;
        }
        public static bool operator ==(int a, Drob b)
        {
            if (a * b.znamenatel == b.chislitel)
                return true;
            else return false;
        }
        public static bool operator !=(int a, Drob b)
        {
            if (a * b.znamenatel == b.chislitel)
                return false;
            else return true;
        }
        //Сокр. дробей
        public void NOD()
        {
            int nod;
            for (nod = chislitel; nod > 0; nod--)
            {
                if (chislitel % nod == 0)
                {
                    if (znamenatel % nod == 0)
                    {
                        //Console.WriteLine("НОД дроби: "nod);
                        break;
                    }
                }
            }
            if(nod!=1)
            {
                chislitel /= nod;
                znamenatel /= nod;
                Console.WriteLine("Сокрашение дроби удалось :)");
            }
            else
                Console.WriteLine("Сокращение дроби не удалось :(");
        }
        //Вывод дроби
        public void PrintDrob()
        {
            Console.WriteLine("Ваша дробь: "+ToString());
        }
    }
    class Program
    {
        public static void PrintList(List<Drob> DrobList)
        {
            //Проверка на пустой  список
            if (DrobList.Count == 0)
                return;
            int index = 0;
            Console.WriteLine("Размер списка: "+ DrobList.Count);
            //DrobList.Sort();
            while (index != DrobList.Count)
            {
                Console.WriteLine((index + 1) + ")" + " " + DrobList[index]);
                index++;
            }
        }
        //Cортировка
        public static void SortList(List<Drob> DrobList)
        {
            //Проверка на пустой  список
            if (DrobList.Count == 0)
                return;
            //Алгоритм Сортировки
            // {
            for (int i = 0; i < DrobList.Count; i++)
            {
                for (int j = i + 1; j < DrobList.Count; j++)
                {
                    if (Convert.ToDouble(DrobList[i].chislitel) / Convert.ToDouble(DrobList[i].znamenatel) < Convert.ToDouble(DrobList[j].chislitel) / Convert.ToDouble(DrobList[j].znamenatel))
                    {
                        Drob b = DrobList[i];
                        DrobList[i] = DrobList[j];
                        DrobList[j] = b;
                    }
                }
            }
            // }
        }

        static void Main()
        {
            //Мои дроби
            Drob a = new Drob(5, 10);
            Drob b = new Drob(23, 24);
            Drob c = new Drob(1001, 121);
            //Сокращение дробей
            a.NOD();
            a.PrintDrob();
            List<Drob> DrobList = new List<Drob>() { a, b, c };
            double ty=23;
            double tu=24;
            Console.WriteLine(ty/tu);
            Console.WriteLine("Исходный список");
            PrintList(DrobList);
            //Сортировка списка
            SortList(DrobList);
            Console.WriteLine("Отсортированный список");
            PrintList(DrobList);
            Console.ReadKey();
        }
    }
}
