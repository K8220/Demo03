using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.PrintData();

            vehicle.Name = "Fillari";
            vehicle.Speed = 15;
            vehicle.Tyres = 2;

            vehicle.PrintData();
            vehicle.ToString();
        }
    }
}
