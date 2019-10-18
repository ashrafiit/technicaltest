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
            var data = db.labour.ToList();
            return View(data);

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
                return RedirectToAction("Index");
            
        
                         
        }
       
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return HttpNotFound();
            }
            Labour lbr = db.labour.Find(id);
            if(lbr==null)
            {
                return HttpNotFound();
            }
            return View(lbr);
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Labour lbr = db.labour.Find(id);
            if (lbr == null)
            {
                return HttpNotFound();
            }
            return View(lbr);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Labour lbr = db.labour.Find(id);
            db.labour.Remove(lbr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Labour lbr = db.labour.Find(id);
            if (lbr == null)
            {
                return HttpNotFound();
            }
            return View(lbr);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Labour lab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lab).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lab);
        }
    }
}