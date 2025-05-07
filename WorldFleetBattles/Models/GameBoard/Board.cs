using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.ValueObjects;

namespace WorldFleetBattles.Models.GameBoard
{
    public class Board
    {
        public int Size { get; }
        public Cell[,] Grid { get; }

        public Board(int size)
        {
            Size = size;
            Grid = new Cell[size, size];

            for(int x= 0; x< size; x++)
            {
                for (int y=0; y < size; y++)
                {
                    Grid[x,y] = new Cell(new Position(x,y));
                }
            }
        }
        public bool ReciveShot(Position position)
        {
            var cell = Grid[position.X, position.Y];
            cell.ReciveShot();
            if (cell.HasShipPart)
            {
                return cell.Ship!.RegisterHit(position);
            }
            return false;
        }

        public Cell GetCell(Position position)
        {
            return Grid[position.X, position.Y];
        }
    }
}
