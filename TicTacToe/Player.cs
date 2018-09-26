using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public Player(string name, GameSign sign)
        {
            Name = name;
            Sign = sign;
        }

        public string Name { get; }

        public GameSign Sign { get; }
    }
}
