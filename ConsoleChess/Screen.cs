using System;
using ConsoleChess.BoardLayer;

namespace ConsoleChess
{
    public class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (var i = 0; i < board.Lines; i++)
            {
                for (var j = 0; j < board.Columns; j++)
                {
                    var piece = board.Piece(i, j);
                    Console.Write(piece != null ? $"{piece} " : "- ");
                }
                Console.WriteLine();
            }
        }
    }
}