using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Logic
{
    interface ITrasporteLogic<T>
    {
        int Avanzar(T entity);

        int Detenerse(T entity);

        int SubirPasajeros(int cant, T entity);
        int BajarPasajeros(int cant, T entity);
        
    }
}
