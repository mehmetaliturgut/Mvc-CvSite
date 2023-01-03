using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        [HttpGet]
        public ActionResult ExpAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExpAdd(tbl_Experience p)
        {
            
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult ExpDelete(int id)
        {
            tbl_Experience t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ExpGet(int id)
        {
            tbl_Experience t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult ExpGet(tbl_Experience p)
        {
            tbl_Experience t = repo.Find(x => x.ID == p.ID);
            t.Ttile = p.Ttile;
            t.Subtitle = p.Subtitle;
            t.Date=p.Date;
            t.Explanation = p.Explanation;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}