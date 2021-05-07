using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEntityFramework.Entities;
using TPEntityFramework.Logic;

namespace TPEntityFramework.UI
{
    class Show
    {
        EmployeesLogic employeesLogic = new EmployeesLogic();
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();

        public void ShowOneEmployee(int id)
        {
            var employee = employeesLogic.GetOne(id);
            Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} - {employee.LastName}");
        }

        public void ShowAllEmployees()
        {
            Console.WriteLine("ID - Nombre - Apellido");
            Console.WriteLine("---------------------------");
            foreach (Employees employees in employeesLogic.GetAll())
            {
                this.ShowOneEmployee(employees.EmployeeID);
                Console.WriteLine("---------------------------");
            }
        }

        public void ShowOneTerritorie(string id)
        {
            var territorie = territoriesLogic.GetOne(id);
            Console.WriteLine($"{territorie.TerritoryID} - {territorie.TerritoryDescription}");
        }

        public void ShowAllTerritories()
        {
            Console.WriteLine("  ID  -  DESCRIPCION");
            Console.WriteLine("-----------------------");
            foreach (Territories territories in territoriesLogic.GetAll())
            {
                this.ShowOneTerritorie(territories.TerritoryID);
                Console.WriteLine("----------------------");
            }
        }
    }
}
