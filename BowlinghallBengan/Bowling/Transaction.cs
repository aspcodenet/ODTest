using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Transaction
    {
        public decimal Amount { get; set; }
        public bool IsPayed { get; set; }
        public DateTime TimeStamp { get; set; }
        public FeeType FeeType { get; set; }
        public Game CurrentGame { get; set; }
        public Cup CurrentCompetition { get; set; }

        /*
            Inga metoder, bara properties (ingen konstruktor)
         */
    }
}
