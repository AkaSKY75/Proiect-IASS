using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect
{
    public partial class Despre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String nume = Request.QueryString["utilizator"];
            TextBox1.Text = nume;
        }
    }
}