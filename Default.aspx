<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        Prikaz sedišta autobusa<br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 164px">Broj sedišta</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 164px">Ime i prezime</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 164px">E-mail</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Pošalji" Height="21px" OnClick="Button1_Click" Width="50px" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </div>

</asp:Content>
