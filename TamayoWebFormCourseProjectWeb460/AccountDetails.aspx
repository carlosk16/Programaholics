<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="TamayoWebFormCourseProjectWeb460.AccountDetails" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Account Details"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label2" runat="server" Text="Search User by Username: "></asp:Label>
<asp:TextBox ID="txtUserSearch" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    <br />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label3" runat="server" Text="City:"></asp:Label>
<asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
<asp:Label ID="Label4" runat="server" Text="State: "></asp:Label>
<asp:TextBox ID="txtState" runat="server" Width="28px"></asp:TextBox>
<asp:Label ID="Label5" runat="server" Text="Favorite Programming Language: "></asp:Label>
<asp:TextBox ID="txtFavLanguage" runat="server"></asp:TextBox>
<asp:Label ID="Label6" runat="server" Text="Least Favorite Programming Language:"></asp:Label>
<asp:TextBox ID="txtLeastFavLanguage" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Date of Last Program Completed: "></asp:Label>
    <asp:TextBox ID="txtDate" runat="server" Width="94px"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update Account Information" Width="176px" PostBackUrl="~/confirmation.aspx" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Delete Account" />
&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Export Stats" />
</asp:Content>


