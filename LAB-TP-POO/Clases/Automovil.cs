using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TP_POO.Clases
{
    class Automovil : ITransporte
    {
        //Atributos
        #region
        public int pasajeros { get ; set ; }
        private int cantPasajeros { get; set; }
        private static int maxVelocidad;
        public int velocidadAct;
        private int velocidades;
        #endregion

        //Constructores
        #region
        static Automovil() 
        {
            Automovil.maxVelocidad = 180; 
        }
        public Automovil(int pasajeros) 
        {
            this.pasajeros = pasajeros;        
        }
        #endregion

        //Metodos
        #region
        public string Avanzar()
        {
            if (this.velocidadAct < 180)
            {
                this.velocidades++;
                CambiarVelocidad(this.velocidades);
                if (this.velocidades == 4)
                {
                    return $"El automovil esta en su maxima velocidad {Automovil.maxVelocidad} km/h";
                }
                else
                {
                    return MostrarVelocidad();
                }
            }
            else
            {
                return $"El automovil esta en su maxima velocidad {Automovil.maxVelocidad} km/h";
            }
        }

        public string Detenerse()
        {
            if (this.velocidadAct > 0 )
            {
                this.velocidades--;
                CambiarVelocidad(this.velocidades);
                if (this.velocidades == 0)
                {
                    return "El automovil se detuvo";
                }
                else 
                {
                    return MostrarVelocidad();
                }
            }
            else
            {
                return "El automovil ya esta quieto";
            }
        }

        public string MostrarPasajeros() 
        {
            return $"La cantidad de pasajeros es de {this.cantPasajeros}";
        }

        public string MostrarVelocidad()
        {
            return $"La velocidad actual es {this.velocidadAct} km/h";
        }

        public void SubirPasajeros(int cant)
        {
            if (this.velocidadAct == 0) 
            {
                if ((this.cantPasajeros + cant) <= pasajeros)
                {
                    this.cantPasajeros += cant;
                }
                else 
                {
                    Console.WriteLine($"No hay tantos asientos vacios. Los pasajeros actuales son {this.cantPasajeros}, quedan {this.pasajeros - this.cantPasajeros} asientos vacios");
                }
                
            }
            else 
            {
                Console.WriteLine($"Debe estar detenido para subir pasajeros. Velocidad actual {this.velocidadAct} km/h");
            }
        }

        public void BajarPasajeros(int cant)
        {
            if (this.velocidadAct == 0)
            {
                if ((this.cantPasajeros - cant) >= 0) 
                {
                    this.cantPasajeros -= cant;
                }
                else 
                {
                    Console.WriteLine($"No hay tantos pasajeros. Los pasajeros actuales son {this.cantPasajeros}");
                }
            }
            else
            {
                Console.WriteLine($"Debe estar detenido para bajar pasajeros. Velocidad actual {this.velocidadAct} km/h");
            }
        }

        private void CambiarVelocidad(int cambio)
        {
            this.velocidades = cambio;
            switch (this.velocidades)
            {
                case 0:
                    this.velocidadAct = 0;
                    break;
                case 1:
                    this.velocidadAct = 45;
                    break;
                case 2:
                    this.velocidadAct = 90;
                    break;
                case 3:
                    this.velocidadAct = 135;
                    break;
                case 4:
                    this.velocidadAct = 180;
                    break;
            }
        }
        #endregion
    }
}
