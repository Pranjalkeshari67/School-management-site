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
        public List<blog> blogCategory()
        {
            AdminRepository repo = new AdminRepository();
            return repo.Blogcategory();
        }

        public List<blog> BlogsByCategory(int id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.BlogsByCategory(id);
        }
        public List<blog> BindSingleBlogAdmin(int id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.bindSingleBlogAdmin(id);
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

        public bool UpdateBlog(blog blg)
        {
            AdminRepository repo = new AdminRepository();
            return repo.UpdateBlog(blg);
        }

        public List<blog> CategoryList()
        {
            AdminRepository repo = new AdminRepository();
            return repo.CategoryList();
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

        public List<Teacher> Sublist()
        {
            AdminRepository repo = new AdminRepository();
            return repo.Sublist();
        }

        public List<Teacher> SingleTeacher(int tid)
        {
            AdminRepository repo = new AdminRepository();
            return repo.SingleTeacher(tid);
        }

        public bool UpdateTeacher(Teacher tech)
        {
            AdminRepository repo = new AdminRepository();
            return repo.UpdateTeacher(tech);
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

        public bool deletePhoto(int pid)
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
        public bool deleteTeacher(int tid)
        {
            AdminRepository repo = new AdminRepository();
            return repo.deleteteacher(tid);
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

        public List<Contact> adminContact()
        {
            AdminRepository repo = new AdminRepository();
            return repo.adminContact();
        }

        public bool DeleteContact(int id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.deleteContact(id);
        }

        public List<Photos> Eventphotos(int eid)
        {
            AdminRepository repo = new AdminRepository();
            return repo.Eventphotos(eid);
        }

        public bool NewsLetter(NewsLetter n)
            {
            AdminRepository repo = new AdminRepository();
            return repo.NewsLetter(n); 
            }

        public List<NewsLetter> showNewsLetter()
        {
            AdminRepository repo = new AdminRepository();
            return repo.showNewsLetter();
        }

        public bool DeleteNewsletter(int id)
        {
            AdminRepository repo = new AdminRepository();
            return repo.DeleteNewsletter(id);
        }


    }
}
