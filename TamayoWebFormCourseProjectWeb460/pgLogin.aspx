<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pgLogin.aspx.cs" Inherits="TamayoWebFormCourseProjectWeb460.pgLogin" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
&nbsp;&nbsp;
    <asp:Button ID="btnCreateAccount" runat="server" Text="Create Account" Width="142px" OnClick="btnCreateAccount_Click" />
&nbsp;
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>