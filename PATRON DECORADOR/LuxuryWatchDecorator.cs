using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{

    // creamos una nueva clase y herenciamos la clase WatchDecorator que sera la clase a decorar 
    class LuxuryWatchDecorator : WatchDecorator
    {
        public LuxuryWatchDecorator()
        {
        }
        // como hicimos en las anteriores clases a decorar en esta se hace lo mismo
        // ñaadiremos a la clase LuxuryWatchDecorator una variable super
        private LuxuryWatchDecorator super;

     public LuxuryWatchDecorator  (IWatch watch)
        {
            Super(watch);
        }
        // añadiremos sus respectivas metodos
        private void Super(IWatch watch)
        {
            throw new NotImplementedException();
        }

        public void CreateFunctionality()
        {
            super.CreateFunctionality();
            Console.WriteLine(" and  more features (Luxury Watch): ");
            this.addFastCharge();
            this.addImpermeability();
            this.addNFC();
        }

        private void addFastCharge()
        {
            Console.WriteLine (" FastCharge ");
        }

        private void addImpermeability()
        {
            Console.WriteLine(" Impermeability ");
        }
        private void addNFC()
        {
            Console.WriteLine(" NFC ");
        }
    }
}
