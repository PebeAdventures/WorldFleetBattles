using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldFleetBattles.Models.ValueObjects;

namespace WorldFleetBattles.Services
{
    internal interface IInputProvider
    {
        Position GetTargetPosition();
    }
}
