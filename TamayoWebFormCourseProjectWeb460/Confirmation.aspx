<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="TamayoWebFormCourseProjectWeb460.Confirmation" %>
<%@ PreviousPageType VirtualPath="~/AccountDetails.aspx" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Account Confirmation"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label2" runat="server" Text="City: "></asp:Label>
    <asp:Label ID="citylbl" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="State: "></asp:Label>
    <asp:Label ID="statelbl" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Favorite Programming Language: "></asp:Label>
    <asp:Label ID="favLanguagelbl" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Least Favorite Programming Language: "></asp:Label>
    <asp:Label ID="leastFavLanuagelbl" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Date of Last Program Completed: "></asp:Label>
    <asp:Label ID="datelbl" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="confirm" runat="server" Text="Confirm and Submit" />
</asp:Content>

