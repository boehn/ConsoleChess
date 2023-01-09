using System;

namespace ConsoleChess.BoardLayer.CustomExceptions
{
    public class BoardException : Exception
    {
        public BoardException(string message) : base(message)
        {
            
        }
    }
}