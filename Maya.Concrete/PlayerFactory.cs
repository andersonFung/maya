using Maya.Common.Factories;
using Maya.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Common.Classes;
using Maya.Common.Enums;

namespace Maya.Concrete
{
    public class PlayerFactory : IPlayerFactory
    {
        public Player Create(PlayerTypes playerType, ControlTypes controlType) {
            return new Assassin(playerType, controlType) as Player;
        }
    }
}
