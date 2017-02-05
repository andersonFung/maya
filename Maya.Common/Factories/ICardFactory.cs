using Maya.Common.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Common.Factories
{
    public interface ICardFactory
    {
        ICollection<ICard> DealCard(int limit);
    }
}
