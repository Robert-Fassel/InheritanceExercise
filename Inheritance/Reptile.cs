using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
           
        }

        public bool HasShell { get; set; }
        public bool IsVenomous { get; set; }
        public bool LaysEggs { get; set; }
        public string CreepyMeanCute { get; set; }
    }
}
