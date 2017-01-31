using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelloApplication
{
    class Clock
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public bool alarm { get; set; }
        public bool wakeup { get; set; }
        public string tod { get; set; }

        public void bell()
        {
            if (alarm == true)
            {
                Console.WriteLine("ARMAGEDDON");
            }
        }

        public void sleep5()
        {
            minutes += 5;
        }

        public void sleep15()
        {
            minutes += 15;
        }

        public void press()
        {
            alarm = false;
        }
    }
}
