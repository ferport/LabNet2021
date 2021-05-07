using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEntityFramework.Logic;
using TPEntityFramework.Entities;

namespace TPEntityFramework.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string strId;
            string description;
            string confirm;
            int numId;
            int seguir = 0;
            int option;
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            EmployeesLogic employeesLogic = new EmployeesLogic();
            Menus menu = new Menus();
            Show show = new Show();


            do
            {
                menu.PrincipalMenu();
                Console.WriteLine("Ingrese un opcion");
                option = Validations.NumberValidation(Console.ReadLine());
                while(option == 0) 
                {
                    menu.PrincipalMenu();
                    Console.WriteLine("Ingrese un numero de opcion valido");
                    option = Validations.NumberValidation(Console.ReadLine());
                }

                switch(option)
                {
                    case 1:
                        Console.Clear();
                        show.ShowAllTerritories();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        show.ShowAllEmployees();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese un ID");
                        strId = Console.ReadLine();
                        if(territoriesLogic.FindId(strId) == 1)
                        {
                            Console.WriteLine("Ingrese una descripcion");
                            description = Console.ReadLine();
                            territoriesLogic.Add(strId, description);
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("ID duplicado");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingrese un ID");
                        numId = Validations.NumberValidation(Console.ReadLine());
                        if (employeesLogic.FindId(numId) == 1)
                        {
                            Console.WriteLine("Ingrese el nombre");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido");
                            lastName = Console.ReadLine();
                            employeesLogic.Add(numId, firstName, lastName);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ID duplicado");
                            Console.ReadKey();
                        }
                        
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ingrese un ID");
                        strId = Console.ReadLine();
                        if (territoriesLogic.FindId(strId) == 0)
                        {
                            show.ShowOneTerritorie(strId);
                            Console.WriteLine("Confirma la operacion? s/n");
                            confirm = Console.ReadLine();
                            if (Validations.ConfirmValidation(confirm) == 0)
                            {
                                if (confirm == "s")
                                {
                                    territoriesLogic.Delete(strId);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Caracter invalido");
                                Console.ReadKey();
                            }
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Id invalido");
                            Console.ReadKey();
                        }  
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Ingrese un ID");
                        numId = Validations.NumberValidation(Console.ReadLine());
                        if (employeesLogic.FindId(numId) == 0)
                        {
                            show.ShowOneEmployee(numId);
                            Console.WriteLine("Confirma la operacion? s/n");
                            confirm = Console.ReadLine();
                            if (Validations.ConfirmValidation(confirm) == 0)
                            {
                                if (confirm == "s")
                                {
                                    employeesLogic.Delete(numId);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Caracter invalido");
                                Console.ReadKey();
                            }
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Id invalido");
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Ingrese un ID");
                        strId = Console.ReadLine();
                        if (territoriesLogic.FindId(strId) == 0)
                        {
                            show.ShowOneTerritorie(strId);
                            Console.WriteLine("Ingrese la nueva descripcion");
                            description = Console.ReadLine();
                            territoriesLogic.Update(new Territories(strId, description));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Id invalido");
                            Console.ReadKey();
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Ingrese un ID");
                        numId = Validations.NumberValidation(Console.ReadLine());
                        if(employeesLogic.FindId(numId) == 0)
                        {
                            show.ShowOneEmployee(numId);
                            Console.WriteLine("Ingrese el nuevo nombre");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo apellido");
                            lastName = Console.ReadLine();
                            employeesLogic.Update(new Employees(numId, firstName, lastName));
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Id invalido");
                            Console.ReadKey();
                        }
                        break;
                    case 9:
                        Console.WriteLine("Esta seguro que desea salir? s/n");
                        confirm = Console.ReadLine();
                        if (Validations.ConfirmValidation(confirm) == 0)
                        {
                            if (confirm == "s")
                            {
                                seguir = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Caracter invalido");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero de opcion valido");
                        Console.ReadKey();
                        break;
                }
            } while(seguir == 0);   
        }
    }
}
