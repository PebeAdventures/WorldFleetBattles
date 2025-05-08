using Microsoft.EntityFrameworkCore;
using WorldFleetBattles.Models.GameBoard;

namespace WorldFleetBattles.API.Data
{
    public class BattleshipContext : DbContext
    {
        public BattleshipContext(DbContextOptions<BattleshipContext> options) : base(options)
        {
        }

        public DbSet<Ship> Ships { get; set; }

    }
}
