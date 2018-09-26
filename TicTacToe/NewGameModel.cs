using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class NewGameModel
    {
        public string X { get; set; }
        public string O { get; set; }
        public Guid GameId { get; set; }
    }
}
