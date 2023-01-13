using System.Collections.Generic;
using ConsoleChess.BoardLayer;

namespace ConsoleChess.GameLayer
{
    public class ChessMatch
    {
        public Board Board { get; private set; } = new Board(8, 8);
        public int Shift { get; private set; } = 1;
        public Color CurrentPlayer { get; private set; } = Color.White;
        public bool Finished { get; private set; } = false;
        private HashSet<Piece> _pieces = new HashSet<Piece>();

        public ChessMatch()
        {
            InsertPieces();
        }
        
        public void ExecuteMove(Position origin, Position destiny)
        {
            var piece = Board.RemovePiece(origin);
            piece.IncrementMovesMade();
            var capturedPiece = Board.RemovePiece(destiny);
            Board.InsertPiece(piece, destiny);
        }
        
        
        private void ChangePlayer()
        {
            CurrentPlayer = CurrentPlayer == Color.White ? Color.Black : Color.White;
        }
        
        private Color AdversaryColor(Color color)
        {
            return color == Color.White ? Color.Black : Color.White;
        }
        
        public void InsertNewPiece(char column, int line, Piece piece) {
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