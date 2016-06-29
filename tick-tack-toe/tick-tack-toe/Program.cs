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
            WinGame win = new WinGame();
 
            for (int i = 0; i < 9; i++) //цикл количество ходов 9 
            {
                //текущее состояние игрового поля
                board.print_board(array.board);
                
                //следующий ход
                int move1 = move.get_move();
                //индекс массива игрового поля в которое мы запишем значение хода 
                int indexarray = move1 - 1;

                //проверка поля, на наличие ране сделаного хода
                while (array.board[indexarray] != '-')
                {
                    Console.WriteLine("\nДанное поле уже занято другим играком, сделайте другой ход:");
                    move1 = move.get_move();
                    indexarray = move1 - 1;
                }

                Console.WriteLine("\nЗначение которое вы ввели " + move1);

                //остаток от деления i на 2, если 0 то чётный ход иначе нечётный ход
                if (i % 2 == 0)
                {
                    array.board[indexarray] = 'X';
                }
                else
                {
                    array.board[indexarray] = 'O';
                }
                //проверка победы после каждого нового хода
                win.wingame(array.board);
                if ( win.Flag == true)
                {
                    break;
                }
            }            
            board.print_board(array.board);
            Console.ReadLine();
        }
    }
}
