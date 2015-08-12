using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "Hello from newly created STORE!!!";
        }

        // GET: /Store/Browse?genre=Disco 
        public string Browse(string genre)
        {
            return HttpUtility.HtmlEncode( "The genre is " + genre);
        }
        // GET: /Store/Details/5
        public string Details (int id)
        {
            return "Store id is: " + id;
        }
    }
}