using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPMVC.MVC.Models;

namespace TPMVC.MVC.Controllers
{
    public class ErrorController : Controller
    {
        ErrorView errorView = new ErrorView();
        // GET: Error
        public ActionResult Index()
        {
            return View(errorView);
        }
    }
}