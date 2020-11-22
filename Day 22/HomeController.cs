/*Q1. Create a MVC application having hyperlink Home,
 About us, Contact on click of each it should open 
respective view file. Your link should be in a file 
menubar.cshtml in a shared folder of a view folder. 
Also put footer in footer.cshtml file. Include this
 file using partial method in _Layout.cshtml*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day23_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}
