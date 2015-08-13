using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home - the default controller function for this class
        public ActionResult Index()
        {
            return View();
        }

        //public string Index() //section which was testing string output
        //{
        //    return "Hello from newly created CONTROLLER!!!";
        //}

    }
}