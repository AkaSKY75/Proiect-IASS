using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Proiect
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SHA256 sha;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BDLB83I;Initial Catalog=IASS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Id 2 = " + Session["Id"]);

            if (Session["Id"] != null)
            {
                Anonymous_User.Visible = false;
                Logged_User.Visible = true;
            }
            //string[] utilizatori = File.ReadAllLines(Server.MapPath("~/Fisiere/") + "utilizatori.txt");
            //foreach(var line in utilizatori)
            //{
            //    string[] inregistrare = line.Split(',');
            //    DropDownList1.Items.Add(inregistrare[0]);
            //}
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            sha = SHA256.Create();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(TextBoxPWD.Text.Trim()));
            string base16 = "";
            for(var i = 0; i < hash.Length; i++)
            {
                switch((hash[i] >> 4) & 0x0F)
                {
                    case 0: base16 += "0";
                            break;
                    case 1: base16 += "1";
                            break;
                    case 2: base16 += "2";
                            break;
                    case 3: base16 += "3";
                            break;
                    case 4: base16 += "4";
                            break;
                    case 5: base16 += "5";
                            break;
                    case 6: base16 += "6";
                            break;
                    case 7: base16 += "7";
                            break;
                    case 8: base16 += "8";
                            break;
                    case 9: base16 += "9";
                            break;
                    case 10:base16 += "A";
                            break;
                    case 11:base16 += "B";
                            break;
                    case 12:base16 += "C";
                            break;
                    case 13:base16 += "D";
                            break;
                    case 14:base16 += "E";
                            break;
                    case 15:base16 += "F";
                            break;
                }
                switch (hash[i] & 0x0F)
                {
                    case 0: base16 += "0";
                            break;
                    case 1: base16 += "1";
                            break;
                    case 2: base16 += "2";
                            break;
                    case 3: base16 += "3";
                            break;
                    case 4: base16 += "4";
                            break;
                    case 5: base16 += "5";
                            break;
                    case 6: base16 += "6";
                            break;
                    case 7: base16 += "7";
                            break;
                    case 8: base16 += "8";
                            break;
                    case 9: base16 += "9";
                            break;
                    case 10:base16 += "A";
                            break;
                    case 11:base16 += "B";
                            break;
                    case 12:base16 += "C";
                            break;
                    case 13:base16 += "D";
                            break;
                    case 14:base16 += "E";
                            break;
                    case 15:base16 += "F";
                            break;
                }
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Users WHERE Username='"+TextBoxUSR.Text.Trim()+"' AND Password='"+base16+"'", con);
                dr = cmd.ExecuteReader();
                if(!dr.HasRows)
                {
                    string script = "var div = document.createElement(\"div\");div.id=\"popup\";div.style.width=\"100%\";div.style.height=\"100%\";div.style.position=\"absolute\";div.style.zIndex=\"1\";div.style.top=\"0\";div.style.left=\"0\";div.style.backgroundColor=\"rgba(0, 0, 0, 0.85)\";div.onclick=function(){this.remove()};document.querySelector('body').appendChild(div);div = document.createElement('div');div.style.backgroundColor=\"#E9ECEF\";div.style.width=\"50%\";div.style.borderRadius=\"25px\";div.style.position=\"absolute\"; div.innerHTML=\"<h1 style='text-align:center;'>Eroare!</h1><h2>Numele sau parola incorecte! Verificați datele introduse și reîncercați.</h2>\";document.getElementById('popup').appendChild(div);div.style.top=(document.querySelector('body').offsetHeight-div.offsetHeight)/2+\"px\";div.style.left=(document.querySelector('body').offsetWidth-div.offsetWidth)/2+\"px\";div.style.padding=\"0 5% 0 5%\";";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    dr.Read();
                    Session["Id"] = dr[0];
                    Response.Redirect("WebForm1.aspx");
                }

            }
            catch (Exception ex)
            {
                Label1.Text = "Nu se poate realiza conexiunea " + ex.Message;
            }
            finally
            {
                con.Close();
            }
            //string[] utilizatori = File.ReadAllLines(Server.MapPath("~/Fisiere/") + "utilizatori.txt");
            //foreach(var line in utilizatori)
            //{
            //    string[] inregistrare = line.Split(',');
            //    if ((DropDownList1.Text).Equals(inregistrare[0]))
            //    {
            //        if (TextBoxPWD.Text.Trim().Equals(inregistrare[1].Trim()))
            //        {
            //            Response.Redirect("Despre.aspx?utilizator=" + DropDownList1.Text.Trim());
            //        }
            //        else
            //        {
            //            string script = "alert(\"Parola incorecta!\");";
            //            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            //        }
            //    }
            //}
        }
    }
}