using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            /* string[] name = new string[5];
            int[] age = new int[5];
            int[] year = new int[5]; */
            for (int i=0;i<=4;i++)
            {
                Console.Write("Give name > ");
                opiskelija.name[i] = Console.ReadLine();
                
                Console.Write("Give age > ");
                string line1 = Console.ReadLine();
                opiskelija.age[i] = int.Parse(line1);
                
                Console.Write("Give year > ");
                string line2 = Console.ReadLine();
                opiskelija.year[i] = int.Parse(line2);
                // Console.WriteLine(opiskelija.year[i]);
            }
            for (int j=0;j<=4;j++)
            Console.WriteLine("Student: " + opiskelija.name[j] + " Age: " + opiskelija.age[j] + " Year: " + opiskelija.year[j]);
        }
    }
}
