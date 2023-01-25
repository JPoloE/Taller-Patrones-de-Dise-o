using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obvervable.Interfaces
{
    public interface IObservado
    {
        void notifcacionGeneral();
        void agregarObservador(IObservador observador);
        void eliminarObservador(IObservador observador);

    }
}
