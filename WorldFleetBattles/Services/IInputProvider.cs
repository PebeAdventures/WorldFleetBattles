using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFleetBattles.Services
{
    internal interface IInputProvider
    {
        Position GetTargetPosition();
    }
}
