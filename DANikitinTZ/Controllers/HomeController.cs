using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;
using DANikitinTZ.Helpers;
using DANikitinTZ.Models;

namespace DANikitinTZ.Controllers
{
    public class HomeController : BaseController
    {
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
           
                return View();
            
        }

        public PartialViewResult BidsList()
        {
            return PartialView(db.Bids.ToList().OrderByDescending(x => x.id));
        }

        //
        // GET: /Home/Create

        public PartialViewResult Create()
        {
            return PartialView();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public PartialViewResult Create(Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                ViewBag.Status = "Строка добавлена";

                return PartialView("BidsList", db.Bids.ToList().OrderByDescending(x => x.id));
                //return RedirectToAction("Index");
            }
            else
            {
                return PartialView(bid);
            }
        }


       
    }
}
