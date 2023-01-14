using System.Collections.Generic;
using ConsoleChess.BoardLayer;
using ConsoleChess.BoardLayer.CustomExceptions;

namespace ConsoleChess.GameLayer
{
    public class ChessMatch
    {
        public Board Board { get; private set; } = new Board(8, 8);
        public int Turn { get; private set; } = 1;
        public Color CurrentPlayer { get; private set; } = Color.White;
        public bool Finished { get; private set; } = false;
        private HashSet<Piece> _pieces = new HashSet<Piece>();

        public ChessMatch()
        {
            InsertPieces();
        }
        
        private void ExecuteMove(Position origin, Position destiny)
        {
            var piece = Board.RemovePiece(origin);
            piece.IncrementMovesMade();
            var capturedPiece = Board.RemovePiece(destiny);
            Board.InsertPiece(piece, destiny);
        }

        public void PerformsMove(Position origin, Position destiny)
        {
            ExecuteMove(origin, destiny);
            Turn++;
            ChangePlayer();
        }

        public void ValidateOriginPosition(Position origin)
        {
            if (Board.Piece(origin) == null)
            {
                throw new BoardException("There is no piece in this position");
            }

            if (CurrentPlayer != Board.Piece(origin).Color)
            {
                throw new BoardException("This is not your piece");
            }

            if (!Board.Piece(origin).PossibleMovesExist())
            {
                throw new BoardException("There is not possible moves for you chosen piece");
            }
        }

        public void ValidateDestinyPosition(Position origin, Position destiny)
        {
            if (!Board.Piece(origin).PossibleMove(destiny))
            {
                throw new BoardException("Destiny position is invalid");
            }
        }
        
        private void ChangePlayer()
        {
            CurrentPlayer = CurrentPlayer == Color.White ? Color.Black : Color.White;
        }
        
        private Color AdversaryColor(Color color)
        {
            return color == Color.White ? Color.Black : Color.White;
        }

        private void InsertNewPiece(char column, int line, Piece piece) {
            Board.InsertPiece(piece, new ChessPosition(column, line).ToPosition());
            _pieces.Add(piece);
        }

        private void InsertPieces()
        {
            InsertNewPiece('a', 1, new Rook(Board, Color.White));
            InsertNewPiece('e', 1, new King(Board, Color.White));
            InsertNewPiece('h', 1, new Rook(Board, Color.White));

            InsertNewPiece('a', 8, new Rook(Board, Color.Black));
            InsertNewPiece('e', 8, new King(Board, Color.Black));
            InsertNewPiece('h', 8, new Rook(Board, Color.Black));
        }
    }
}