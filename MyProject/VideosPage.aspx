<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="VideosPage.aspx.cs" Inherits="MyProject.VideosPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <br />
    <iframe id="if1" runat="server" width="560" height="315" frameborder="0" allowfullscreen autoautopause="1" controls controlslist="nodownload"></iframe>
    <iframe id="if2" runat="server" width="560" height="315" frameborder="0" allowfullscreen></iframe>
    <iframe id="if3" runat="server" width="560" height="315" frameborder="0" allowfullscreen></iframe>
    <br />
    <br />
    <iframe id="if4" runat="server" width="560" height="315" frameborder="0" allowfullscreen></iframe>
    <iframe id="if5" runat="server" width="560" height="315" frameborder="0" allowfullscreen></iframe>
    <iframe id="if6" runat="server" width="560" height="315" frameborder="0" allowfullscreen></iframe>
</asp:Content>
