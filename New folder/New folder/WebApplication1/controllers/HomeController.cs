using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            users us = new users();
            us.aboutme = "<p>my adress : iran.mashhad</p></br>";
            us.Fname = "Ali";
            us.Lname = "Fani";
            us.gensiat = false;
            us.status = false;
            us.email = "alifani1377@gmail.com";
            us.tel = 0933400;
            us.ischecked = true;
            
            
              return  View(us);
        }


            public ActionResult Contact()
            {
            return View();
            }


    }
}