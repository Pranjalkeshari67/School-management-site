using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntSchl_BOL.Models;
using IntSchl_BLL;
using System.Data;
using System.Web.Security;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index(User_ user)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(User_ user)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Teachers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Teachers(User_ user)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Classes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Classes(User_ user)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Blog()
        {
            List<blog> lst = new List<blog>();
            Admin admin = new Admin();
            lst = admin.allBlog();
            return View(lst);
        }
        [HttpPost]
        public ActionResult Blog(blog blg)
        {
            return View();
        }

        [HttpGet]
        public ActionResult BlogDetails(int Id)
        {
            List<blog> lst = new List<blog>();
            Admin admin = new Admin();
            lst=admin.bindSingleBlog(Id);
            return View(lst);
        }
        [HttpPost]
        public ActionResult BlogDetails()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(User_ user)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User_ user)
        {
            string formName = "";
            string controller = "";
            Admin admin = new Admin();
            DataSet ds = admin.Login(user);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Session["UserName"] = ds.Tables[0].Rows[0]["Username"].ToString();
                formName = "Index";
                controller = "Admin";
            }
            else
            {
                TempData["Login"] = "Incorrect Email or Password";
                formName = "Login";
                controller = "Home";
            }
            return RedirectToAction(formName, controller);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Home");
           
        }
    }
}