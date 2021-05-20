using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Entities;
using TP_POO.Logic;

namespace TP_POO.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus menus = new Menus();
            MostrarEntidades mostrar = new MostrarEntidades();
            AutomovilLogic automovilLogic = new AutomovilLogic();
            AvionLogic avionLogic = new AvionLogic();
            int cont = 0;
            int rta = 0;
            int opcion;
            int cantParse;
            int flagCase3 = 0;
            int flagCase4 = 0;
            int flagCase5 = 0;
            int flagCase6 = 0;
            string strOpcion = "";
            string cant = "";
            Automovil auto = null;
            Avion avion = null;
            
            List<ITransporte> transportes = new List<ITransporte>
            {
                new Automovil(5),
                new Automovil(5),
                new Automovil(5),
                new Automovil(5),
                new Automovil(5),
                new Avion(375),
                new Avion(375),
                new Avion(375),
                new Avion(375),
                new Avion(375)
            };

           do
             {
                 menus.MenuPrincipal();
                 strOpcion = Console.ReadLine();
                 int.TryParse(strOpcion, out opcion);
                 Console.Clear();

                 switch (opcion)
                 {
                     case 1:
                         cont = 1;
                         foreach (var item in transportes)
                         {
                             if (item.GetType().ToString() == "TP_POO.Entities.Automovil") 
                             {
                                 Console.Write($"Automovil {cont} : ");
                                 Console.Write(mostrar.MostrarPasajerosAutomovil((Automovil)item));
                                 Console.Write(". ");
                                 Console.WriteLine(mostrar.MostrarVelocidadAutomovil((Automovil)item));
                                 cont++;
                             } 
                         }
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case 2:
                         cont = 1;
                         foreach (var item in transportes)
                         {
                            if (item.GetType().ToString() == "TP_POO.Entities.Avion")
                            {
                                Console.Write($"Avion {cont} : ");
                                Console.Write(mostrar.MostrarPasajerosAvion((Avion)item));
                                Console.Write(". ");
                                Console.WriteLine(mostrar.MostrarVelocidadAvion((Avion)item));
                                cont++;
                            }
                         }
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case 3:
                        menus.MenuAutomovil();
                        strOpcion = Console.ReadLine();
                        int.TryParse(strOpcion, out opcion);
                        Console.Clear();
                        switch (opcion)
                        {
                             case 1:
                                 auto = (Automovil)transportes.ElementAt(0);
                                 break;
                             case 2:
                                 auto = (Automovil)transportes.ElementAt(1);
                                 break;
                             case 3:
                                 auto = (Automovil)transportes.ElementAt(2);
                                 break;
                             case 4:
                                 auto = (Automovil)transportes.ElementAt(3);
                                 break;
                             case 5:
                                 auto = (Automovil)transportes.ElementAt(4);
                                 break;
                             default:
                                 Console.WriteLine("Opcion invalida");
                                 Console.ReadKey();
                                 Console.Clear();
                                 flagCase3 = 1;
                                 break;
                        }
                        if (flagCase3 == 0)
                        {
                            menus.MenuMovimiento();
                            strOpcion = Console.ReadLine();
                            int.TryParse(strOpcion, out opcion);
                            Console.Clear();
                            if (opcion == 1)
                            {
                                int avanzar = automovilLogic.Avanzar(auto);
                                if (avanzar == 1)
                                {
                                    Console.WriteLine($"El automovil esta en su maxima velocidad {auto.GetVelocidadMaxima()} km/h");
                                }
                                else if (avanzar == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarVelocidadAutomovil(auto));
                                }
                                else
                                {
                                    Console.WriteLine($"El automovil esta en su maxima velocidad {auto.GetVelocidadMaxima()} km/h");
                                }
                            }
                            else if (opcion == 2)
                            {
                                int detenerse = automovilLogic.Detenerse(auto);
                                if (detenerse == 1)
                                {
                                    Console.WriteLine("El automovil se detuvo");
                                }
                                else if (detenerse == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarVelocidadAutomovil(auto));
                                }
                                else
                                {
                                    Console.WriteLine("El automovil ya esta quieto");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opcion invalida");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        flagCase3 = 0;
                        break;
                     case 4:
                         menus.MenuAvion();
                         strOpcion = Console.ReadLine();
                         int.TryParse(strOpcion, out opcion);
                         Console.Clear();
                         switch (opcion)
                         {
                             case 1:
                                 avion = (Avion)transportes.ElementAt(5);
                                 break;
                             case 2:
                                 avion = (Avion)transportes.ElementAt(6);
                                 break;
                             case 3:
                                 avion = (Avion)transportes.ElementAt(7);
                                 break;
                             case 4:
                                 avion = (Avion)transportes.ElementAt(8);
                                 break;
                             case 5:
                                 avion = (Avion)transportes.ElementAt(9);
                                 break;
                             default:
                                 Console.WriteLine("Opcion invalida");
                                 Console.ReadKey();
                                 Console.Clear();
                                 flagCase4 = 1;
                                 break;
                         }
                         if(flagCase4 == 0)
                         {
                            menus.MenuMovimiento();
                            strOpcion = Console.ReadLine();
                            int.TryParse(strOpcion, out opcion);
                            Console.Clear();
                            if (opcion == 1)
                            {
                                int avanzar = avionLogic.Avanzar(avion);
                                if (avanzar == 1)
                                {
                                    Console.WriteLine($"El avion esta en su maxima velocidad {avion.GetVelocidadMaxima()} km/h");
                                }
                                else if (avanzar == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarVelocidadAvion(avion));
                                }
                                else
                                {
                                    Console.WriteLine($"El avion esta en su maxima velocidad {avion.GetVelocidadMaxima()} km/h");
                                }
                            }
                            else if (opcion == 2)
                            {
                                int detenerse = avionLogic.Detenerse(avion);
                                if (detenerse == 1)
                                {
                                    Console.WriteLine("El avion se detuvo");
                                }
                                else if (detenerse == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarVelocidadAvion(avion));
                                }
                                else
                                {
                                    Console.WriteLine("El avion ya esta quieto");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opcion invalida");
                            }
                            Console.ReadKey();
                            Console.Clear();
                         }
                        flagCase4 = 0;
                        break;
                     case 5:
                         menus.MenuAutomovil();
                         strOpcion = Console.ReadLine();
                         int.TryParse(strOpcion, out opcion);
                         Console.Clear();
                         switch (opcion)
                         {
                            case 1:
                                auto = (Automovil)transportes.ElementAt(0);
                                break;
                            case 2:
                                auto = (Automovil)transportes.ElementAt(1);
                                break;
                            case 3:
                                auto = (Automovil)transportes.ElementAt(2);
                                break;
                            case 4:
                                auto = (Automovil)transportes.ElementAt(3);
                                break;
                            case 5:
                                auto = (Automovil)transportes.ElementAt(4);
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                Console.ReadKey();
                                Console.Clear();
                                flagCase5 = 1;
                                break;
                         }
                         if(flagCase5 == 0)
                         {
                            menus.MenuSubirOBajar();
                            strOpcion = Console.ReadLine();
                            int.TryParse(strOpcion, out opcion);
                            Console.Clear();
                            if (opcion == 1)
                            {
                                Console.WriteLine("Cuantos pasajeros van a subir?");
                                cant = Console.ReadLine();
                                int.TryParse(cant, out cantParse);
                                Console.Clear();
                                int subir = automovilLogic.SubirPasajeros(cantParse, auto);
                                if (subir == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarPasajerosAutomovil(auto));
                                }
                                else if(subir == 1)
                                {
                                    Console.WriteLine($"No hay tantos asientos vacios. Los pasajeros actuales son {auto.GetCantPasajeros()}, " +
                                        $"quedan {auto.pasajeros - auto.GetCantPasajeros()} asientos vacios");
                                    Console.WriteLine(mostrar.MostrarPasajerosAutomovil(auto));
                                }
                                else 
                                {
                                    Console.WriteLine($"Debe estar detenido para subir pasajeros. Velocidad actual {auto.velocidadAct} km/h");
                                }
                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Cuantos pasajeros van a bajar?");
                                cant = Console.ReadLine();
                                int.TryParse(cant, out cantParse);
                                Console.Clear();
                                int bajar = automovilLogic.BajarPasajeros(cantParse, auto);
                                if (bajar == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarPasajerosAutomovil(auto));
                                }
                                else if (bajar == 1)
                                {
                                    Console.WriteLine($"No hay tantos pasajeros. Los pasajeros actuales son {auto.GetCantPasajeros()}");
                                    Console.WriteLine(mostrar.MostrarPasajerosAutomovil(auto));
                                }
                                else
                                {
                                    Console.WriteLine($"Debe estar detenido para bajar pasajeros. Velocidad actual {auto.velocidadAct} km/h");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opcion invalida");
                            }
                            Console.ReadKey();
                            Console.Clear();
                         }
                        flagCase5 = 0;
                        break;
                     case 6:
                         menus.MenuAvion();
                         strOpcion = Console.ReadLine();
                         int.TryParse(strOpcion, out opcion);
                         Console.Clear();
                         switch (opcion)
                         {
                            case 1:
                                avion = (Avion)transportes.ElementAt(5);
                                break;
                            case 2:
                                avion = (Avion)transportes.ElementAt(6);
                                break;
                            case 3:
                                avion = (Avion)transportes.ElementAt(7);
                                break;
                            case 4:
                                avion = (Avion)transportes.ElementAt(8);
                                break;
                            case 5:
                                avion = (Avion)transportes.ElementAt(9);
                                break;
                            default:
                                 Console.WriteLine("Opcion invalida");
                                 Console.ReadKey();
                                 Console.Clear();
                                 flagCase6 = 1;
                                 break;
                         }
                         if(flagCase6 == 0)
                         {
                            menus.MenuSubirOBajar();
                            strOpcion = Console.ReadLine();
                            int.TryParse(strOpcion, out opcion);
                            Console.Clear();
                            if (opcion == 1)
                            {
                                Console.WriteLine("Cuantos pasajeros van a subir?");
                                cant = Console.ReadLine();
                                int.TryParse(cant, out cantParse);
                                Console.Clear();
                                int subir = avionLogic.SubirPasajeros(cantParse, avion);
                                if (subir == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarPasajerosAvion(avion));
                                }
                                else if (subir == 1)
                                {
                                    Console.WriteLine($"No hay tantos asientos vacios. Los pasajeros actuales son {avion.GetCantPasajeros()}, " +
                                        $"quedan {avion.pasajeros - avion.GetCantPasajeros()} asientos vacios");
                                    Console.WriteLine(mostrar.MostrarPasajerosAvion(avion));
                                }
                                else
                                {
                                    Console.WriteLine($"Debe estar detenido para subir pasajeros. Velocidad actual {avion.velocidadAct} km/h");
                                }
                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Cuantos pasajeros van a bajar?");
                                cant = Console.ReadLine();
                                int.TryParse(cant, out cantParse);
                                Console.Clear();
                                int bajar = avionLogic.BajarPasajeros(cantParse, avion);
                                if (bajar == 0)
                                {
                                    Console.WriteLine(mostrar.MostrarPasajerosAvion(avion));
                                }
                                else if (bajar == 1)
                                {
                                    Console.WriteLine($"No hay tantos pasajeros. Los pasajeros actuales son {avion.GetCantPasajeros()}");
                                    Console.WriteLine(mostrar.MostrarPasajerosAvion(avion));
                                }
                                else
                                {
                                    Console.WriteLine($"Debe estar detenido para bajar pasajeros. Velocidad actual {avion.velocidadAct} km/h");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opcion invalida");
                            }
                            Console.ReadKey();
                            Console.Clear();
                         }
                        flagCase6 = 1;
                        break;
                     case 7:
                         rta = 1;
                         break;
                     default:
                         Console.WriteLine("Opcion invalida");
                         Console.ReadKey();
                         Console.Clear();
                         break;
                 }
             }
             while (rta == 0);
        }
    }
}
