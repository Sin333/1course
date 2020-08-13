using System;
using System.IO;

namespace _11._03._16_Список_сотрудников
{
    class People
    {
        public string Name;
        public int Age;
        public int Money;
         public People(String Name_,int Age_,int Money_) // Для new People
        {
            Name = Name_;
            Age = Age_;
            Money = Money_;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter f = new StreamWriter("List.txt"))
            //{

            //}
            int i;
            People One = new People("Stive", 17, 200);
            People Two = new People("Voz", 18, 140);
            People Tree = new People("Jack", 34, 34000);
            People[] a = new People[] {One,Two,Tree};

            StreamWriter f = new StreamWriter("List.txt");
            for (i = 0; i < a.Length; i++)
            {
                People p = a[i];
                f.WriteLine(p.Name + "\t" + p.Age + "\t" + p.Money);
            }
            f.Close();
            StreamReader r = new StreamReader("List.txt");
            string str;
            int Age,Money;
            int MaxAge = 0;
            int MaxMoney=0;
            int k = 0;
            People[] Last = new People[3];
            for (i = 0; i < a.Length; i++)
            {
                str = r.ReadLine();
                string[] rtt = str.Split(new char[] { '.', ',','\t' });
                string[] sp = str.Split(new char[] { '\t' });
                Age = Convert.ToInt32(sp[1]);
                Money = Convert.ToInt32(sp[2]);
                People p = new People(sp[0], Age, Money);
                Last[i] = p;
                k += Last[i].Money;
                if (Age > MaxAge)
                    MaxAge = Age;
                if (Money > MaxMoney)
                    MaxMoney = Money;
                Console.WriteLine("{0}\t{1}\t{2}",Last[i].Name, Last[i].Age,Last[i].Money);
            }
            r.Close();
            k /= 3;
            Console.WriteLine(k);
            Console.Write("Максимальный возраст:  "+MaxAge+"\n"+"Максимальная сумма денег:  "+MaxMoney);
            Console.ReadKey();
        }
    }
}
