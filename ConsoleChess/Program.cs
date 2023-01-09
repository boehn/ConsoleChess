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
            try
            {
                var board = new Board(8, 8);
                board.InsertPiece(new Rook(board, Color.Black), 
                    new Position(1,3));
                board.InsertPiece(new King(board, Color.Black), 
                    new Position(1,3));
            
                Screen.PrintBoard(board);
                
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}