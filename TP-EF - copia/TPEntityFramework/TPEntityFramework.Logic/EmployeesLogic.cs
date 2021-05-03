using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPEntityFramework.Entities;


namespace TPEntityFramework.Logic
{
    public class EmployeesLogic : BaseLogic , IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Add(int id, string firstName, string lastName)
        {
            Employees newEmployee = new Employees
            {
                EmployeeID = id,
                FirstName = firstName,
                LastName = lastName
            };
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteEmployee = context.Employees.Find(id);
            context.Employees.Remove(deleteEmployee);
            context.SaveChanges();   
        }

        public void Update(Employees employee)
        {
            var updateEmployee = context.Employees.Find(employee.EmployeeID);
            updateEmployee.FirstName = employee.FirstName;
            updateEmployee.LastName = employee.LastName;
            context.SaveChanges(); 
        }

        public void ShowAll()
        {
            Console.WriteLine("ID - Nombre - Apellido");
            Console.WriteLine("---------------------------");
            foreach (Employees employees in this.GetAll())
            {
                this.ShowOne(employees.EmployeeID);
                Console.WriteLine("---------------------------");
            }
        }

        public void ShowOne(int id)
        {
            var employee = context.Employees.Find(id);
            Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} - {employee.LastName}");
        }

        public int FindId(int id)
        {
            if(context.Employees.Find(id) == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

}
