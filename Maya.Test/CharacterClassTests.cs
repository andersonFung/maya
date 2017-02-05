using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maya.Common.Repositories;
using Maya.Test.Repositories;

namespace Maya.Test
{
    [TestClass]
    public class CharacterClassTests
    {
        ICardRepository cardRepository;
        public CharacterClassTests() {
            cardRepository = new TestCardRepository();

        }
        [TestMethod]
        public void TestGetAllCards() {
            var cards = cardRepository.Get();
            Assert.IsTrue(cards.Count == 3);
        }
    }
}
