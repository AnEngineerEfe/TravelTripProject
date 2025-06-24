using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {
            var degerler=c.Blogs.ToList();
            return View(degerler);
        }

        public ActionResult About() 
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler=c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
    }
}