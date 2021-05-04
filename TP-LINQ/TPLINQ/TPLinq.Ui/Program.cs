using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLinq.Logic;
using TPLinq.Entities;


namespace TPLinq.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int salir = 0;
            Menu menu = new Menu();
            Querys querys = new Querys();
            ShowQuerys showQuerys = new ShowQuerys();

            do
            {
                menu.PrincipalMenu();
                Console.WriteLine("Ingrese la opcion deseada");
                opcion = Console.ReadLine();

                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        showQuerys.ShowCustomer(querys.FirstCustomer());
                        Console.ReadKey();
                        break;
                    case "2":
                        showQuerys.ShowProducts(querys.OutStock());
                        Console.ReadKey();
                        break;
                    case "3":
                        showQuerys.ShowProducts(querys.ProductsMoreExpensiveThan3());
                        Console.ReadKey();
                        break;
                    case "4":
                        showQuerys.ShowCustomers(querys.WACustomers());
                        Console.ReadKey();
                        break;
                    case "5":
                        showQuerys.ShowProduct(querys.ProductFirstOrDefault());
                        Console.ReadKey();
                        break;
                    case "6":
                        
                        Console.WriteLine("1. Customers en mayusculas");
                        Console.WriteLine("2. Customers en minusculas");
                        Console.WriteLine("1. Elija una opcion");
                        opcion = Console.ReadLine();
                        Console.Clear();
                        if (opcion == "1")
                        {
                            showQuerys.ShowCustomersNameUpper(querys.Customers());
                            Console.ReadKey();
                        }
                        else if(opcion == "2")
                        {
                            showQuerys.ShowCustomersNameLower(querys.Customers());
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Opcion invalida");
                            Console.ReadKey();
                        }
                        break;
                    case "7":
                        showQuerys.ShowCustomersOrders(querys.CustomersOrders());
                        Console.ReadKey();
                        break;
                    case "8":
                        showQuerys.ShowCustomers(querys.WAFirst3());
                        Console.ReadKey();
                        break;
                    case "9":
                        showQuerys.ShowProducts(querys.ProductsOrderByName());
                        Console.ReadKey();
                        break;
                    case "10":
                        showQuerys.ShowProducts(querys.ProductsOrderByStock());
                        Console.ReadKey();
                        break;
                    case "11":
                        showQuerys.ShowCategoryProduct(querys.CategoryProducts());
                        Console.ReadKey();
                        break;
                    case "12":
                        showQuerys.ShowProduct(querys.FirstProduct());
                        Console.ReadKey();
                        break;
                    case "13":
                        Console.WriteLine("Consulta en construccion! Disculpe las molestias");
                        Console.ReadKey();
                        break;
                    case "14":
                        Console.WriteLine("Cerrando el programa ...");
                        Console.ReadKey();
                        salir = 1;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }
            }
            while (salir == 0);
        }
    }
}
