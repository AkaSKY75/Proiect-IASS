<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proiect.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            height: 26px;
            }
        .auto-style4 {
            height: 29px;
        }
        .input_rounded{
            border-radius: 25px;
            border: 0;
            outline: none;
            padding-left: 5%;
            padding-right: 5%;
        }
        table{
            background-color: rgba(0, 0, 0, 0.25);
            border-radius: 25px;
            height: 100%;
        }
        td{
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table>
            <tr>
                <td id="login_label">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Autentificare"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="user_textbox">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Utilizator"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Width="190px" CssClass="input_rounded"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="password_textbox">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Parola"></asp:Label>
                    <asp:TextBox  ID="TextBoxPWD" runat="server" Width="190px" TextMode="Password" CssClass="input_rounded"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="login_button">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Autentificare" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
