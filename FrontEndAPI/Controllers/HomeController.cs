using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace FrontEndAPI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //

            var httpClient = new HttpClient();
            //var json = await httpClient.GetStringAsync("http://ilorduywebapi.azurewebsites.net/api/Artistas");
            var json = await httpClient.GetStringAsync("http://jloracudris.azurewebsites.net/api/Artistas");
            var ArtistaList = JsonConvert.DeserializeObject<List<Artista>>(json);


            return View(ArtistaList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}