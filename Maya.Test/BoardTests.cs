using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maya.Common.Factories;
using Maya.Concrete;
using Maya.Common.Board;
using System.Collections.Generic;
using Maya.Concrete.Classes;
using Maya.Common.Enums;
using Maya.Common.Classes;
using Maya.Concrete.Attacks;

namespace Maya.Test
{
    [TestClass]
    public class BoardTests
    {
        IBroadFactory broadFactory;
        IPlayerFactory playerFactory;
        public BoardTests() {
            broadFactory = new BroadFactory();
            playerFactory = new PlayerFactory();
        }

        [TestMethod]
        public void TestCreateBoard()
        {
            IBoard broad = broadFactory.CreateBoard();
            Assert.IsNotNull(broad);
        }

        [TestMethod]
        public void TestCreatePlayers() {
            List<Player> players = new List<Player>();

            for (int i = 0; i < 3; i++) {
                players.Add(playerFactory.Create(PlayerTypes.Player, ControlTypes.Player));
            }

            Assert.IsNotNull(players);
            //Assert.IsTrue(players.Count == 3);

        }



        [TestMethod]
        public void TestAttackPlayer() {
            var me = new Assassin(PlayerTypes.Player, ControlTypes.Player);
            var enemy = new Assassin(PlayerTypes.Enemy, ControlTypes.NPC);

            me.attack(new CardAttack(me, null, enemy));
            //me.attack(enemy);

            
        }

    }



}
