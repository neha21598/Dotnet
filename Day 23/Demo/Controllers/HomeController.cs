using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day23_Demo.Models;

namespace Day23_Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        StudentLayer sl = new StudentLayer();

        public ActionResult Index()
        {
            return View(sl.Display);
        }

        public ActionResult Create()
        {
            return View();
        }

        

        [HttpPost]
        public ActionResult Create(Student s)
        {
            sl.InsertData(s);
            return View();
        }

    }
}
