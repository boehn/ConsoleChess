using ConsoleChess.BoardLayer.CustomExceptions;

namespace ConsoleChess.BoardLayer
{
    public class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] _pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _pieces = new Piece[lines, columns];
        }

        public Piece Piece(int line, int column)
        {
            return _pieces[line, column];
        }
        
        public Piece Piece(Position position)
        {
            return _pieces[position.Line, position.Column];
        }

        public bool PieceExists(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void InsertPiece(Piece piece, Position position)
        {
            if (PieceExists(position))
            {
                throw new BoardException("There's already a piece in this position!");
            }
            _pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool IsValidPosition(Position position)
        {
            return position.Line >= 0 && position.Line < Lines && position.Column >= 0 && position.Column < Columns;
        }

        public void ValidatePosition(Position position)
        {
            if (!IsValidPosition(position))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}