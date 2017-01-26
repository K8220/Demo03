using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class WashingMachine
    {
        public bool Power { get; set; }
        public int Temperature { get; set; }
        public bool Water { get; set; }
        public double Time {get;set;}

        public void Washing()
        {
            Console.WriteLine("Wrrrrrrrrr...");
        }

        public void Sling()
        {
            Console.WriteLine("Wrrrrrr intensifies...");
        }
    }
}
