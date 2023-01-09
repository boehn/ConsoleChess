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
                var chessMatch = new ChessMatch();
                while (!chessMatch.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(chessMatch.Board);
                    Console.WriteLine();
                    Console.Write("Origin: ");
                    var origin = Screen.ReadPositionChess().ToPosition();
                    Console.Write("Destiny: ");
                    var destiny = Screen.ReadPositionChess().ToPosition();
                    
                    chessMatch.ExecuteMove(origin, destiny);
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}