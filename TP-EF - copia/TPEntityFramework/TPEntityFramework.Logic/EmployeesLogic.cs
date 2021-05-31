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
            try
            {
                return context.Employees.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Add(int id, string firstName, string lastName)
        {
            try
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
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Delete(int id)
        {
            try 
            {
                var deleteEmployee = context.Employees.Find(id);
                context.Employees.Remove(deleteEmployee);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
               
        }

        public void Update(Employees employee)
        {
            try
            {
                var updateEmployee = context.Employees.Find(employee.EmployeeID);
                updateEmployee.FirstName = employee.FirstName;
                updateEmployee.LastName = employee.LastName;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Employees GetOne(int id)
        {
            try
            {
                var employee = context.Employees.Find(id);
                return employee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
