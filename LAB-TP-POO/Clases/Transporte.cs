using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TP_POO.Clases
{
    interface ITransporte
    {   
        //Atributos
        #region
        int pasajeros 
        { 
            get; 
            set; 
        }
        #endregion

        //Metodos
        #region
        string Avanzar();

        string Detenerse();
        #endregion
    }
}
