using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Membership
    {
        public int MemberNo { get; set; }
        public DateTime StartDate { get; set; }

        public Membership(int memberNo, DateTime startDate)
        {
            this.MemberNo = memberNo;
            this.StartDate = startDate;
        }
    }
}
