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
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student st = sl.Display_details(id);
            return View(st);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
           Student sm= sl.Display_details(id);
            return View(sm);
        }

       
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            sl.Update(s);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
           Student s1= sl.Display_details(id);
           return View(s1);
        }

        [HttpPost]
        public ActionResult Delete(Student s)
        {
             sl.Delete(s.id);
             return RedirectToAction("Index");
        }

    }
}
