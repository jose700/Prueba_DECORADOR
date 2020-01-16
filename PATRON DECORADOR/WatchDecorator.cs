using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{

    // la clase abstact sera nuestra clase a decorar, herenciamos la interfaz IWatch


    abstract class WatchDecorator : IWatch
    {

        //hacemos su constructor
        public WatchDecorator()
        {
        }
        // como hicimos en las anteriores clases a decorar en esta se hace lo mismo
        // ñaadiremos a la clase LuxuryWatchDecorator una variable super
        private LuxuryWatchDecorator super;

        public WatchDecorator(IWatch watch)
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
            Console.WriteLine(" and more features (Sport Watch): ");
            this.addPedometer();
            this.addSleepMode();
          
        }
    
    //convierte un reloj de lujo a un reloj  
    private void addPedometer()
    {
        Console.WriteLine(" Pedometer");
    }

    private void addSleepMode()
    {
        Console.WriteLine(" SleepMode ");
    }

    public void Super()
    {

    }

        public void createFunctionality()
        {
            Console.WriteLine("");
        }
    }
}