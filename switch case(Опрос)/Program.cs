using System;
namespace _14._11._15_switch_case
{
    class Program
    {
        static void Main()
        {
            int i=0;
            Console.WriteLine("Ответьте на вопрос и укажите номер ответ:");
            Console.WriteLine("Сколько вам лет?");
            Console.WriteLine("1) 0-7 лет");
            Console.WriteLine("2) 8-18 лет");
            Console.WriteLine("3) 19-25 лет");
            Console.WriteLine("4) 26-200 лет");
            i =int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
            {
                Console.WriteLine("Вы ходите в садик");
                break;
            }
               case 2:
            {
                Console.WriteLine("Вы ходите в школу");
                break;
            }
                case 3:
            {
                Console.WriteLine("Вы ходите в институт");
                        break;
            }
                case 4:
            {
                Console.WriteLine("Вы ходиите на работу");
                break;
            }
                default:
                    {
                        Console.WriteLine("Вы не живой");
                        break;
                    }
            }
        Console.ReadKey();
        }
        }
    }
