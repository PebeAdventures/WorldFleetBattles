using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFleetBattles.Services.Players
{
    internal class HumanPlayer : PlayerBase
    {
        private readonly IInputProvider _input;
        public HumanPlayer(string name, IInputProvider input) : base(name)
        {
            _input = input;
        }
        public override bool TakeTurn(IPlayer opponent)
        {
            var target = _input.GetTargetPosition();
            return true;
            //return Attack(opponent, target);
        }
    }
}
