<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminPageForWebmaster.aspx.cs" Inherits="MyProject.AdminPageForWebmaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div id="adminLogin">
        <asp:LinkButton ID="LinkadminLogOut" runat="server" OnClick="LinkadminLogOut_Click">Log Out</asp:LinkButton>
    </div>
    <asp:Label ID="lblTxt1" runat="server" Text="Vid 1"></asp:Label>
    <asp:TextBox ID="txtVid1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblTxt2" runat="server" Text="Vid 2"></asp:Label>
    <asp:TextBox ID="txtVid2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblTxt3" runat="server" Text="Vid 3"></asp:Label>
    <asp:TextBox ID="txtVid3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblTxt4" runat="server" Text="Vid 4"></asp:Label>
    <asp:TextBox ID="txtVid4" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblTxt5" runat="server" Text="Vid 5"></asp:Label>
    <asp:TextBox ID="txtVid5" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblTxt6" runat="server" Text="Vid 6"></asp:Label>
    <asp:TextBox ID="txtVid6" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="עדכון" OnClick="btnUpdate_Click" />
    <br />
    <asp:Button ID="btnDelete" runat="server" Text="מחיקה" OnClick="btnDelete_Click" />

</asp:Content>
