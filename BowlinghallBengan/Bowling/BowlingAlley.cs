using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    //SINGELTON PATTERN
    class BowlingAlley
    {
        private static BowlingAlley _instance = null;
        public string Name { get; set; }
        public List<Member> AllMembers { get; set; }

        private BowlingAlley()
        {
            Name = "Bengans Bowlinghall";
            AllMembers = new List<Member>();
        }

        public static BowlingAlley Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BowlingAlley();
                }
                return _instance;
            }
        }

        public Visitor CreateVisitor(string name, string streetAddress, bool wantsMembership)
        {
            Visitor currentVisitor = new Visitor(name, streetAddress);

            if (wantsMembership)
            {
                currentVisitor.WantsMembership = true;
            }

            return currentVisitor;
        }

        public void Confirmation(string newMember)
        {
            string message = "Välkommen, du är nu medlem på " + this.Name;
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
