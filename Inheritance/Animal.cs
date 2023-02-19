using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     public class Animal
    {
        public Animal()
        {
        }
        public string animalName { get; set; }
        public int Legs { get; set; }
        public bool IsCarnivoir { get; set; }
        public bool IsEndangered { get; set; }
        public int Age { get; set; }
    }
}
