using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{


    //Creamos el resto de decoradores a partir del decorador principal añadirán las funcionalidades particulares.
    class SportWatchDecorator : WatchDecorator
    {
        public SportWatchDecorator()
        {
        }

        // añadiremos la clase SportWatchDecorator y la variable super
        //para poder decorar las siguientes funcionalidades 
        private SportWatchDecorator super;

        public SportWatchDecorator (IWatch watch)
        {
            Super(watch);
        }

        private void Super(IWatch watch)
        {
         
        }

        //crearemos metodos con sus respectivas funciones e imprimir sus nuevas funcionalidades
        public void CreateFunctionality()
        {
            super.createFunctionality();
            Console.WriteLine(" and more features (Sport Watch): ");
            this.addPedometer();
            this.addSleepMode();
        }

        private void addPedometer()
        {
            Console.WriteLine(" Pedometer");
        }

        private void addSleepMode()
        {
            Console.WriteLine(" SleepMode ");
        }
    }
}
