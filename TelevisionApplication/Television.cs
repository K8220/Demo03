using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionApplication
{
    class Television
    {
        public bool Power { get; set; }
        public int Channel { get; set; }
        public bool Texttv { get; set; }
        public int Volume { get; set; }
        

        public void Signal()
        {
            if (Channel < 1 || Channel > 100)
            {
                Console.WriteLine("No signalero");
            }
        }

        public void VolChangeUp()
        {
            Volume += 2;
        }
        public void VolChangeDown()
        {
            Volume -= 2;
        }
        public void DataPrint()
        {
            Console.WriteLine("");
            Console.WriteLine("Power is:" + Power);
            Console.WriteLine("Current channel is: " + Channel);
            Console.WriteLine("Text tv: " + Texttv);
            Console.WriteLine("Volume is: " + Volume);
        }
    }
}
