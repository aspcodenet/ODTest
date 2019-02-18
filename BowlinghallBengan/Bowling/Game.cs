using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Game
    {
        public Game()
        {
            GameSeries = new List<GameSerie>();
        }

        public DateTime TimeStamp { get; set; }
        public Member Player1 { get; set; }
        public Member Player2 { get; set; }
        public List<GameSerie> GameSeries { get; set; }
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
