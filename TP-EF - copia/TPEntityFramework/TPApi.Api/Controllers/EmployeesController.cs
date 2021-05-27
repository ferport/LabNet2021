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
            try
            {
                List<Employees> employees = employeesLogic.GetAll();

                List<EmployeeModel> employeesModel = employees.Select(e => new EmployeeModel
                {
                    id = e.EmployeeID,
                    firstName = e.FirstName,
                    lastName = e.LastName
                }).ToList();
                return Ok(employeesModel);
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Employees employee = employeesLogic.GetOne(id);
                EmployeeModel employeeModel = new EmployeeModel();
                employeeModel.id = employee.EmployeeID;
                employeeModel.firstName = employee.FirstName;
                employeeModel.lastName = employee.LastName;
                return Ok(employeeModel);
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
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