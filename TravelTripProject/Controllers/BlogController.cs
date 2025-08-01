﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        // GET: Blog
        public ActionResult Index()
        {

           // var bloglar = c.Blogs.ToList();
           by.Deger1=c.Blogs.ToList();
            by.Deger3 =c.Blogs.Take(3).ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {
            // var blogbul=c.Blogs.Where(x=>x.ID==id).ToList();
            by.Deger1=c.Blogs.Where(x=>x.ID==id).ToList();
            by.Deger2=c.Yorumlars.Where(x=>x.BlogID==id).ToList();
            return View(by);
        }

        [HttpGet]

        public PartialViewResult YorumYap(int id) 
        {
            ViewBag.deger = id;
            return PartialView();
        }

        
        public PartialViewResult YorumYap(Yorumlar p)
        {
            c.Yorumlars.Add(p);
            c.SaveChanges();
            return PartialView();
        }
    }
}