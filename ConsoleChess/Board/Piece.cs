namespace ConsoleChess.Board
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovesMade { get; protected set; } = 0;
        public Board Board { get; protected set; }

        public Piece(Position position, Board board, Color color)
        {
            Position = position;
            Board = board;
            Color = color;
        }
    }
}