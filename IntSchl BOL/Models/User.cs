using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSchl_BOL.Models
{
   
       public class User_

        {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }



        public string loginUserName { get; set; }
        public string LoginUserPassword { get; set; }
        }

    public class blog
    {
        public int id { get; set; }
        public string image { get; set; }
        public string heading { get; set; }
        public int blogcategory { get; set; }
        public string categoryname { get; set; }
        public int catid { get; set; }
        public string shortdesc { get; set; }
        public string description { get; set; }
        public string postdate { get; set; }
        public string Count { get; set; }
    }


    public class Teacher
    {
        public int tid { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int subid { get; set; }
        public string Subject_name { get; set; }
    }

    public class Event
    {
        public int eid { get; set; }
        public string eventName { get; set; }
        public string eventPhoto { get; set; }
        public string eventDate { get; set; }
        public List<Event> lstAllEvents { get; set; }
    }

    public class Photos
    {
        public int pid { get; set; }
        public string Photo { get; set; }
        public int eid { get; set; }
        public string eventName { get; set; }
    }

    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string cmessage { get; set; }
    }

    public class NewsLetter
    {
        public int id { get; set; }
        public string newsEmail { get; set; }
    }


     


}
