using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Guitarra : ICantante
    {
        //Comportamiento 1
        public void Cantar()
        {
            Console.WriteLine("Puedo cantar canciones tocando la guitarra");
        }
    }
}
