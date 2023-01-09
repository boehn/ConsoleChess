using System;
using ConsoleChess.BoardLayer;
using ConsoleChess.GameLayer;

namespace ConsoleChess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var board = new Board(8, 8);
            board.InsertPiece(new Rook(board, Color.Black), 
                new Position(1,3));
            
            Screen.PrintBoard(board);
            Console.ReadLine();
        }
    }
}