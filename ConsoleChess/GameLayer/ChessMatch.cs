using ConsoleChess.BoardLayer;

namespace ConsoleChess.GameLayer
{
    public class ChessMatch
    {
        public Board Board { get; private set; } = new Board(8, 8);
        private int _shift = 1;
        private Color _currentPlayer = Color.White;
        public bool Finished { get; private set; } = false;

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

        private void InsertPieces()
        {
            Board.InsertPiece(new Rook(Board, Color.White), new ChessPosition('c',1).ToPosition());
        }
    }
}