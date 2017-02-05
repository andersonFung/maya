using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Common.Cards;
namespace Maya.Common.Actions
{
    public interface IPlayer
    {
        void attack(IPlayer target);
        void getCards(ICollection<ICard> cards);

        void defend(IPlayer source);


        
    }
}
