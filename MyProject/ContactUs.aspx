<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="MyProject.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div id="contactUs">
        <asp:Label ID="lblnameCompeny" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="txtMail" runat="server" BackColor="#CCCCCC" BorderColor="#333333" BorderStyle="Inset" Height="241px" TextMode="MultiLine" Width="579px">הקלד כאן ולחץ על שליחה</asp:TextBox>
        <asp:Button ID="btnEmail" runat="server" Text="Send Email" OnClick="btnEmail_Click" />

        <br />
        <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
    </div>
    <asp:Label ID="lblMailResult" runat="server"></asp:Label>
</asp:Content>
