using System;
using ConsoleChess.Board;

namespace ConsoleChess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var position = new Position(3, 4);

            Console.WriteLine($"Position: {position}");

        }
    }
}