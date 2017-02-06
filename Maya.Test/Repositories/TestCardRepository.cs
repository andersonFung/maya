using Maya.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Common.Cards;
using Maya.Core.Cards;

namespace Maya.Test.Repositories
{
    public class TestCardRepository : ICardRepository
    {
        private List<ICard> cards;
        public TestCardRepository()
        {
            cards = new List<ICard> {
                new RunCard(),
                new WalkCard(),
                new AttackCard()
            };
        }

        public ICollection<ICard> Get()
        {
            return this.cards;
        }


    }
}
