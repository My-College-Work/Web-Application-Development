using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO
{
    public partial class student_crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ShowStudents()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["studentConnection"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from Student";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewStu.DataSource = rdr;
                    GridViewStu.DataBind();
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowStudents();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["studentConnection"].ConnectionString;
            string query = "insert into Student (Name, DOB) values (@Name, @DOB)";
            try
            {
                using (con)
                {
                    using(SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@Name", "Luffy");
                        cmd.Parameters.AddWithValue("@DOB", "1997-07-25");
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
            ShowStudents() ;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["studentConnection"].ConnectionString;
            string query = "delete from Student where Name='Luffy'";
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
            ShowStudents();
        }
    }
}