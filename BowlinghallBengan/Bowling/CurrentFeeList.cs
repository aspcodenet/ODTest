using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class CurrentFeeList
    {
        private static CurrentFeeList _instance = null;
        public List<CurrentFee> _allFeeTypes;

        public static CurrentFeeList Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentFeeList();
                }
                return _instance;
            }
        }

        private CurrentFeeList()
        {
            _allFeeTypes = new List<CurrentFee>();

            _allFeeTypes.Add(new CurrentFee { FeeType = FeeType.StartFee, Amount = 1200 });
            _allFeeTypes.Add(new CurrentFee { FeeType = FeeType.MemberFee, Amount = 200 });
            _allFeeTypes.Add(new CurrentFee { FeeType = FeeType.CupFee, Amount = 100 });
        }

        public decimal GetPriceForFeeType(FeeType currentType)
        {
            foreach (var fee in _allFeeTypes)
            {
                if (fee.FeeType == currentType)
                {
                    return fee.Amount;
                }
            }

            return 0;
        }

        /*
         ANVÄNDER SINGELTON PATTERN

                - Pga vi gör konstruktorn privat så kan man inte utifrån skapa upp en till instans av den här klassen (singelton)
                        - Kommer bara finnas ett objekt av den här typen (currentFeelist ska bara finnas en av)

                - Vi använder den här listan som en typ av prislista (om den ändras så har de bakåt som använt listan samma värden)

                - I den här listan lägger vi in Amount och FeeType på resp. item (görs i konstruktorn)


          METODER:
                - GetPriceForFeeType()
          
          KONSTRUKTOR (privat) och PROPERTIES (ngn statisk....googla)
         */
    }
}
