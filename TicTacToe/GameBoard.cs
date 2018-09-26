using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameBoard
    {
        private const int Size = 9;
        private readonly GameSign[] _board;

        public GameBoard()
        {
            _board = new GameSign[Size];
            
        }

        public bool IsValidMove(int position, GameSign sign) =>
            _board[position] == GameSign.Empty;

        public void MakeMove(int position, GameSign sign)
        {
            if (!IsValidMove(position, sign))
                return;
            _board[position] = sign;
        }

    }
}
