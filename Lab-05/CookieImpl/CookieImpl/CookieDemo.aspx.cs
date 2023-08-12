using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieImpl
{
    public partial class CookieDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string value= input.Text;
            HttpCookie cookie = Request.Cookies["User"];
            if(cookie == null)
            {
                cookie = new HttpCookie("User");
            }
            cookie["name"] = value;
            cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Add(cookie);

            HttpCookie cookies = Request.Cookies["User"];
            lblDispay.Text = "<b>Name saved to cookie!</b>";
        }

        protected void btnRetrive_Click(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["User"];
            if(cookies == null)
            {
                lblDispay.Text = "<b> Cookies not found! </b>";
            }
            else
            { 
                lblDispay.Text = "<b> Hello, "+ cookies["name"] +"! Welcome back!!</b>";
            }
        }

        protected void btnDeleteCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["User"];
            if(cookies != null)
            {
                cookies.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookies);
                lblDispay.Text = "<b> Cookies deleted successfully! </b>";
            }
            else
            {
                lblDispay.Text = "<b> Cookies not found! </b>";
            }
        }
    }
}