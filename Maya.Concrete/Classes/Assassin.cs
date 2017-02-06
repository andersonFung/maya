using Maya.Common.Cards;
using Maya.Common.Classes;
using System;
using System.Collections.Generic;
using Maya.Common.Enums;
using Maya.Common.Actions;

namespace Maya.Concrete.Classes
{
    public class Assassin : Player, IActionable
    {
        public Assassin(PlayerTypes playerType, ControlTypes controlType) : base(playerType, controlType) {
            
        }

      

        public void attack(IAttack attack)
        {
            return;
        }

        public void defend()
        {
            throw new NotImplementedException();
        }


        public void getCards(ICollection<ICard> cards)
        {
            throw new NotImplementedException();
        }
    }
}
