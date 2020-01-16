using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{

    //creamos la clase concreta basicwatch e implementamos la interfaz
    class BasicWatchi:IWatch
    {
        public BasicWatchi()
        {
        }
        //añadiremos metodos basicos de la clase basicwatch
        public void createFunctionality()
        {
            Console.WriteLine(" Basic Watch with: ");
            this.addTimer();
        }

        public void Super()
        {
            throw new NotImplementedException();
        }
        //añadiremos un tiempo
        private void addTimer()
        {
            Console.WriteLine(" Timer");
        }
    }
}
