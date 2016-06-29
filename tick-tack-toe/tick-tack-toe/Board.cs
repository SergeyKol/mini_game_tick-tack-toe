using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tick_tack_toe
{
    class Board
    {
        public void print_board(char[] args) 
        {
            //вывод текущего состояния игрового поля
            Console.WriteLine("\nТекущие состояние игрового поля: \n");
            Console.WriteLine("-" + args[6] + "-|-" + args[7] + "-|-" + args[8] + "-");
            Console.WriteLine("-" + args[3] + "-|-" + args[4] + "-|-" + args[5] + "-");
            Console.WriteLine("-" + args[0] + "-|-" + args[1] + "-|-" + args[2] + "-");
        }
    }
}
