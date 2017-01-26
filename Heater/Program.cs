using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Temperature = 90;
            heater.Humidity = 90.5;
            heater.ThrowWater();
            Console.WriteLine("Temperature is " + heater.Temperature);
            Console.WriteLine("Humidity is " + heater.Humidity);
        }
    }
}
