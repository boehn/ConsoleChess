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
                    try
                    {
                        Console.Clear();
                        Screen.PrintBoard(chessMatch.Board);
                        Console.WriteLine();
                        Console.WriteLine($"Turn: {chessMatch.Turn}");
                        Console.WriteLine($"Waiting player: {chessMatch.CurrentPlayer}");
                    
                        Console.WriteLine();
                        Console.Write("Origin: ");
                        var origin = Screen.ReadPositionChess().ToPosition();
                        chessMatch.ValidateOriginPosition(origin);

                        var possibleMoves = chessMatch.Board.Piece(origin).PossibleMoves();
                    
                        Console.Clear();
                        Screen.PrintBoard(chessMatch.Board, possibleMoves);
                    
                        Console.WriteLine();
                        Console.Write("Destiny: ");
                        var destiny = Screen.ReadPositionChess().ToPosition();
                        chessMatch.ValidateDestinyPosition(origin, destiny);
                    
                        chessMatch.PerformsMove(origin, destiny);
                    }
                    catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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