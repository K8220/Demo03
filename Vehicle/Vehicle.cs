using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Name: " +Name);
            Console.WriteLine("Speed: " +Speed);
            Console.WriteLine("Tyres: " +Tyres);
            Console.WriteLine(" ");
        }

        public void ToString()
        {
            string data = (Name + " " + Speed + " " + Tyres);
            Console.WriteLine(data);
        }
    }
}
