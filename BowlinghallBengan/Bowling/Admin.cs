using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Admin : Person
    {
        public Admin(string name) : base(name)
        {

        }

        public Cup CreateCup(string name, DateTime startDate, DateTime endDate)
        {
            Cup currentCup = new Cup(name, startDate, endDate);
            Console.WriteLine("*************************************");
            Console.WriteLine("Annonsering av " + name);
            Console.WriteLine("Startdatum av cup: " + startDate);
            Console.WriteLine("Slutdatum av cup: " + endDate);
            Console.WriteLine("Anmälningen är nu öppen");
            Console.WriteLine("*************************************");

            return currentCup;
        }
    }
}
