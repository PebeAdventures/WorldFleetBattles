using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFleetBattles.Models.GameBoard
{
    public class Fleet
    {
        public List<Ship> Ships { get; }

        public Fleet(List<Ship> ships)
        {
            Ships = ships;
        }

        public bool AllShipsSunk => Ships.All(ships => ships.IsSunk);
    }
}
