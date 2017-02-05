using Maya.Common.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Common.Repositories
{
    public interface ICardRepository
    {
        ICollection<ICard> Get();


    }
}
