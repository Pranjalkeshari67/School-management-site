using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntSchl_BOL.Models;
using IntSchl_BLL;
using System.IO;

namespace UI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        //Blogs Section Start
        [HttpGet]
        public ActionResult addBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addBlog(blog blg,HttpPostedFileBase postedFile)
        {
            if (postedFile != null)
            {
                blg.image = "/Content/Uploaded Images/" + Guid.NewGuid() + Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(Path.Combine(Server.MapPath(blg.image)));
            }
            Admin admin = new Admin();
            bool key = admin.addBlog(blg);

            return View();
        }

        [HttpGet]
        public ActionResult allBlogs(blog blg)
        {
            List<blog> lst = new List<blog>();
            Admin admin = new Admin();
             lst = admin.allBlog();
            return View(lst);
        }
        [HttpPost]
        public ActionResult allBlogs()
        {
            return View();
        }

        public ActionResult DeleteBlog(int id)
        {
            return View();
        }

        public ActionResult UpdateBlog(int id)
        {
            return View();
        }

        public ActionResult UpdateBlog(blog user)
        {
            return View();
        }
        //Blogs Section End



        //Teachers Section
        [HttpGet]
        public ActionResult addTeacher()
        {

            return View();
        }
        [HttpPost]
        public ActionResult addTeacher(Teacher tech, HttpPostedFileBase postedFile)
        {

            if (postedFile != null)
            {
                tech.Photo = "/Content/Uploaded Images/" + Guid.NewGuid() + Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(Path.Combine(Server.MapPath(tech.Photo)));
            }
            Admin admin = new Admin();
            bool key = admin.addTeacher(tech);

            return View();
        }

        [HttpGet]
        public ActionResult allTeacher(Teacher tech)
        {
            Admin admin = new Admin();
            List<Teacher> lst = new List<Teacher>();
            lst=admin.allTeacher(tech);
            return View(lst);
        }
        [HttpPost]
        public ActionResult allTeacher()
        {
            return View();
        }

        public ActionResult DeleteTeacher()
        {
            return View();
        }

        public ActionResult UpdateTeacher()
        {
            return View();
        }


        //Classes Section

        [HttpGet]
        public ActionResult addEvents()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addEvents(Event ev,HttpPostedFileBase postedFile)
        {
            if (postedFile != null)
            {
                ev.eventPhoto = "/Content/Uploaded Images/" + Guid.NewGuid() + Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(Path.Combine(Server.MapPath(ev.eventPhoto)));
            }
            Admin admin = new Admin();
            bool key = admin.addEvent(ev);
            return View();
        }
        [HttpGet]
        public ActionResult allEvents()
        {
            return View();
        }
        [HttpPost]
        public ActionResult allEvents(Event ev)
        {
            List<Event> lst = new List<Event>();
            Admin admin = new Admin();
            lst=admin.allEvent(ev);
            return View(lst);
        }

        public ActionResult DeleteEvents()
        {
            return View();
        }

        public ActionResult UpdateEvents()
        {
            return View();
        }


    }
}