using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void About_Click(object sender, EventArgs e)
        {
            Response.Redirect("Despre.aspx");
        }

        protected void Contact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Despre.aspx");
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}