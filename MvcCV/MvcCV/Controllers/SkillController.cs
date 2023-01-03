using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class SkillController : Controller
    {
        //DbCVEntities db = new DbCVEntities();
        GenericRepository<tbl_Skills> repo = new GenericRepository<tbl_Skills>();
        // GET: Skill
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewSkill(tbl_Skills p)
        {
            if (!ModelState.IsValid)
            {
                return View("NewSkill");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SkillDelete(int id)
        {
            var value = repo.Find(x => x.ID == id);
            repo.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SkillEdit(int id)
        {
            var value = repo.Find(x => x.ID == id);
            return View(value);
        }
        [HttpPost]
        public ActionResult SkillEdit(tbl_Skills t)
        {
            var value = repo.Find(x => x.ID == t.ID);
            value.Skill=t.Skill;
            value.Rate=t.Rate;
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}