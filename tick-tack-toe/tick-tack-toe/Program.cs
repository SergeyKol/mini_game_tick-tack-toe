using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tick_tack_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int move = Move.get_move();
            //ConsoleKeyInfo move1 = Console.ReadKey();
            Console.WriteLine("\nЗначение которое вы ввели "+ move);
            Console.ReadLine();
        }
    }
}
