using ConsoleChess.BoardLayer;

namespace ConsoleChess.GameLayer
{
    public class Rook : Piece
    {
        public Rook(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "R";
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
            while (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Line -= 1;
            }
            
            // bellow
            position.SetValues(position.Line + 1, position.Column);
            while (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Line += 1;
            }
            
            // right
            position.SetValues(position.Line , position.Column + 1);
            while (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Column += 1;
            }
            
            // left
            position.SetValues(position.Line , position.Column - 1);
            while (Board.IsValidPosition(position) && ValidMove(position))
            {
                arr[position.Line, position.Column] = true;
                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Column -= 1;
            }

            return arr;
        }
    }
}