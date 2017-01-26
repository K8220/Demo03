using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance from Car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Subaru Legacy -94";
            car.Color = "White";
            car.Engine = 1.6;
            car.Speed = 500;
            car.FuzzyDice = false;
            car.DoorCount = 4;
            car.Accelerate();
            car.PrintData();
            car.Brake(7);
            Car.SomeProperty = 90;
            car.PrintData();

            // create another car object
            string model = "Speedy zales";
            Car nicecar = new Car(model);
            nicecar.PrintData();
            nicecar.Color = "Lime";
            Console.WriteLine("Color is " + nicecar.Color);
        }
    }
}
