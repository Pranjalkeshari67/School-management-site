using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntSchl_BOL.Models;
using IntSchl_DAL.Repository;
using System.Data;



namespace IntSchl_BLL
{
   public class Admin
   {
        //public int Id { get; set; }
        //public string eventName { get; set; }
        //public string eventPhoto { get; set; }
        //public string eventDate { get; set; }
        //public List<Event> lstAllEvents { get; set; }

        public bool addBlog(blog blg)
     {
            AdminRepository repo = new AdminRepository();
            return repo.insertBlog(blg);
     }

        public List<blog> allBlog()
        {
            AdminRepository repo = new AdminRepository();
            return repo.allBlogs();
        }

        public List<blog> bindSingleBlog(int Id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.bindSingleBlog(Id);
        }

        public bool deleteBlog(int id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.deleteBlog(id);
        }

        public bool addTeacher(Teacher tech)
        {
            AdminRepository repo = new AdminRepository();
            return repo.addTeacher(tech);
        }

        public List<Teacher> allTeacher()
        {
            AdminRepository repo = new AdminRepository();
            return repo.allTeacher();
        }

        public bool addEvent(Event ev)
        {
            AdminRepository repo = new AdminRepository();
            return repo.addEvent(ev);
        }

        public List<Event> allEvent()
        {
            AdminRepository repo = new AdminRepository();
            return repo.allEvent();

        }

        public bool deleteEvent(int id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.deleteEvent(id);

        }

        public DataSet Login(User_ user)
        {
            AdminRepository repo = new AdminRepository();
            return repo.Login(user);
        }

        //
        public DataSet GetdropDownList()
        {
            AdminRepository adr = new AdminRepository();
            DataSet ds = adr.GetdropDownList();
            return ds;
        }


        public bool uploadPhotos(Photos ph)
        {
            AdminRepository repo = new AdminRepository();
            return repo.uploadPhotos(ph);
        }

        public List<Photos> allPhotos()
        {
            AdminRepository repo = new AdminRepository();
            return repo.allPhotos();
        }

        public bool deletePhoto(int pid )
        {
            AdminRepository repo = new AdminRepository();
            return repo.deletePhotos(pid);
        }

        public List<Event> indexEvents()
        {
            AdminRepository repo = new AdminRepository();
            return repo.indexEvents();
        }

        public List<Photos> Carousel()
        {
            AdminRepository repo = new AdminRepository();
            return repo.indexCarousel();
        }

        public List<Photos> indexphotos()
        {
            AdminRepository repo = new AdminRepository();
            return repo.indexPhotos();
        }

        public List<Teacher> indexTeacher()
        {
            AdminRepository repo = new AdminRepository();
            return repo.indexTeachers();
        }

        public List<blog> indexBlog()
        {
            AdminRepository repo = new AdminRepository();
            return repo.indexblog();
        }

        public bool Contact(Contact cnt)
        {
            AdminRepository repo = new AdminRepository();
            return repo.Contact(cnt);
        }


    }
}
