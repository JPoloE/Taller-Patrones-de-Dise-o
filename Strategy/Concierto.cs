using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Concierto
    {
        private ICantante Cantante;

        //Comportamiento por defecto
        public Concierto() {
            this.Cantante = new Guitarra();
        }


        public void CantarConGuitarra() {
            this.Cantante = new Guitarra();
        }


        public void CantarConPiano() {
            this.Cantante = new Piano();
        }


        public void cantar() { 
            this.Cantante.Cantar();
        }
    }
}
