using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Entities;

namespace TP_POO.Logic
{
    public class AvionLogic : ITrasporteLogic<Avion>
    {
        public int Avanzar(Avion avion)
        {
            if (avion.velocidadAct < 800)
            {
                int cambios = 6;
                int velocidad = avion.GetVelocidad();
                if (velocidad < cambios)
                {
                    velocidad++;
                }
                avion.SetVelocidad(velocidad);
                this.CambiarVelocidad(avion.GetVelocidad(), avion);
                if (avion.GetVelocidad() == 6)
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

        public int Detenerse(Avion avion)
        {
            if (avion.velocidadAct > 0)
            {
                int cambios = 0;
                int velocidad = avion.GetVelocidad();
                if (velocidad > cambios)
                {
                    velocidad--;
                }
                avion.SetVelocidad(velocidad);
                this.CambiarVelocidad(avion.GetVelocidad(), avion);
                if (avion.GetVelocidad() == 0)
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

        public int SubirPasajeros(int cant, Avion avion)
        {
            int subirPasajeros = 0;
            subirPasajeros = avion.GetCantPasajeros() + cant;
            if (avion.velocidadAct == 0)
            {
                if (subirPasajeros <= avion.pasajeros)
                {
                    avion.SetCantPasajeros(subirPasajeros);
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

        public int BajarPasajeros(int cant, Avion avion)
        {
            int bajarPasajeros = 0;
            bajarPasajeros = avion.GetCantPasajeros() - cant;
            if (avion.velocidadAct == 0)
            {
                if (bajarPasajeros >= 0)
                {
                    avion.SetCantPasajeros(bajarPasajeros);
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

        private void CambiarVelocidad(int cambio, Avion avion)
        {
            avion.SetVelocidad(cambio);
            switch (avion.GetVelocidad())
            {
                case 0:
                    avion.velocidadAct = 0;
                    break;
                case 1:
                    avion.velocidadAct = 133;
                    break;
                case 2:
                    avion.velocidadAct = 266;
                    break;
                case 3:
                    avion.velocidadAct = 399;
                    break;
                case 4:
                    avion.velocidadAct = 532;
                    break;
                case 5:
                    avion.velocidadAct = 665;
                    break;
                case 6:
                    avion.velocidadAct = 800;
                    break;
            }
        }
    }
}
