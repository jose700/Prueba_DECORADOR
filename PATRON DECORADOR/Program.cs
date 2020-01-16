using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciamos sus interfaz y la clase basica que se decorara
           IWatch basicWatch = new BasicWatchi();
            basicWatch.createFunctionality();
            Console.WriteLine("\n---------");

            IWatch sportsWatch = new SportWatchDecorator(new BasicWatchi());
            sportsWatch.createFunctionality();
            Console.WriteLine("\n---------");

            IWatch sportsLuxuryWatch = new LuxuryWatchDecorator(new SportWatchDecorator(new BasicWatchi()));
            sportsLuxuryWatch.createFunctionality();
            

            Console.ReadKey();
        }
    }
}
