using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WPF
{
    class Program
    {
        bool Player = true; //Переменная какой игрок ходит (TRUE 1-ый игрок) (FALSE 2-ой игрок)
        int i = 0, j = 0, Ship1 = 10, Ship2 = 10, Player1 = 0, Player2 = 0; //Ship--; Player++; i,j-Dinamic
        int[,] First = new int[10, 10];  //-2-Мимо | -1-Горящий корабль | 0-Пусто | 1- Корабль 2-Корабль | 3-Корабль(3-х) | 4-Корабль(4-х) |
        int[,] Second = new int[10, 10]; //-2-Мимо | -1-Горящий корабль | 0-Пусто | 1- Корабль 2-Корабль | 3-Корабль(3-х) | 4-Корабль(4-х) |
        public int Fire1(int i, int j, bool Player) //Стрельба по кораблям(1-ый игрок)(ГОТОВО)
        {
            if (Player == false)
            {
                if (First[i, j] > 0)
                {
                    First[i, j] = -1;
                    Player1--;
                }
                if (First[i, j] == 0)
                    First[i, j] = -2;
            }
            Player = true;
            return First[i, j];
        }
        static void Main(string[] args)
        {
            Fire1(1, 1, true);
        }
    }
}
