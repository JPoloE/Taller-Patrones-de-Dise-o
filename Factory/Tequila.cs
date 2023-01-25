using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Tequila : BebidaEmbriagante
    {
        public override string NivelDeEbriedadPorHora()
        {
            return "Cada hora el nivel de alcohol aumentará en 50 por tomar Tequila";
        }
    }
}
