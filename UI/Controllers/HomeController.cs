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
        public ActionResult Index()
        {
            Admin admin = new Admin();
            ViewBag.carousel = admin.Carousel();
            ViewBag.lstAllEvents = admin.indexEvents();
            ViewBag.indexPhotos = admin.indexphotos();
            ViewBag.indexTeachers = admin.indexTeacher();
            ViewBag.indexBlog = admin.indexBlog();
            return View();
        }

        [HttpPost]
        public ActionResult Index( Event ev)
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
            List<Teacher> lst = new List<Teacher>(); 
            Admin admin = new Admin();
            lst=admin.allTeacher();
            return View(lst);
        }
        [HttpPost]
        public ActionResult Teachers(User_ user)
        {
            return View();
        }
        //Event section start
        [HttpGet]
        public ActionResult Events()
        {
            List<Event> lst = new List<Event>();
            Admin admin = new Admin();
           lst= admin.allEvent();
            return View(lst);
        }
        [HttpPost]
        public ActionResult Events(User_ user)
        {
            return View();
        }

        //Blog Section Strat

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

        //Blog Section end

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact cnt)
        {
            
            Admin admin = new Admin();
            bool key = admin.Contact(cnt);
            if(key)
            {
                ViewBag.Contactmsg = "Thank You For Submitting";
            }
            else
            {
                ViewBag.contactmsg = "Something Went Wrong";
            }
            return View();
        }




        //Login Logout Section
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

        //Login Logout Section
    }
}