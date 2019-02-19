using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    public class Game
    {
        public Game()
        {
            GameSeries = new List<GameSerie>();
        }

        public DateTime TimeStamp { get; set; }
        public Member Player1 { get; set; }
        public Member Player2 { get; set; }
        public List<GameSerie> GameSeries { get; set; }

        public Member GetWinnerOfGame()
        {
            var sumPlayer1 = GameSeries.Sum(g => g.ScorePlayer1);
            var sumPlayer2 = GameSeries.Sum(g => g.ScorePlayer2);

            if (sumPlayer1 > sumPlayer2)
            {
                Console.WriteLine("Winner is " + Player1.Name);
                return Player1;
            }
            else if(sumPlayer2 > sumPlayer1)
            {
                Console.WriteLine("Winner is " + Player2.Name);
                return Player2;
            }
            else
            {
                Console.WriteLine("No winner");
                return null;
            }
        }
        /*
         METODER:
            - RegisterSerie()
            - GetWinnerOfGame()

            1.GetWinnerOfGame():
                    - Kan bara få vinnaren om man kört 3gånger
                    - Loopa igenom alla serier och få fram summan
                    - Jämför sen totalen och få ut vinnaren
                            - Oavgjort(????)

        KONSTRUKTOR + PROPERTIES
            - Ex varje Game har en lista med serier GameSerie
        */
    }
}
