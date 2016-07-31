using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetangular2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string folder)
        {
            FilePathResult staticPageToRender = null;
            try
            {
                var path = $"app/{folder}/index.html";
                var abc = new
                {
                    ahmet="sdasdf"
                };
                var serverPath = System.IO.Path.Combine(Server.MapPath("~"), path);
                if (!System.IO.File.Exists(serverPath))
                {
                    throw new Exception();
                }
                staticPageToRender = new FilePathResult(path, "text/html");

            }
            catch (Exception)
            {
                staticPageToRender = new FilePathResult($"~/app/404.html", "text/html");


            }
            return staticPageToRender;
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