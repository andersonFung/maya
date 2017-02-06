using Maya.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Common.Classes
{
    public class Player
    {
        protected int HitPoint { get; set; }
        protected PlayerTypes PlayerType { get;}
        protected ControlTypes ControlType { get; }

        public Player(PlayerTypes playerType, ControlTypes controlType) {
            this.PlayerType = playerType;
            this.ControlType = controlType;
        }
    }
}
