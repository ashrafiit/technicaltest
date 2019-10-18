using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technical_Test.Models;

namespace Technical_Test.Controllers
{
    public class LaboursController : Controller
    {
        // GET: Labours
        AppDbContextmodel db = new AppDbContextmodel();
        public ActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public ActionResult AddLabour()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLabour(Labour lab)
        {
            db.labour.Add(lab);
            db.SaveChanges();
           
           
          
            return View();
        }
    }
}