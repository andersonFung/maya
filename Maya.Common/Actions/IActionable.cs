using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Common.Cards;
using Maya.Common.Classes;

namespace Maya.Common.Actions
{
    public interface IActionable
    {
        void attack(IAttack attack);
        void getCards(ICollection<ICard> cards);
        void defend();


        
    }
}
