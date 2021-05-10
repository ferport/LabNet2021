using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPEntityFramework.Logic;
using TPEntityFramework.Entities;
using TPMVC.MVC.Models;

namespace TPMVC.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesLogic employeesLogic = new EmployeesLogic();
        ErrorView errorView = new ErrorView();

        // GET: Territories
        public ActionResult Index()
        {

            List<Employees> employees = employeesLogic.GetAll();

            List<EmployeesView> employeesViews = employees.Select(e => new EmployeesView
            {
                id = e.EmployeeID,
                firstName = e.FirstName,
                lastName = e.LastName
            }).ToList();

            return View(employeesViews);
        }

        public ActionResult InsertAndUpdate(string id, string firstName, string lastName)
        {
            if(id == null)
            {
                id = "0";
            }
            EmployeesView employeesView = new EmployeesView
            {
                id = int.Parse(id),
                firstName = firstName,
                lastName = lastName
            };
            return View(employeesView);
        }

        [HttpPost]
        public ActionResult InsertAndUpdate(EmployeesView employeesView)
        {
            if(employeesLogic.FindId(employeesView.id) == 0)
            {
                try
                {
                    Employees employeesEntity = new Employees
                    {
                        EmployeeID = employeesView.id,
                        FirstName = employeesView.firstName,
                        LastName = employeesView.lastName
                    };
                    employeesLogic.Update(employeesEntity);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ErrorView.errorMessage = "Error al guardar el empleado";
                    return RedirectToAction("Index", "Error");
                }
            }
            else 
            {
                try
                {
                    employeesLogic.Add(employeesView.id, employeesView.firstName, employeesView.lastName);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                     ErrorView.errorMessage = "Error al guardar el empleado";
                    return RedirectToAction("Index", "Error");
                }
            }
        }

        public ActionResult Delete(int id)
        {
            employeesLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}