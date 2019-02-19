using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    public interface ICupWinnerCalculator
    {
        Member GetWinner(List<Game> games);
    }

    class CupWinnerCalculator : ICupWinnerCalculator
    {
        public Member GetWinner(List<Game> games)
        {
            //Debug om ni inte har 10 matcher per person så sätt till ex lägre, ex 2
            int atLeastNumberOfgames = 10;

            Member bestSoFar = null;
            double bestSnittSoFar = 0;

            HashSet<Member> participants = new HashSet<Member>();
            foreach (var game in games)
            {
                participants.Add(game.Player1);
                participants.Add(game.Player2);
            }

            foreach (Member member in participants)
            {
                var gamesForPlayer = games.Where(x => x.Player1 == member || x.Player2 == member).ToList();
                int antalMatcher = gamesForPlayer.Count();

                if (antalMatcher < atLeastNumberOfgames)
                    continue;

                int vunnaMatcher = games.Where(x => x.GetWinnerOfGame() == member).Count();
                double snitt = Convert.ToDouble(vunnaMatcher) / Convert.ToDouble(antalMatcher);
                if (snitt > bestSnittSoFar)
                {
                    bestSoFar = member;
                    bestSnittSoFar = snitt;
                }
            }
            return bestSoFar;

        }
    }
}
