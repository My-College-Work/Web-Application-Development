using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_DisConnected
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelTime.Visible = false;
            string conStr = WebConfigurationManager.ConnectionStrings["cinemaConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select Movie.name, Movie.Released, Timings.Slot\r\nfrom Movie Inner Join Timings on Movie.SId = Timings.Id;";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            try
            {
                using (con)
                {
                    con.Open();
                    da.Fill(ds, "Movie");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            GridViewMV.DataSource = ds.Tables["Movie"];
            GridViewMV.DataBind();

        }

        protected void btnAddTime_Click(object sender, EventArgs e)
        {
            PanelTime.Visible=true;
        }

        protected void btnCommitT_Click(object sender, EventArgs e)
        {
            string conStr = WebConfigurationManager.ConnectionStrings["cinemaConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Timings";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            try
            {
                using (con)
                {
                    con.Open();
                    da.Fill(ds, "Timings");
                    DataTable dt = ds.Tables["Timings"];
                    DataRow dr = dt.NewRow();
                    dr["Slot"] = tbSlot.Text;
                    dt.Rows.Add(dr);
                    da.Update(ds, "Timings");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}