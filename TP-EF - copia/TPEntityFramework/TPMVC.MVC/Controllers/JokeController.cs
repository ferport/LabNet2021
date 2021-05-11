using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TPMVC.MVC.Models;

namespace TPMVC.MVC.Controllers
{
    public class JokeController : Controller
    {
        // GET: Joke
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://geek-jokes.sameerkumar.website/api?format=json");
            JokeView JokeViews = JsonConvert.DeserializeObject<JokeView>(json);
            return View(JokeViews);
        }
    }
}