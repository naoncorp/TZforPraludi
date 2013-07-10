using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DANikitinTZ.Models;

namespace DANikitinTZ.Controllers
{ 
    public class BidController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Bid/

        public ViewResult Index()
        {
            return View(db.Bids.ToList());
        }

        //
        // GET: /Bid/Details/5

        public ViewResult Details(int id)
        {
            Bid bid = db.Bids.Find(id);
            return View(bid);
        }

        //
        // GET: /Bid/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Bid/Create

        [HttpPost]
        public ActionResult Create(Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(bid);
        }
        
        //
        // GET: /Bid/Edit/5
 
        public ActionResult Edit(int id)
        {
            Bid bid = db.Bids.Find(id);
            return View(bid);
        }

        //
        // POST: /Bid/Edit/5

        [HttpPost]
        public ActionResult Edit(Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bid);
        }

        //
        // GET: /Bid/Delete/5
 
        public ActionResult Delete(int id)
        {
            Bid bid = db.Bids.Find(id);
            return View(bid);
        }

        //
        // POST: /Bid/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Bid bid = db.Bids.Find(id);
            db.Bids.Remove(bid);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}