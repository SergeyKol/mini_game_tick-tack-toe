using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tick_tack_toe
{
    class WinGame
    {
        public bool Flag = false;

        public void wingame(char[] args)
        {
            if (//горизонтальные линии
                (args[6] == 'X' && args[7] == 'X' && args[8] == 'X') || 
                (args[3] == 'X' && args[4] == 'X' && args[5] == 'X') || 
                (args[0] == 'X' && args[1] == 'X' && args[2] == 'X') ||
                //вертикальные линии
                (args[0] == 'X' && args[3] == 'X' && args[6] == 'X') ||
                (args[1] == 'X' && args[4] == 'X' && args[7] == 'X') ||
                (args[2] == 'X' && args[5] == 'X' && args[8] == 'X') ||
                //диагонали
                (args[6] == 'X' && args[4] == 'X' && args[2] == 'X') ||
                (args[0] == 'X' && args[4] == 'X' && args[8] == 'X') 
               )
            {
                Console.WriteLine("\nВыиграли Х");
                Flag = true;
            }
            else if (//горизонтальные линии
                     (args[6] == 'O' && args[7] == 'O' && args[8] == 'O') ||
                     (args[3] == 'O' && args[4] == 'O' && args[5] == 'O') ||
                     (args[0] == 'O' && args[1] == 'O' && args[2] == 'O') ||
                     //вертикальные линии
                     (args[0] == 'O' && args[3] == 'O' && args[6] == 'O') ||
                     (args[1] == 'O' && args[4] == 'O' && args[7] == 'O') ||
                     (args[2] == 'O' && args[5] == 'O' && args[8] == 'O') ||
                     //диагонали
                     (args[6] == 'O' && args[4] == 'O' && args[2] == 'O') ||
                     (args[0] == 'O' && args[4] == 'O' && args[8] == 'O')
                    )
            {
                Console.WriteLine("\nВыиграли O");
                Flag = true;
            }

        }
    }
}
