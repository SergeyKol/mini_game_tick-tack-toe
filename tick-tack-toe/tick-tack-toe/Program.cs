using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tick_tack_toe
{
    class Program
    {
        char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-' };

        static void Main(string[] args)
        {
            Program array = new Program();
            Move move = new Move();
            Board board = new Board();

            for (int i = 0; i < 3; i++) //цикл количество ходов. пока 3 
            {
                //текущее состояние игрового поля
                board.print_board(array.board);
                //позиция следующего хода
                int move1 = move.get_move();
                                
                //индекс массива игрового поля
                int indexarray = move1-1;
                Console.WriteLine("\nЗначение которое вы ввели " + move1);
                array.board[indexarray] = 'X';
            }
            Console.ReadLine();
        }
    }
}
