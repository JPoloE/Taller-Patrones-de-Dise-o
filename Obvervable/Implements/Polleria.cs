using Obvervable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obvervable.Implements
{
    public class Polleria : IObservado
    {
        private List<IObservador> _listaDeObservadores;
        public string tipoDePollo = "Pollo";

        //Construtor
        public Polleria()
        {
            _listaDeObservadores= new List<IObservador>();
        }

        //Metrodo agregar
        public void agregarObservador(IObservador observador)
        {
            _listaDeObservadores.Add(observador);
        }

        //Metodo eliminar
        public void eliminarObservador(IObservador observador)
        {
            _listaDeObservadores.Remove(observador);
        }

        public void notifcacionGeneral()
        {
            foreach (var observador in _listaDeObservadores)
            {
                observador.notificacion($"Llegó el pollito {tipoDePollo}");
            }
        }

        public void hayPollito(int numero) {

            Console.WriteLine($"Polleria: Ya tenemos el pollito {numero}");
            tipoDePollo = "A la parrilla";
            notifcacionGeneral();
        }
    }
}
