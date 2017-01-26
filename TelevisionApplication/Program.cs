using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            tv.Power = true;
            tv.Channel = 3;
            tv.Texttv = false;
            tv.Volume = 30;
            tv.Signal();

            tv.DataPrint();

            tv.VolChangeUp();
            tv.DataPrint();
            tv.Signal();
        }
    }
}
