using Obvervable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obvervable.Implements
{
    internal class Olga : IObservador
    {
        private Polleria _polleria;

        public Olga(Polleria polleria) { 
            _polleria = polleria;
            _polleria.agregarObservador(this);
        }


        public void notificacion(string mensaje)
        {
            Console.WriteLine($"Soy Olga : {mensaje}");
        }

        public void eliminarSuscripcion() {
            _polleria.eliminarObservador(this);
        }
    }
}
