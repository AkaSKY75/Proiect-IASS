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
        SqlConnection con = new SqlConnection("Data Source=WINCTRL-PLKDE1R;Initial Catalog=IASS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
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
            string base64 = "";
            for(var i = 0; i < hash.Length; i++)
            {
                switch((hash[i] >> 4) & 0x0F)
                {
                    case 0: base64 += "0";
                            break;
                    case 1: base64 += "1";
                            break;
                    case 2: base64 += "2";
                            break;
                    case 3: base64 += "3";
                            break;
                    case 4: base64 += "4";
                            break;
                    case 5: base64 += "5";
                            break;
                    case 6: base64 += "6";
                            break;
                    case 7: base64 += "7";
                            break;
                    case 8: base64 += "8";
                            break;
                    case 9: base64 += "9";
                            break;
                    case 10:base64 += "A";
                            break;
                    case 11:base64 += "B";
                            break;
                    case 12:base64 += "C";
                            break;
                    case 13:base64 += "D";
                            break;
                    case 14:base64 += "E";
                            break;
                    case 15:base64 += "F";
                            break;
                }
                switch (hash[i] & 0x0F)
                {
                    case 0: base64 += "0";
                            break;
                    case 1: base64 += "1";
                            break;
                    case 2: base64 += "2";
                            break;
                    case 3: base64 += "3";
                            break;
                    case 4: base64 += "4";
                            break;
                    case 5: base64 += "5";
                            break;
                    case 6: base64 += "6";
                            break;
                    case 7: base64 += "7";
                            break;
                    case 8: base64 += "8";
                            break;
                    case 9: base64 += "9";
                            break;
                    case 10:base64 += "A";
                            break;
                    case 11:base64 += "B";
                            break;
                    case 12:base64 += "C";
                            break;
                    case 13:base64 += "D";
                            break;
                    case 14:base64 += "E";
                            break;
                    case 15:base64 += "F";
                            break;
                }
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Users WHERE Utilizator='"+TextBoxUSR.Text.Trim()+"' AND Parola='"+base64+"'", con);
                dr = cmd.ExecuteReader();
                if(!dr.HasRows)
                {
                    string script = "var div = document.createElement(\"div\");div.id=\"popup\";div.style.width=\"100%\";div.style.height=\"100%\";div.style.position=\"absolute\";div.style.zIndex=\"1\";div.style.top=\"0\";div.style.left=\"0\";div.style.backgroundColor=\"rgba(0, 0, 0, 0.85)\";div.onclick=function(){this.remove()};document.querySelector('body').appendChild(div);div = document.createElement('div');div.style.backgroundColor=\"#E9ECEF\";div.style.width=\"50%\";div.style.borderRadius=\"25px\";div.style.position=\"absolute\"; div.innerHTML=\"<h1 style='text-align:center;'>Eroare!</h1><h2>Numele sau parola incorecte! Verificați datele introduse și reîncercați.</h2>\";document.getElementById('popup').appendChild(div);div.style.top=(document.querySelector('body').offsetHeight-div.offsetHeight)/2+\"px\";div.style.left=(document.querySelector('body').offsetWidth-div.offsetWidth)/2+\"px\";div.style.padding=\"0 5% 0 5%\";";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

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