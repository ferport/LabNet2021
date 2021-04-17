using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_TP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int rta = 0;
            string opcion = "";
            string cant = "";

            List<Clases.Automovil> automoviles = new List<Clases.Automovil>
            {
                new Clases.Automovil(5),
                new Clases.Automovil(5),
                new Clases.Automovil(5),
                new Clases.Automovil(5),
                new Clases.Automovil(5)  
            };

            List<Clases.Avion> aviones = new List<Clases.Avion>
            {
                new Clases.Avion(375),
                new Clases.Avion(375),
                new Clases.Avion(375),
                new Clases.Avion(375),
                new Clases.Avion(375)
            };

            /*foreach (var item in automoviles)
            {
                Console.WriteLine(item.MostrarPasajeros());
            }*/


            do
            {
                Console.WriteLine("***Elija una opcion***\n");
                Console.WriteLine("1)Listar automoviles");
                Console.WriteLine("2)Listar aviones");
                Console.WriteLine("3)Poner en avanzar/detener un automovil");
                Console.WriteLine("4)Poner en marcha/avanzar/detener un avion");
                Console.WriteLine("5)Bajar/subir pasajeros de un automovil");
                Console.WriteLine("6)Bajar/subir pasajeros de un avion");
                Console.WriteLine("7)Cerrar");
                opcion = Console.ReadLine();
                Console.Clear();
                switch (int.Parse(opcion))
                {
                    case 1:
                        cont = 1;
                        foreach (var item in automoviles)
                        {
                            Console.Write($"Automovil {cont} : ");
                            Console.Write(item.MostrarPasajeros());
                            Console.Write(". ");
                            Console.WriteLine(item.MostrarVelocidad());
                            cont++;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        cont = 1;
                        foreach (var item in aviones)
                        {
                            Console.Write($"Avion {cont} : ");
                            Console.Write(item.MostrarPasajeros());
                            Console.Write(". ");
                            Console.WriteLine(item.MostrarVelocidad());
                            cont++;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Elija un automovil\n");
                        Console.WriteLine("1)Automovil 1");
                        Console.WriteLine("2)Automovil 2");
                        Console.WriteLine("3)Automovil 3");
                        Console.WriteLine("4)Automovil 4");
                        Console.WriteLine("5)Automovil 5");
                        opcion = Console.ReadLine();
                        Console.Clear();
                        switch (int.Parse(opcion)) 
                        {
                            case 1:
                                var autoUno = automoviles.ElementAt(0);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(autoUno.Avanzar());
                                }
                                else if(int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(autoUno.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                var autoDos = automoviles.ElementAt(1);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(autoDos.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(autoDos.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                var autoTres = automoviles.ElementAt(2);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(autoTres.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(autoTres.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                var autoCuatro = automoviles.ElementAt(3);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(autoCuatro.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(autoCuatro.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                var autoCinco = automoviles.ElementAt(4);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(autoCinco.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(autoCinco.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                        }
                        break;
                    case 4:
                        Console.WriteLine("Elija un avion\n");
                        Console.WriteLine("1)Avion 1");
                        Console.WriteLine("2)Avion 2");
                        Console.WriteLine("3)Avion 3");
                        Console.WriteLine("4)Avion 4");
                        Console.WriteLine("5)Avion 5");
                        opcion = Console.ReadLine();
                        Console.Clear();
                        switch (int.Parse(opcion))
                        {
                            case 1:
                                var avionUno = aviones.ElementAt(0);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(avionUno.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(avionUno.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                var avionDos = aviones.ElementAt(1);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(avionDos.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(avionDos.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                var avionTres = aviones.ElementAt(2);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(avionTres.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(avionTres.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                var avionCuatro = aviones.ElementAt(3);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(avionCuatro.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(avionCuatro.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                var avionCinco = aviones.ElementAt(4);
                                Console.WriteLine("1)Avanzar");
                                Console.WriteLine("2)Detenerse");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine(avionCinco.Avanzar());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine(avionCinco.Detenerse());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Elija un automovil\n");
                        Console.WriteLine("1)Automovil 1");
                        Console.WriteLine("2)Automovil 2");
                        Console.WriteLine("3)Automovil 3");
                        Console.WriteLine("4)Automovil 4");
                        Console.WriteLine("5)Automovil 5");
                        opcion = Console.ReadLine();
                        Console.Clear();
                        switch (int.Parse(opcion))
                        {
                            case 1:
                                var autoUno = automoviles.ElementAt(0);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoUno.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoUno.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoUno.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoUno.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                var autoDos = automoviles.ElementAt(1);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoDos.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoDos.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoDos.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoDos.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                var autoTres = automoviles.ElementAt(2);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoTres.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoTres.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoTres.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoTres.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                var autoCuatro = automoviles.ElementAt(3);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoCuatro.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoCuatro.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoCuatro.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoCuatro.MostrarPasajeros()); ;
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                var autoCinco = automoviles.ElementAt(4);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoCinco.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoCinco.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    autoCinco.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(autoCinco.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Elija un avion\n");
                        Console.WriteLine("1)Avion 1");
                        Console.WriteLine("2)Avion 2");
                        Console.WriteLine("3)Avion 3");
                        Console.WriteLine("4)Avion 4");
                        Console.WriteLine("5)Avion 5");
                        opcion = Console.ReadLine();
                        Console.Clear();
                        switch (int.Parse(opcion))
                        {
                            case 1:
                                var avionUno = aviones.ElementAt(0);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionUno.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionUno.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionUno.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionUno.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                var avionDos = aviones.ElementAt(1);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionDos.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionDos.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionDos.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionDos.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                var avionTres = aviones.ElementAt(2);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionTres.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionTres.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionTres.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionTres.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                var avionCuatro = aviones.ElementAt(3);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionCuatro.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionCuatro.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionCuatro.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionCuatro.MostrarPasajeros()); ;
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                var avionCinco = aviones.ElementAt(4);
                                Console.WriteLine("1)Subir pasajeros");
                                Console.WriteLine("2)Bajar pasajeros");
                                opcion = Console.ReadLine();
                                Console.Clear();
                                if (int.Parse(opcion) == 1)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a subir?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionCinco.SubirPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionCinco.MostrarPasajeros());
                                }
                                else if (int.Parse(opcion) == 2)
                                {
                                    Console.WriteLine("Cuantos pasajeros van a bajar?");
                                    cant = Console.ReadLine();
                                    Console.Clear();
                                    avionCinco.BajarPasajeros(int.Parse(cant));
                                    Console.WriteLine(avionCinco.MostrarPasajeros());
                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
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
