using System;
using System.Collections.Generic;
using BowlinghallBengan.Bowling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlinghallBengan.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlayGameShouldGiveCorrectWinner()
        {
            var game = new Game();
            var player1 = new Member("TestName1", "TestAddress1", new Membership(1, new DateTime()));
            var player2 = new Member("TestName2", "TestAddress2", new Membership(2, new DateTime()));

            game.Player1 = player1;
            game.Player2 = player2;

            game.GameSeries.Add(new GameSerie(100, 110));
            game.GameSeries.Add(new GameSerie(100, 110));

            Assert.AreEqual(player2, game.GetWinnerOfGame());
        }

        [TestMethod]
        public void NewMemberGetsAddedToMemberList()
        {
            var visitor = new Visitor("TestVisitor", "TestAddress");
            visitor.BecomeMember();

            Assert.AreEqual(1, BowlingAlley.Instance.AllMembers.Count);
        }
        [TestMethod]
        public void GetChampionOfTheYearReturnsCorrectPlayer()
        {
            var cup1 = new Cup("Cup1", DateTime.Now, DateTime.Now);
            var cup2 = new Cup("Cup2", DateTime.Now, DateTime.Now);
            var player1 = new Member("TestName1", "TestAddress1", new Membership(1, new DateTime()));
            var player2 = new Member("TestName2", "TestAddress2", new Membership(2, new DateTime()));

            var game1 = new Game { Player1 = player1, Player2 = player2, TimeStamp = DateTime.Now };
            var game2 = new Game { Player1 = player1, Player2 = player2, TimeStamp = DateTime.Now };
            var game3 = new Game { Player1 = player1, Player2 = player2, TimeStamp = DateTime.Now };
            cup1.PlayedGames.Add(game1);
            cup2.PlayedGames.Add(game2);
            cup1.PlayedGames.Add(game3);
            game1.GameSeries.Add(new GameSerie(100, 110));
            game2.GameSeries.Add(new GameSerie(100, 110));
            game3.GameSeries.Add(new GameSerie(200, 10));
            var allCups = new List<Cup>();
            allCups.Add(cup1);
            allCups.Add(cup2);
            Assert.AreEqual(player2, new ChampionOfTheYearCalculator().GetChampionOfTheYear(allCups,DateTime.Now.Year));
        }
    }


}
