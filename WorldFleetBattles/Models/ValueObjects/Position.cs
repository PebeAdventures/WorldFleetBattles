using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFleetBattles.Models.ValueObjects
{
    public readonly struct Position : IEquatable<Position>
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";

        public override bool Equals(object? obj)
            => obj is Position other && Equals(other);

        public bool Equals(Position other)
            => X == other.X && Y == other.Y;

        public override int GetHashCode()
            => HashCode.Combine(X, Y);

        public static bool operator ==(Position left, Position right)
            => left.Equals(right);

        public static bool operator !=(Position left, Position right)
            => !left.Equals(right);
    }
}
