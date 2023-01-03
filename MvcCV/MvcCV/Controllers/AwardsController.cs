using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class AwardsController : Controller
    {
        // GET: Awards
        GenericRepository<tbl_Awards> repo =new GenericRepository<tbl_Awards> ();
        public ActionResult Index()
        {
            var award = repo.List();
            return View(award);
        }
        [HttpGet]
        public ActionResult AwardGet(int id)
        {
            var award = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(award);
        }
        [HttpPost]
        public ActionResult AwardGet(tbl_Awards t)
        {
            var award = repo.Find(x => x.ID == t.ID);
            award.Explanation = t.Explanation;
            award.Date = t.Date;
            repo.TUpdate(award);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult NewAward()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAward(tbl_Awards t)
        {
            if (!ModelState.IsValid)
            {
                return View("NewAward");
            }
            repo.TAdd(t);
            return RedirectToAction("Index");
        }
        public ActionResult AwardDelete(int id)
        {
            var award = repo.Find(x => x.ID == id);
            
            repo.TDelete(award);
            return RedirectToAction("Index");
        }
    }
}