using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WallboardSpecialties.DAL;
using WallboardSpecialties.Models;

namespace WallboardSpecialties.Controllers
{
    public class HomeController : Controller
    {
        private WallboardContext db = new WallboardContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            var currentUser = db.Database.SqlQuery<Admin>("SELECT * " +
                                                            "FROM Admin " +
                                                            "WHERE Username = '" + email + "' AND " +
                                                            "password = '" + password + "'");

            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }
        }
    }
}