using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Piano : ICantante
    {

        //Comportamiento 2
        public void Cantar()
        {
            Console.WriteLine("Puedo cantar canciones con el piano");
        }
    }
}
