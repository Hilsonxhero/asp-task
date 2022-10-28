using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace auth.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Auth/Login
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            return RedirectToAction("Index","Dashboard");
        }

        // GET: Auth/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Auth/Register
        [HttpPost]
        public ActionResult Register(FormCollection collection)
        {
            return RedirectToAction("Login");
        }


    }
}
