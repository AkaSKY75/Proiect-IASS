<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proiect.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 494px;
            height: 29px;
        }
        .auto-style3 {
            height: 26px;
            width: 494px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td id="login_label" class="auto-style4" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Autentificare"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="user_label" class="auto-style2">Utilizator</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="201px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td id="password_label" class="auto-style3">Parola</td>
                <td class="auto-style1">
                    <asp:TextBox  ID="TextBoxPWD" runat="server" Width="190px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="login_button" class="auto-style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Autentificare" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
