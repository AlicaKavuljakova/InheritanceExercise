using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird: Animal
    {
        public Bird()
        {
            NumberOfLegs = 2;
            EnvironmentItLivesIn = "Air";
            HotOrColdBlooded = "Hot";
            HasFeathers = true;
        }
        public bool CanFly { get; set; }
        public bool EatsBugs { get; set; }
        public int WingSpanInCm { get; set; }    
        public bool Migrates    { get; set;}
    }
}
