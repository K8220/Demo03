using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelloApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.hours = 6;
            clock.minutes = 00;
            int select = 1;

            while (clock.wakeup == false)
            {
                Console.WriteLine(clock.hours + " : " + clock.minutes);
                Console.WriteLine("What do?");
                Console.WriteLine("1. Sleep 5 mins");
                Console.WriteLine("2. Sleep 15 mins");
                if (clock.alarm == true)
                {
                    if (clock.hours >= 8)
                    {
                        Console.WriteLine("It ran out of batteries...");
                    }

                    else
                    {
                        Console.WriteLine("3. Shut the alarm!");
                    }
                }
                
                string line = Console.ReadLine();
                select = int.Parse(line);
                switch (select)
                {
                    case 1:
                        clock.sleep5();
                        break;
                    case 2:
                        clock.sleep15();
                        break;
                    case 3:
                        clock.press();
                        System.Environment.Exit(1);
                        break;
                }
                if (clock.minutes >= 60)
                {
                    clock.minutes = (clock.minutes - 60);
                    clock.hours = (clock.hours + 1);
                }
                if (clock.hours >= 7)
                {
                    clock.alarm = true;
                    clock.bell();
                }
                Console.WriteLine();
            }
        }
    }
}
