using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine washer = new WashingMachine();

            washer.Power = true;
            
            washer.Temperature = 50;
            washer.Water = true;
            washer.Time = 40;
            Console.WriteLine("Power is: " + washer.Power + "| Water is flowing: " + washer.Water + "| Temp is " + washer.Temperature + "| Time is " + washer.Time);

            washer.Washing();
            washer.Sling();
        }
    }
}
