using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tick_tack_toe
{
    class Move
    {
        public static int get_move()
        {
            //подсказка пользователю, куда можно поставить свой ход.
            Console.WriteLine("Кнопки управления ходами: \n");
            Console.WriteLine("-7-|-8-|-9-");
            Console.WriteLine("-4-|-5-|-6-");
            Console.WriteLine("-1-|-2-|-3-");
            Console.WriteLine("\n");

            //вывод текущего состояния доски
            Console.WriteLine("Текущие состояние игрового поля: \n");
            Console.WriteLine("---|---|---");
            Console.WriteLine("---|---|---");
            Console.WriteLine("---|---|---");

            //ожидание и обработка ввода клавиши с клавиатуры
            Console.WriteLine("\nВаш ход:");         
            //ConsoleKeyInfo move = Console.ReadKey();
            int move = Convert.ToInt32(Console.ReadLine());

            while (move > 9 || move < 1)
            {
                Console.WriteLine("\nУкажите число от 1 до 9");
                Console.WriteLine("\nВаш ход:");
                move = Convert.ToInt32(Console.ReadLine());
            }
            return move;
        }
    }
}
