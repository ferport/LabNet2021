using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Entities
{
    public class Avion : ITransporte
    {
        public int pasajeros { get ; set; }
        private int cantPasajeros { get; set; }
        private static int maxVelocidad;
        public int velocidadAct;
        private int velocidades;

        static Avion()
        {
            Avion.maxVelocidad = 800;
        }
        public Avion(){ }
        public Avion(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public void SetCantPasajeros(int cant)
        {
            this.cantPasajeros = cant;
        }

        public int GetCantPasajeros()
        {
            return this.cantPasajeros;
        }

        public void SetVelocidad(int cant)
        {
            this.velocidades = cant;
        }

        public int GetVelocidad()
        {
            return this.velocidades;
        }

        public int GetVelocidadMaxima()
        {
            return Avion.maxVelocidad;
        }
    }
}
