using Maya.Common.Actions;
using Maya.Common.Cards;
using Maya.Common.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Concrete.Attacks
{
    public class CardAttack : IAttack
    {
        public Player origin;
        public ICollection<ICard> cards;
        public ICollection<Player> allies;
        public Player target;

        public CardAttack(Player origin, ICollection<ICard> cards, Player target)
        {
            this.origin = origin;
            this.cards = cards;
            this.target = target;
        }
        public CardAttack(Player origin, ICollection<ICard> cards, Player target, ICollection<Player> allies) : this(origin, cards,target)  {
            this.allies = allies;
        }

        
    }
}
