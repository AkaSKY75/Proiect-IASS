<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ContactIASS.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Form</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/431ce73e6f.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="2.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <div class="contact-parent row">
                <div class="contact-child child1 col-6">
                    <p>
                        <i class="fas fa-map-marker-alt"></i> Adresa<br />
                        <span>
                            Complexul Studentesc, Caminul C19
                            <br />
                            Timisoara, Romania
                        </span>
                    </p>

                    <p>
                        <i class="fas fa-phone-alt"></i> Numar de telefon <br />
                        <span>
                            0712345678
                        </span>
                    </p>

                    <p>
                        <i class="far fa-envelope"></i> Suport general <br />
                        <span>
                            proiectiass@gmail.com
                        </span>
                    </p>
                </div>

                <div class="contact-child child2 col-6">
                     <div class="inside-contact">
                         <h2>Contacteaza-ne</h2>
                         <h3>
                             <asp:Label ID="confirm" runat="server" Text=""></asp:Label>
                         </h3>

                         <p>Nume *</p>
                         <asp:TextBox ID="txtname" runat="server" Required="required"></asp:TextBox>

                         <p>Telefon *</p>
                         <asp:TextBox ID="txtcontact" runat="server" Required="required"></asp:TextBox>

                         <p>Email *</p>
                         <asp:TextBox ID="txtemail" runat="server" Required="required"></asp:TextBox>

                         <p>Mesaj *</p>
                         <asp:TextBox ID="txtmessage" runat="server" Required="required" TextMode="MultiLine" Rows="4"></asp:TextBox>

                         <asp:Button ID="btnsubmit" runat="server" Text="Trimite" OnClick="btnsubmit_Click" />
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
