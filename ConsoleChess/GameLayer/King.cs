using ConsoleChess.BoardLayer;

namespace ConsoleChess.GameLayer
{
    public class King : Piece
    {
        private ChessMatch _chessMatch;
        public King(Board board, Color color) : base(board, color)
        {
            
        }

        public override string ToString()
        {
            return "K";
        }

        private bool ValidMove(Position position)
        {
            var piece = Board.Piece(position);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            var arr = new bool[Board.Lines, Board.Columns];

            var position = new Position(0, 0);
            
            // above

            position.SetValues(position.Line - 1, position.Column);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // ne
            position.SetValues(position.Line - 1, position.Column + 1);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // right
            position.SetValues(position.Line, position.Column + 1);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // se
            position.SetValues(position.Line + 1, position.Column + 1);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // bellow
            position.SetValues(position.Line + 1, position.Column);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // so
            position.SetValues(position.Line + 1, position.Column - 1);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // left
            position.SetValues(position.Line, position.Column - 1);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            
            // no
            position.SetValues(position.Line - 1, position.Column - 1);
            if (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
            }
            return arr;
        }
    }
}