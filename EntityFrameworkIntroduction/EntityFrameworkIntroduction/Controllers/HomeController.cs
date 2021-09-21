﻿using EntityFrameworkIntroduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkIntroduction.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            StudentContext st = new StudentContext();
            Student obj = st.student.Single(x=>x.Id == id); //x => x.id == id



            return View(obj);
        }
    }
}