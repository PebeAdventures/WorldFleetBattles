using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.ValueObjects;

namespace WorldFleetBattles.Models.GameBoard
{
    public class Ship
    {
        public List<Position> OccupiedPositions { get; }
        public HashSet<Position> HitPositions { get; }

        public Ship(List<Position> positions)
        {
            OccupiedPositions = positions;
            HitPositions = new HashSet<Position>();
        }

        public bool RegisterHit(Position position)
        {
            if (OccupiedPositions.Contains(position))
            {
                HitPositions.Add(position);
                return true;
            }
            return false;
        }

        public bool IsSunk => OccupiedPositions.All(occupiedPositions => HitPositions.Contains(occupiedPositions));
    }
}
