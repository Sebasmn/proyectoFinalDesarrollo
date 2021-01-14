<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Rectorado.aspx.cs" Inherits="Rectorado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    Rectorado</p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="36px" OnClick="Button1_Click" Text="Generar" Width="117px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
</p>
    <p>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
    <p>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

