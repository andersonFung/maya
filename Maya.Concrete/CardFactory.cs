using Maya.Common.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Common.Cards;
using Maya.Common.Repositories;

namespace Maya.Concrete
{
    public abstract class CardFactory : ICardFactory
    {
        protected ICardRepository cardRepository;
        public CardFactory(ICardRepository repository) {
            this.cardRepository = repository;
        }

        public ICollection<ICard> DealCard(int limit) {
            ICollection<ICard> cards = cardRepository.Get();
            return cards;
        }

        
    }
}
