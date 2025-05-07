using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.GameBoard;

namespace WorldFleetBattles.Services.Players
{
    internal abstract class PlayerBase : IPlayer
    {
        public string Name { get; protected set; }

        public Board Board { get; protected set; }

        public Fleet Fleet { get; protected set; }

        public PlayerBase(string name)
        {
            Name = name;
            Board = new Board();
            Fleet = new Fleet();
        }

        public bool HasLost()
        {
            throw new NotImplementedException();
        }

        public abstract bool TakeTurn(IPlayer opponent);
    }
}
