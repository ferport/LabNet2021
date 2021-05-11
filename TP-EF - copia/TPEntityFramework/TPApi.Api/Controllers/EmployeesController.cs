using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TPEntityFramework.Entities;
using TPEntityFramework.Logic;
using TPApi.Api.Areas.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace TPApi.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeesLogic employeesLogic = new EmployeesLogic();
        // GET api/<controller>
        public string Get()
        {
            List<Employees> employees = employeesLogic.GetAll();

            List<EmployeeModel> employeesModel = employees.Select(e => new EmployeeModel
            {
                id = e.EmployeeID,
                firstName = e.FirstName,
                lastName = e.LastName
            }).ToList();
            var json = new JavaScriptSerializer();
            var jsonStringResult = json.Serialize(employeesModel);
            return jsonStringResult;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            Employees employee = employeesLogic.GetOne(id);
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.id = employee.EmployeeID;
            employeeModel.firstName = employee.FirstName;
            employeeModel.lastName = employee.LastName;
            var json = new JavaScriptSerializer();
            var jsonStringResult = json.Serialize(employeeModel);
            return jsonStringResult;
        }

        // POST api/<controller>
        [HttpPost]
        public string Add(EmployeeModel employee)
        {
            try 
            {
                int id = 0;
                employeesLogic.Add(id, employee.firstName, employee.lastName);
                return "OK";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }

        // PACH api/<controller>/5
        [HttpPost]
        public string Post(int id, EmployeeModel employeeModel)
        {
            try 
            {
                Employees employee = employeesLogic.GetOne(id);
                employee.FirstName = employeeModel.firstName;
                employee.LastName = employeeModel.lastName;
                employeesLogic.Update(employee);
                return "OK";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }

        // DELETE api/<controller>/5
        public string Delete(int id)
        {
            try
            {
                employeesLogic.Delete(id);
                return "OK";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}