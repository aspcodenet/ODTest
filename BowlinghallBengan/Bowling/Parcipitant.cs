using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    public class Parcipitant : Person
    {
        public int Id { get; set; }

        public Parcipitant(/*int id,*/ string name) : base(name)
        {
            //Id = id;
        }
    }
}
