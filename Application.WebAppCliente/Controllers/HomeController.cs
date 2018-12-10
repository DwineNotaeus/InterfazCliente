using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Application.WebAppCliente.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //       /api/Libro
            // WEB API:  127.0.0.1:84/api/Libro

            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:84/api/Libro");
            return View();
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