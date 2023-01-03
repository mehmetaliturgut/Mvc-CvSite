using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;

namespace MvcCV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbCVEntities db = new DbCVEntities();
        // GET: Default
        public ActionResult Index()
        {
            var values = db.tbl_About.ToList();
            return View(values);
        }
        public PartialViewResult SocialMedia()
        {
            var sm = db.tbl_SocialMedia.ToList();
            return PartialView(sm);
        }
        public PartialViewResult Experience()
        {
            var exp = db.tbl_Experience.ToList();
            return PartialView(exp);
        }
        public PartialViewResult Education()
        {
            var edc = db.tbl_Education.ToList();
            return PartialView(edc);
        }
        public PartialViewResult Skills()
        {
            var skl = db.tbl_Skills.ToList();
            return PartialView(skl);
        }
        public PartialViewResult Interest()
        {
            var intr = db.TBL_Interests.ToList();
            return PartialView(intr);
        }
        public PartialViewResult Awards()
        {
            var awr = db.tbl_Awards.ToList();
            return PartialView(awr);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(tbl_Contact t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.tbl_Contact.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}