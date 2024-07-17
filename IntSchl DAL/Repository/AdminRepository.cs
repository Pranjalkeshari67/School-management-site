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

        public List<Teacher> allTeacher(Teacher tech)
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

        public bool addEvent(Event ev)
        {
            connection();
            SqlCommand cmd = new SqlCommand("eventOperations");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proc_id", "addEvent");
            cmd.Parameters.AddWithValue("@eventName", ev.eventName);
            cmd.Parameters.AddWithValue("@eventPhoto", ev.eventPhoto);
            cmd.Parameters.AddWithValue("@eventDate", ev.eventDate);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>1)
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
