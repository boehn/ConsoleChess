using System;
using ConsoleChess.BoardLayer;
using ConsoleChess.BoardLayer.CustomExceptions;
using ConsoleChess.GameLayer;

namespace ConsoleChess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var position = new ChessPosition('a', 1);
            Console.WriteLine(position);
            Console.WriteLine(position.ToPosition());
            Console.ReadLine();
        }
    }
}