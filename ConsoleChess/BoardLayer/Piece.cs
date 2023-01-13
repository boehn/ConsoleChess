namespace ConsoleChess.BoardLayer
{
    public abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovesMade { get; protected set; }
        public Board Board { get; protected set; }

        public Piece( BoardLayer.Board board, Color color)
        {
            Board = board;
            Color = color;
        }

        public void IncrementMovesMade()
        {
            MovesMade++;
        }
        
        public void DecrementMovesMade()
        {
            MovesMade--;
        }
        
        public bool PossibleMovesExist() {
            var arr = PossibleMoves();
            for (var i = 0; i < Board.Lines; i++) {
                for (var j = 0; j < Board.Columns; j++) {
                    if (arr[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PossibleMove(Position position) {
            return PossibleMoves()[position.Line , position.Column];
        }

        public abstract bool[,] PossibleMoves();
    }
}