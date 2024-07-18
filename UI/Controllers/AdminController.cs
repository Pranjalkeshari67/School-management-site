using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntSchl_BOL.Models;
using IntSchl_BLL;
using System.IO;
using System.Data;
using Authentication.Controllers;

namespace UI.Controllers
{
    public class AdminController : AdminBaseController
    {
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

       


        //Blogs Section Start
        [HttpGet]
        public ActionResult addBlog()
        {
            int count1 = 0;
            Admin model = new Admin();
            List<SelectListItem> dropDownList = new List<SelectListItem>();
            DataSet ds = model.GetdropDownList();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    if (count1 == 0)
                    {
                        dropDownList.Add(new SelectListItem { Text = "--Select Blog Category--", Value = "0" });
                    }
                    dropDownList.Add(new SelectListItem { Text = Convert.ToString(r["Category"]), Value = Convert.ToString(r["Id"]) });
                    count1 = count1 + 1;
                }
            }
            ViewBag.dropDownList = dropDownList;
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

        public JsonResult DeleteBlog(int blogid)
        {
            Admin admin = new Admin();
            bool key = admin.deleteBlog(blogid);
            if (key)
            {
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("nok", JsonRequestBehavior.AllowGet);
            }
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
        public ActionResult allTeacher()
        {
            Admin admin = new Admin();
            List<Teacher> lst = new List<Teacher>();
            lst=admin.allTeacher();
            return View(lst);
        }
        [HttpPost]
        public ActionResult allTeacher(Teacher tech)
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
            List<Event> lst = new List<Event>();
            Admin admin = new Admin();
            lst = admin.allEvent();
            return View(lst);
        }
        [HttpPost]
        public ActionResult allEvents(Event ev)
        {
            return View();
        }

        public JsonResult DeleteEvents(int blogId)
        {
            Admin admin = new Admin();
            bool key = admin.deleteEvent(blogId);
            if(key)
            {
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("nok", JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult UpdateEvents()
        {
            return View();
        }
        [HttpGet]
        public ActionResult uploadPhotos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult uploadPhotos(Photos ph, List<HttpPostedFileBase> postedFile)
        {
            bool key=false;
            Admin admin = new Admin();
            foreach(var item in postedFile)
            {
                if (postedFile != null)
                {
                    ph.Photo = "/Content/Uploaded Images/" + Guid.NewGuid() + Path.GetExtension(item.FileName);
                    item.SaveAs(Path.Combine(Server.MapPath(ph.Photo)));
                }
                key = admin.uploadPhotos(ph);
               
            }
           if(key)
            {
                ViewBag.msg = "Uploaded Sucessfully"; 
            }
            else
            {
                ViewBag.msg = "NUploaded Sucessfully";
            }

            return View();
        }

        [HttpGet]
        public ActionResult allPhotos()
        {
            List<Photos> lst = new List<Photos>();
            Admin admin = new Admin();
            lst= admin.allPhotos();
            return View(lst);
        }
        [HttpPost]
        public ActionResult allPhotos(Photos ph)
        {
            return View();
        }

        
        public JsonResult DeletePhotos(int pid)
        {
            Admin admin = new Admin();
            bool key = admin.deletePhoto(pid);
            if(key)
            {
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("nok", JsonRequestBehavior.AllowGet);
            }
        }
       

    }
}