using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.UI
{
    public class Menus
    {
        public void MenuPrincipal()
        {
            Console.WriteLine("***Elija una opcion***\n");
            Console.WriteLine("1)Listar automoviles");
            Console.WriteLine("2)Listar aviones");
            Console.WriteLine("3)Poner en marcha/avanzar/detener un automovil");
            Console.WriteLine("4)Poner en marcha/avanzar/detener un avion");
            Console.WriteLine("5)Bajar/subir pasajeros de un automovil");
            Console.WriteLine("6)Bajar/subir pasajeros de un avion");
            Console.WriteLine("7)Cerrar");
        }

        public void MenuAutomovil()
        {
            Console.WriteLine("Elija un automovil\n");
            Console.WriteLine("1)Automovil 1");
            Console.WriteLine("2)Automovil 2");
            Console.WriteLine("3)Automovil 3");
            Console.WriteLine("4)Automovil 4");
            Console.WriteLine("5)Automovil 5");
        }

        public void MenuAvion()
        {
            Console.WriteLine("Elija un avion\n");
            Console.WriteLine("1)Avion 1");
            Console.WriteLine("2)Avion 2");
            Console.WriteLine("3)Avion 3");
            Console.WriteLine("4)Avion 4");
            Console.WriteLine("5)Avion 5");
        }

        public void MenuMovimiento()
        {
            Console.WriteLine("1)Avanzar");
            Console.WriteLine("2)Detenerse");
        }

        public void MenuSubirOBajar()
        {
            Console.WriteLine("1)Subir pasajeros");
            Console.WriteLine("2)Bajar pasajeros");
        }
    }
}
