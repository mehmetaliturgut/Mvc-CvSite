using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        GenericRepository<tbl_Contact> repo = new GenericRepository<tbl_Contact>();
        public ActionResult Index()
        {
            var mes = repo.List();
            return View(mes);
        }
    }
}