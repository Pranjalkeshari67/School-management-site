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


    }
}
