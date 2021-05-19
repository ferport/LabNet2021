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
using System.Web.Http.Cors;

namespace TPApi.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeesController : ApiController
    {
        
        EmployeesLogic employeesLogic = new EmployeesLogic();

        

        // GET api/<controller>
        public IHttpActionResult Get()
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
            return Ok(employeesModel);
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
        public IHttpActionResult Add(EmployeeModel employee)
        {
            try 
            {
                employeesLogic.Add(employee.id, employee.firstName, employee.lastName);
                return Ok();
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
        }

        // POST api/<controller>/5
        [HttpPost]
        public IHttpActionResult Post(int id, EmployeeModel employeeModel)
        {
            try 
            {
                Employees employee = employeesLogic.GetOne(id);
                employee.FirstName = employeeModel.firstName;
                employee.LastName = employeeModel.lastName;
                employeesLogic.Update(employee);
                return Ok();
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
        }
        
        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            
            try
            {
                employeesLogic.Delete(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
        }
    }
}