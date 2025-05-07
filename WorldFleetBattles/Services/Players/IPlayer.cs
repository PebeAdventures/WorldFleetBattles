using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.GameBoard;

namespace WorldFleetBattles.Services.Players
{
    public interface IPlayer
    {
        string Name { get; }
        Board Board { get; }
        Fleet Fleet { get; }

        bool TakeTurn(IPlayer opponent);

        bool HasLost();
    }
}
