using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.ValueObjects;

namespace WorldFleetBattles.test.Models
{
    public class PositionTests
    {
        [Fact]
        public void Constructor_ShouldAssign_X_And_Y()
        {
            int x = 1;
            int y = 2;

            var position = new Position(x, y);

            Assert.Equal(x, position.X);
            Assert.Equal(y, position.Y);
        }

        [Fact]
        public void Equals_WhenComparingEqualPositions_ShouldReturnTrue()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(1, 2);

            bool compareResult = position1.Equals(position2);
            
            Assert.True(compareResult);
        }

        [Fact]
        public void Equals_WhenComparingNotEqualsPositions_ShouldReturnFalse()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(2, 3);

            bool compareResult = position1.Equals(position2);

            Assert.False(compareResult);
        }

        [Fact]
        public void EqualityOperator_WhenComparingEqualsPositions_ShouldReturnTrue()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(1, 2);

            bool compareResult = position1 == position2;

            Assert.True(compareResult);
        }

        [Fact]
        public void EqualityOperator_WhenComparingDifferentPositions_ShouldReturnFalse()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(2, 2);

            bool compareResult = position1 == position2;

            Assert.False(compareResult);
        }

        [Fact]
        public void InequalityOperator_WhenComparingDifferentPositions_ShouldReturnTrue()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(2, 3);

            bool compareResult = position1 != position2;

            Assert.True(compareResult);
        }

        [Fact]
        public void InequalityOperator_WhenComparingEqualPositions_ShouldReturnFalse()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(1, 2);

            bool compareResult = position1 != position2;

            Assert.False(compareResult);
        }

        [Fact]

        public void Hashcode_WhenComparingEqualPositions_ShouldHaveEqualsHashcode()
        {
            var position1 = new Position(1, 2);
            var position2 = new Position(1, 2);

            int hash1 = position1.GetHashCode();
            int hash2 = position2.GetHashCode();

            Assert.Equal(hash1, hash2);
        }

        [Fact]
        public void ToString_WhenCalled_ShouldReturnFormattedString()
        {
            var position1 = new Position(1, 2);
            
            string positionAsString = "(1, 2)";

            Assert.Equal(positionAsString, position1.ToString());
        }
    }
}
