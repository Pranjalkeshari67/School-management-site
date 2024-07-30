using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntSchl_BOL.Models;
using IntSchl_DAL.Repository;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IntSchl_DAL.Repository
{
     public class AdminRepository
    {
         private SqlConnection con;
            public void connection()
            {
            string cs = ConfigurationManager.ConnectionStrings["conStr"].ToString();
              con = new SqlConnection(cs);
            }

          public bool insertBlog(blog blg)
        {
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "addBlog");
            cmd.Parameters.AddWithValue("@Heading", blg.heading);
            cmd.Parameters.AddWithValue("@Image", blg.image);
            cmd.Parameters.AddWithValue("@blogCategory", blg.blogcategory);
            cmd.Parameters.AddWithValue("@shortDesc", blg.shortdesc);
            cmd.Parameters.AddWithValue("@Description", blg.description);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            
            con.Close();
            if(i==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<blog> allBlogs()
        {
            List<blog> blgLst = new List<blog>();
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "AllBlogs");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    blog blg = new blog();
                    blg.id = Convert.ToInt32( dt.Rows[i]["Id"].ToString());
                    blg.heading = dt.Rows[i]["Heading"].ToString();
                    blg.image = dt.Rows[i]["Image"].ToString();
                    blg.postdate = dt.Rows[i]["PostDate"].ToString();
                    blg.shortdesc = dt.Rows[i]["shortDesc"].ToString();
                    blg.categoryname = dt.Rows[i]["categoryName"].ToString();
                    blgLst.Add(blg);
                }
            }
            con.Close();
            return blgLst;
        }


        public List<blog> Blogcategory()
        {
            connection();
            List<blog> lst = new List<blog>();
            SqlCommand cmd = new SqlCommand("blogOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "blogCategory");
            
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    blog blg = new blog();

                    blg.categoryname = dt.Rows[i]["categoryName"].ToString();
                    blg.catid =Convert.ToInt32( dt.Rows[i]["Id"].ToString());
                    blg.Count = dt.Rows[i]["Count"].ToString();
                    lst.Add(blg);
                }
            }
            con.Close();
            return lst;
        }

        public List<blog> BlogsByCategory(int id)
        {
            List<blog> lst = new List<blog>();
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "BlogByCategory");
            cmd.Parameters.AddWithValue("@blogCategory", id);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    blog bg = new blog();
                    bg.id =Convert.ToInt32 (dt.Rows[i]["Id"].ToString());
                    bg.image = dt.Rows[i]["Image"].ToString();
                    bg.heading = dt.Rows[i]["Heading"].ToString();
                    bg.shortdesc = dt.Rows[i]["shortDesc"].ToString();
                    bg.postdate = dt.Rows[i]["Postdate"].ToString();
                    bg.categoryname = dt.Rows[i]["categoryName"].ToString();
                    lst.Add(bg);
                }
            }
            con.Close();
            return lst;
        }
        public List<blog> bindSingleBlogAdmin(int id)
        {
            List<blog> lst = new List<blog>();
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("proc_id", "SingleBlog");
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    blog bg = new blog();
                    bg.id =Convert.ToInt32 (dt.Rows[i]["Id"].ToString());
                    bg.image = dt.Rows[i]["Image"].ToString();
                    bg.heading = dt.Rows[i]["Heading"].ToString();
                    bg.shortdesc = dt.Rows[i]["shortDesc"].ToString();
                    bg.description = dt.Rows[i]["Description"].ToString();
                    bg.blogcategory =Convert.ToInt32( dt.Rows[i]["blogCategory"].ToString());
                    bg.image = dt.Rows[i]["Image"].ToString();
                    lst.Add(bg);
                }
            }
            con.Close();
            return lst;
        }

        public List<blog> CategoryList()
        {
            List<blog> lst = new List<blog>();
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("proc_id", "categoryList");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    blog bg = new blog();
                    bg.catid =Convert.ToInt32( dt.Rows[i]["Id"].ToString());
                    bg.categoryname = dt.Rows[i]["categoryName"].ToString();
                    lst.Add(bg);
                }
            }
            con.Close();
            return lst;
        }

        public List<blog> bindSingleBlog(int id)
        {
            connection();
            List<blog> singleBlog = new List<blog>();
            SqlCommand cmd = new SqlCommand("blogOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "blogDetails");
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    blog blg = new blog();
                  
                    blg.heading = dt.Rows[i]["Heading"].ToString();
                    blg.image = dt.Rows[i]["Image"].ToString();
                    blg.postdate = dt.Rows[i]["PostDate"].ToString();
                    blg.description = dt.Rows[i]["Description"].ToString();
                    
                  
                    singleBlog.Add(blg);
                }
            }
            con.Close();
            return singleBlog;
        }

        public bool deleteBlog(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "deleteBlog");
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateBlog(blog bg)
        {
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "updateBlog");
            cmd.Parameters.AddWithValue("@Id", bg.id);
            cmd.Parameters.AddWithValue("@Heading", bg.heading);
            cmd.Parameters.AddWithValue("@Image", bg.image);
            cmd.Parameters.AddWithValue("@blogCategory", bg.blogcategory);
            cmd.Parameters.AddWithValue("@shortDesc", bg.shortdesc);
            cmd.Parameters.AddWithValue("@Description", bg.description);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet Login(User_ user)
        {
            connection();
            SqlCommand cmd = new SqlCommand("Login",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", user.loginUserName);
            cmd.Parameters.AddWithValue("@Password", user.LoginUserPassword);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public bool addTeacher(Teacher tech)
        {
            connection();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "addTeacher");
            cmd.Parameters.AddWithValue("@Name", tech.Name);
            cmd.Parameters.AddWithValue("@Photo", tech.Photo);
            cmd.Parameters.AddWithValue("@subid", tech.subid);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Teacher> Sublist()
        {
            List<Teacher> lst = new List<Teacher>();
            connection();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("proc_id", "Sublist");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Teacher tech = new Teacher();
                    tech.subid = Convert.ToInt32(dt.Rows[i]["subid"].ToString());
                    tech.Subject_name = dt.Rows[i]["Subject_name"].ToString();
                    lst.Add(tech);
                }
            }
            con.Close();
            return lst;
        }

        public List<Teacher> allTeacher()
        {
            List<Teacher> lst = new List<Teacher>();
            connection();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "showTeachers");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Teacher t = new Teacher();
                    t.tid = Convert.ToInt32( dt.Rows[i]["tid"].ToString());
                    t.Name = dt.Rows[i]["Name"].ToString();
                    t.Photo = dt.Rows[i]["Photo"].ToString();
                    t.Subject_name = dt.Rows[i]["Subject_name"].ToString();
                    lst.Add(t);
                }
            }
            return lst;
        }

        public List<Teacher> SingleTeacher(int tid)
        {
            connection();
            List<Teacher> lst = new List<Teacher>();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "SingleTeacher");
            cmd.Parameters.AddWithValue("@tid", tid);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Teacher tech = new Teacher();
                    tech.tid =Convert.ToInt32( dt.Rows[i]["tid"].ToString());
                    tech.Name = dt.Rows[i]["Name"].ToString();
                    tech.Photo = dt.Rows[i]["Photo"].ToString();
                    tech.subid =Convert.ToInt32( dt.Rows[i]["subid"].ToString());
                    lst.Add(tech);
                }
            }
            con.Close();
            return lst;
        }

        public bool UpdateTeacher( Teacher tech)
        {
            connection();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "updateTeacher");
            cmd.Parameters.AddWithValue("@tid", tech.tid);
            cmd.Parameters.AddWithValue("@Name", tech.Name);
            cmd.Parameters.AddWithValue("@Photo", tech.Photo);
            cmd.Parameters.AddWithValue("@subid", tech.subid);
            
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool deleteteacher(int tid)
        {
            connection();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "deleteTeacher");
            cmd.Parameters.AddWithValue("@tid", tid);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addEvent(Event ev)
        {
            connection();
            SqlCommand cmd = new SqlCommand("eventOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "addEvent");
            cmd.Parameters.AddWithValue("@eventName", ev.eventName);
            cmd.Parameters.AddWithValue("@eventPhoto", ev.eventPhoto);
            cmd.Parameters.AddWithValue("@eventDate", ev.eventDate);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Event> allEvent()
        {
            List<Event> lst = new List<Event>();
            connection();
            SqlCommand cmd = new SqlCommand("eventOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "showAllEvents");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Event ev = new Event();
                    ev.eid =Convert.ToInt32(dt.Rows[i]["eId"].ToString());
                    ev.eventName = dt.Rows[i]["eventName"].ToString();
                    ev.eventPhoto = dt.Rows[i]["eventPhoto"].ToString();
                    ev.eventDate = dt.Rows[i]["eventDate"].ToString();
                    lst.Add(ev);
                }
            }
            con.Close();
            return lst;
        }

        public bool deleteEvent(int id )
        {
            connection();
            SqlCommand cmd = new SqlCommand("eventOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "deleteEvent");
            cmd.Parameters.AddWithValue("@eid", id);

            con.Open();
            int key = cmd.ExecuteNonQuery();
            con.Close();
            if(key>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet GetdropDownList()
        {
            connection();
            SqlCommand cmd = new SqlCommand("STP_GetdropDownList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public bool uploadPhotos(Photos ph)
        {
            connection();
            SqlCommand cmd = new SqlCommand("photoOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "addPhotos");
            cmd.Parameters.AddWithValue("@Photo", ph.Photo);
            cmd.Parameters.AddWithValue("@eid", ph.eid);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Photos> allPhotos()
        {
            List<Photos> lst = new List<Photos>();
            connection();
            SqlCommand cmd = new SqlCommand("photoOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "allPhotos");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Photos ph = new Photos();
                    ph.pid =Convert.ToInt32( dt.Rows[i]["Pid"].ToString());
                    ph.Photo = dt.Rows[i]["Photo"].ToString();
                    ph.eventName = dt.Rows[i]["eventName"].ToString();
                    lst.Add(ph);
                }
            }
            con.Close();

            return lst;
        }

        public bool deletePhotos(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("photoOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "deletePhotos");
            cmd.Parameters.AddWithValue("@Pid", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public List<Photos> Carousel()
        //{
        //    connection();
        //    SqlCommand cmd = new SqlCommand("",con);

        //}

        public List<Event> indexEvents()
        {
            List<Event> lst = new List<Event>();
            connection();
            SqlCommand cmd = new SqlCommand("eventOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "IndexEvent");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Event ev = new Event();
                    ev.eid =Convert.ToInt32( dt.Rows[i]["eId"].ToString());
                    ev.eventName = dt.Rows[i]["eventName"].ToString();
                    ev.eventPhoto = dt.Rows[i]["eventPhoto"].ToString();
                    ev.eventDate = dt.Rows[i]["eventDate"].ToString();
                    lst.Add(ev);
                }
            }
            con.Close();
            return (lst);
        }

        public List<Photos> indexCarousel()
        {
            List<Photos> lst = new List<Photos>();
            connection();
            SqlCommand cmd = new SqlCommand("photoOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "IndexCarousel");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Photos ph = new Photos();
                    
                    
                    ph.Photo = dt.Rows[i]["Photo"].ToString();
                    lst.Add(ph);
                    
                }
            }
            con.Close();
            return (lst);
        }

        public List<Photos> indexPhotos()
        {
            List<Photos> lst = new List<Photos>();
            connection();
            SqlCommand cmd = new SqlCommand("photoOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "indexPhotos");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Photos ph = new Photos();


                    ph.Photo = dt.Rows[i]["Photo"].ToString();
                    lst.Add(ph);

                }
            }
            con.Close();
            return (lst);
        }

        public List<Teacher> indexTeachers()
        {
            List<Teacher> lst = new List<Teacher>();
            connection();
            SqlCommand cmd = new SqlCommand("teacherOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "indexTeachers  ");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Teacher th = new Teacher();


                    th.Photo = dt.Rows[i]["Photo"].ToString();
                    th.Name = dt.Rows[i]["Name"].ToString();
                    th.Subject_name = dt.Rows[i]["Subject_name"].ToString();
                    lst.Add(th);
                }
            }
            con.Close();
            return (lst);
        }



        public List<blog> indexblog()
        {
            List<blog> lst = new List<blog>();
            connection();
            SqlCommand cmd = new SqlCommand("blogOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "indexBlogs");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    blog bg = new blog();


                    bg.id =Convert.ToInt32( dt.Rows[i]["Id"].ToString());
                    bg.image = dt.Rows[i]["Image"].ToString();
                    bg.heading = dt.Rows[i]["Heading"].ToString();
                    bg.shortdesc = dt.Rows[i]["shortDesc"].ToString();
                    bg.postdate = dt.Rows[i]["PostDate"].ToString();
                    lst.Add(bg);
                }
            }
            con.Close();
            return (lst);
        }

        public bool Contact(Contact cnt) 
        {
            List<Contact> lst = new List<Contact>();
            connection();
            SqlCommand cmd = new SqlCommand("contactOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "addContact");
            cmd.Parameters.AddWithValue("@Name", cnt.name);
            cmd.Parameters.AddWithValue("@Email", cnt.email);
            cmd.Parameters.AddWithValue("@Phone", cnt.phone);
            cmd.Parameters.AddWithValue("@message", cnt.cmessage);
            con.Open();
            int i = cmd.ExecuteNonQuery();
         
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Contact> adminContact()
        {
            List<Contact> lst = new List<Contact>();
            connection();
            SqlCommand cmd = new SqlCommand("contactOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("proc_id", "allContact");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    Contact ct = new Contact();
                    ct.id =Convert.ToInt32( dt.Rows[i]["id"].ToString());
                    ct.name = dt.Rows[i]["Name"].ToString();
                    ct.email = dt.Rows[i]["Email"].ToString();
                    ct.phone = dt.Rows[i]["Phone"].ToString();
                    ct.cmessage = dt.Rows[i]["message"].ToString();
                    lst.Add(ct);
                }
            }
            con.Close();

            return lst;
        }

        public bool deleteContact(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("contactOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "deleteContact");
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Photos> Eventphotos(int eid)
        {
            List<Photos> lst = new List<Photos>();
            connection();
            SqlCommand cmd = new SqlCommand("photoOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "EventPhotos");
            cmd.Parameters.AddWithValue("@eid", eid);


            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Photos ph = new Photos();
                   
                    ph.Photo = dt.Rows[i]["Photo"].ToString();
                    ph.eventName=dt.Rows[i]["eventName"].ToString();
                    
                    lst.Add(ph);
                }
            }
            con.Close();

            return lst;
        }

        public bool NewsLetter(NewsLetter n)
        {
            
            connection();
            SqlCommand cmd = new SqlCommand("NewsLetterOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "InsertNewsLetter");
            cmd.Parameters.AddWithValue("@id", n.id);
            cmd.Parameters.AddWithValue("@Email", n.newsEmail);
            
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<NewsLetter> showNewsLetter()
        {
            List<NewsLetter> lst = new List<NewsLetter>();
            connection();
            SqlCommand cmd = new SqlCommand("NewsLetterOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("proc_id", "allNewsletter");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    NewsLetter nl = new NewsLetter();
                    nl.id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                    nl.newsEmail = dt.Rows[i]["Email"].ToString();

                    lst.Add(nl);
                }
            }
            con.Close();

            return lst;
            
        }

        public bool DeleteNewsletter(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("NewsLetterOperations",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "deleteNewsletter");
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
