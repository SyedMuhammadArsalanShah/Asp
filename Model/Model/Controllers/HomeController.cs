using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Students obj = new Students() {

                Id = 0,
                Name="Azhaan",
                Cnic ="123456789"



            };




            return View(obj);
        }
    }
}