<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MyProject.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div id="logIn" dir="ltr">
        <asp:Login align="center" ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
            Font-Size="10pt" OnAuthenticate="Login1_Authenticate" UserNameLabelText="Email:" FailureText="Your email or password was not successful. Please try again.">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True"
                ForeColor="#FFFFFF" />
        </asp:Login>
    </div>
    <asp:LinkButton ID="LinkLogOut" runat="server" OnClick="LinkLogOut_Click">Log out</asp:LinkButton>
</asp:Content>
