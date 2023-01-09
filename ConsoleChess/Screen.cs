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
                Console.Write($"{8 - i} ");
                for (var j = 0; j < board.Columns; j++)
                {
                    var piece = board.Piece(i, j);
                    if (piece == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(piece);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                var temp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = temp;
            }
        }
    }
}