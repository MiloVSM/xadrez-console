﻿using GameBoard;

namespace Chess
{
    internal class Pawn : Piece
    {
        public Pawn(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMoves()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "P";
        }
    }
}

