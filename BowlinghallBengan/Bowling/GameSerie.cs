using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    public class GameSerie
    {
        public GameSerie(int scorePlayer1, int scorePlayer2)
        {
            ScorePlayer1 = scorePlayer1;
            ScorePlayer2 = scorePlayer2;
        }
        //Bara properties, inga metoder eller konstruktor
        //SerieNr (1-3 st (int))
        public int ScorePlayer1 { get; set; }
        public int ScorePlayer2 { get; set; }
    }
}
