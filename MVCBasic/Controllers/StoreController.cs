using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasic.Models;

namespace MVCBasic.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
                {
                    new Genre{Name="Disco"},
                    new Genre{Name="Rock"},
                    new Genre{Name="Pop"}
                };
            return View(genres);
        }
        //public string Index()
        //{
        //    return "Hello from newly created STORE!!!";
        //}

        // GET: /Store/Browse?genre=Disco 
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);

            //return HttpUtility.HtmlEncode( "The genre is " + genre);
        }
        // GET: /Store/Details/5
        public ActionResult Details (int id)
        {
            var album = new Album { Title = "Album1 " + id };
            return View(album);
        }
    }
}