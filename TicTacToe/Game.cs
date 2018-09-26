using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly Guid _gameId;
        private readonly GameBoard _board;

        public Game(Player player1, Player player2, Guid gameId)
        {
            _player1 = player1;
            _player2 = player2;
            _gameId = gameId;
            _board = new GameBoard();

        }

    }

}
