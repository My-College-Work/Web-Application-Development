using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionImpl
{
    public partial class Items : System.Web.UI.Page 
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> MENU = new Dictionary<string, int>
            {
                { "pizza", 120 },
                { "burger", 60 },
                { "vada_pav", 20 },
                { "coffe", 30 },
                { "tea", 10 },
                { "french_fries", 40 },
                { "cold_drink", 50 },
            };
            List<string> listItems
                    = new List<string>();
            int bill = 0;
            foreach (ListItem item in menu.Items)
            {
                if (item.Selected) {
                    listItems.Add((string)item.Text);
                    bill += MENU[(string)item.Value];
                }
            }
            Session["order"] = listItems;
            Session["bill"] = bill;
            Response.Redirect("~/Final.aspx");
        }
    }
}