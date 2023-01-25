using Obvervable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obvervable.Implements
{
    public class Jesus : IObservador
    {

        private Polleria _polleria;

        public Jesus(Polleria polleria)
        {
            _polleria = polleria;
            _polleria.agregarObservador(this);
        }

        public void notificacion(string mensaje)
        {
            Console.WriteLine($"Soy Jesus : {mensaje}");
           
        }

        public void eliminarSuscripcion()
        {
            _polleria.eliminarObservador(this);
        }

    }
}
