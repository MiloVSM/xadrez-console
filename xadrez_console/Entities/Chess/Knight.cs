﻿using GameBoard;

namespace Chess
{
    internal class Knight : Piece
    {
        public Knight(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMoves()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "C";
        }
    }
}
