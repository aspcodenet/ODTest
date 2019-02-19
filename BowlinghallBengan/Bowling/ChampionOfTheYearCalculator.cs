using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    public class ChampionOfTheYearCalculator
    {
        protected List<Member> GetAllPlayersFromCups(List<Cup> cups)
        {
            var list = new List<Member>();
            foreach(var cup in cups)
            {
                foreach(var game in cup.PlayedGames)
                {
                    if (!list.Contains(game.Player1))
                        list.Add(game.Player1);
                    if (!list.Contains(game.Player2))
                        list.Add(game.Player2);

                }
            }
            return list;
        }


        public Member GetChampionOfTheYear(List<Cup> allCups, int year)
        {
            Member highest = null;
            float highestPercent = 0;

            foreach (var member in GetAllPlayersFromCups(allCups))
            {
                float antalMatcher = 0;
                float vinster = 0;
                float percent = 0;
                foreach(var cup in allCups)
                {
                    foreach(var game in cup.PlayedGames.Where(r=>r.TimeStamp.Year == year))
                    {
                        if(game.Player1 == member || game.Player2 == member)
                        {
                            antalMatcher++;
                            if (game.GetWinnerOfGame() == member)
                                vinster++;
                        }
                    }
                }
                percent = vinster / antalMatcher;
                if(percent > highestPercent)
                {
                    highest = member;
                    highestPercent = percent;
                }
            }
            return highest;
        }
    }
}
