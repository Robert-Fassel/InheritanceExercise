using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        { 
            
        }
        public bool CanFly { get; set; }
        public bool Migratory { get; set; } 
        public bool CanSpeak { get; set; }
        public bool IsNocturnal { get; set; }
    }
    
    
}
