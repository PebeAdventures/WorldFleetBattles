using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.ValueObjects;

namespace WorldFleetBattles.Models.GameBoard
{
    public class Cell
    {
        public Position Position { get; }
        public bool HasShipPart { get; private set; }
        public bool IsHit { get; private set; }
        public Ship? Ship { get; private set; }

        public Cell(Position position)
        {
            Position = position;
        }

        public void PlaceShip(Ship ship)
        {
            Ship = ship;
            HasShipPart = true;
        }

        public void ReciveShot()
        {
            IsHit = true;
        }


    }
}
