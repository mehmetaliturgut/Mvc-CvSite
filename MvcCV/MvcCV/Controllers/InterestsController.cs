using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class InterestsController : Controller
    {
        // GET: Interests
        GenericRepository<TBL_Interests> repo = new GenericRepository<TBL_Interests>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobbys = repo.List();
            return View(hobbys);
        }
        [HttpPost]
        public ActionResult Index(TBL_Interests p)
        {
            //TBL_Interests t =new TBL_Interests();
            var t = repo.Find(x => x.ID == 1);
            t.Explanation1 = p.Explanation1;
            t.Explanation2 = p.Explanation2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}