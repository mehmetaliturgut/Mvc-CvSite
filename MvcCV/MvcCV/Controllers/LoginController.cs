using MvcCV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCV.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbl_Admin p)
        {
            DbCVEntities db = new DbCVEntities();
            var value = db.tbl_Admin.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.Username,false);
                Session["Username"] = value.Username.ToString();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}