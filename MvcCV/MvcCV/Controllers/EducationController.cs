using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    [Authorize]
    public class EducationController : Controller
    {
        GenericRepository<tbl_Education> repo = new GenericRepository<tbl_Education>();
        // GET: Education

        
        public ActionResult Index()
        {
            var edu = repo.List();
            return View(edu);
        }
        [HttpGet]
        public ActionResult EduAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EduAdd(tbl_Education p)
        {
            if (!ModelState.IsValid)
            {
                return View("EduAdd");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EduDelete(int id)
        {
            var edu =repo.Find(x=>x.ID==id);
            repo.TDelete(edu);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EduEdit(int id)
        {
            var edu = repo.Find(x => x.ID == id);

            return View(edu);
        }
        [HttpPost]
        public ActionResult EduEdit(tbl_Education p)
        {
            if (!ModelState.IsValid)
            {
                return View("EduEdit");
            }
            var edu = repo.Find(x => x.ID == p.ID);
            edu.Title=p.Title;
            edu.Subtitle1 = p.Subtitle1;
            edu.Subtitle2 = p.Subtitle2;
            edu.GPA = p.GPA;
            edu.Date = p.Date;            
            repo.TUpdate(edu);

            return RedirectToAction("Index");
        }
    }
}