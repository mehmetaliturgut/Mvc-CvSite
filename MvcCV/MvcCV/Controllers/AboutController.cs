using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        GenericRepository<tbl_About> repo = new GenericRepository<tbl_About>();
        [HttpGet]
        public ActionResult Index()
        {
            var about = repo.List();
            return View(about);
        }
        [HttpPost]
        public ActionResult Index(tbl_About a)
        {
            var t = repo.Find(x => x.ID == 3);
            t.Name=a.Name;
            t.LastName = a.LastName;
            t.Address=a.Address;
            t.Telephone = a.Telephone;
            t.Mail = a.Mail;
            t.Explanation = a.Explanation;
            t.Picture = a.Picture;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}