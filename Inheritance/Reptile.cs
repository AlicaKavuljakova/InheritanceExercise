using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile:Animal
    {
        public Reptile()
        {
           
        }
        public bool HasScales { get; set; }
        public bool IsOver6Feet { get; set; }
        public bool LivesInFlorida { get; set; }
        public bool IsPet { get; set; }
    }
}
