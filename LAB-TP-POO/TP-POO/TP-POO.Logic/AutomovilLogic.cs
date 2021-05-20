using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Entities;

namespace TP_POO.Logic
{
    public class AutomovilLogic : ITrasporteLogic<Automovil>
    {
        public int Avanzar(Automovil automovil)
        {
            if (automovil.velocidadAct < 180)
            {
                int cambios = 4;
                int velocidad = automovil.GetVelocidad();
                if (velocidad < cambios)
                {
                    velocidad++;
                }
                automovil.SetVelocidad(velocidad);
                this.CambiarVelocidad(automovil.GetVelocidad(), automovil);
                if (automovil.GetVelocidad() == 4)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 2;
            }
        }

        public int Detenerse(Automovil automovil)
        {
            if (automovil.velocidadAct > 0)
            {
                int cambios = 0;
                int velocidad = automovil.GetVelocidad();
                if (velocidad > cambios)
                {
                    velocidad--;
                }
                automovil.SetVelocidad(velocidad);
                this.CambiarVelocidad(automovil.GetVelocidad(), automovil);
                if (automovil.GetVelocidad() == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 2;
            }
        }

        public int BajarPasajeros(int cant, Automovil automovil)
        {
            int bajarPasajeros = 0;
            bajarPasajeros = automovil.GetCantPasajeros() - cant;
            if (automovil.velocidadAct == 0)
            {
                if (bajarPasajeros >= 0)
                {
                    automovil.SetCantPasajeros(bajarPasajeros);
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 2;
            }
        }

        public int SubirPasajeros(int cant, Automovil automovil)
        {
            int subirPasajeros = 0;
            subirPasajeros = automovil.GetCantPasajeros() + cant;
            if (automovil.velocidadAct == 0)
            {
                if (subirPasajeros <= automovil.pasajeros)
                {
                    automovil.SetCantPasajeros(subirPasajeros);
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            else
            {
                return 2;
            }
        }

        private void CambiarVelocidad(int cambio, Automovil automovil)
        {
            automovil.SetVelocidad(cambio);
            switch (automovil.GetVelocidad())
            {
                case 0:
                    automovil.velocidadAct = 0;
                    break;
                case 1:
                    automovil.velocidadAct = 45;
                    break;
                case 2:
                    automovil.velocidadAct = 90;
                    break;
                case 3:
                    automovil.velocidadAct = 135;
                    break;
                case 4:
                    automovil.velocidadAct = 180;
                    break;
            }
        }
    }
}
