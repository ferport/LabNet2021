using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Entities;

namespace TP_POO.UI
{
    public class MostrarEntidades
    {
        
        public string MostrarPasajerosAvion(Avion avion)
        {
            return $"La cantidad de pasajeros es de {avion.GetCantPasajeros()}";
        }

        public string MostrarVelocidadAvion(Avion avion)
        {
            return $"La velocidad actual es {avion.velocidadAct} km/h";
        }

        public string MostrarPasajerosAutomovil(Automovil automovil)
        {
            return $"La cantidad de pasajeros es de {automovil.GetCantPasajeros()}";
        }

        public string MostrarVelocidadAutomovil(Automovil automovil)
        {
            return $"La velocidad actual es {automovil.velocidadAct} km/h";
        }

    }
}
