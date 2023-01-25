using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Gestor
    {
        public const int Vino = 1;
        public const int Tequila = 2;

        public static BebidaEmbriagante GestorDeBebidas(int Tipo) {
            switch (Tipo)
            {
                case Vino:
                    return new Vino();

                case Tequila:
                    return new Tequila();

                default:
                    return null;
            }
        }
    }
}
