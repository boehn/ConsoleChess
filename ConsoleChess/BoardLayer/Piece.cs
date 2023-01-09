namespace ConsoleChess.BoardLayer
{
    public class Piece
    {
        public Position Position { get; set; } = null;
        public Color Color { get; protected set; }
        public int MovesMade { get; protected set; } = 0;
        public BoardLayer.Board Board { get; protected set; }

        public Piece( BoardLayer.Board board, Color color)
        {
            Board = board;
            Color = color;
        }

        public void IncrementMovesMade()
        {
            MovesMade++;
        }
    }
}