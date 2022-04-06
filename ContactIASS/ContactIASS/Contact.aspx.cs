using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.Net;

namespace ContactIASS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage Msg = new MailMessage();
                //Sender e-mail address.
                Msg.From = new MailAddress(txtemail.Text);
                //Recipient e-mail address.
                Msg.To.Add("andreipheonix@gmail.com");


                //Meaages Subject
                Msg.Subject = "Proiect-IASS";
                StringBuilder sb = new StringBuilder();
                sb.Append("Name :" + txtname.Text + "\r\n");
                sb.Append("Contact:" + txtcontact.Text + "\r\n");
                sb.Append("Email:" + txtemail.Text + "\r\n");
                sb.Append("Message:" + txtmessage.Text + "\r\n");

                Msg.Body = sb.ToString();
                // SMTP server IP.
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential("proiectiass@gmail.com", "Abcd1234!");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
                //Mail Message
                Response.Write("<Script>alert('Email-ul a fost trimis cu succes!.')</Script>");
                // Clear the textbox values
                txtname.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtmessage.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }

        }
    }
}