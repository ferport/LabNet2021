using System.Web.Mvc;
using TPMVC.MVC.Models;
using TPAPI.Logic;
using System;

namespace TPMVC.MVC.Controllers
{
    public class JokeController : Controller
    {
        JokeLogic jokeLogic = new JokeLogic();
        

        // GET: Joke
        public ActionResult Index()
        {
            try 
            {
                string joke = jokeLogic.GetJoke();
                JokeView jokeView = new JokeView();
                jokeView.joke = joke;
                return View(jokeView);
            }
            catch(Exception ex)
            {
                ErrorView.errorMessage = "No se pudo recuperar la broma";
                return RedirectToAction("Index", "Error");
            }
            
        }
        
    }

}