<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MyProject.HomePage" %>

<%@ Register Src="~/MusicShowsUserControl.ascx" TagPrefix="myControl" TagName="MusicShowsUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <script
        src="https://code.jquery.com/jquery-3.3.1.js"></script>
    <script>
        $(function () {

            $('audio').on('canplay', function () {
                this.play();
            });

        });

    </script>

    <audio src="/Audio/SingPageLoad.mp3" autoplay="autoplay" loop="loop" controls controlslist="nodownload">
    </audio>


    <div id="h2">
        <h2>כאן תוכלו לקבל מידע על ההופעות הקרובות ולצפות באומנים המבצעים</h2>
    </div>

    <div id="marq">

        <marquee direction="right" scrollamount="15" scrolldelay="20">
            <asp:Panel ID="Panel1" runat="server"></asp:Panel></marquee>

    </div>

    <div id="serch">
        <asp:Label ID="Label2" runat="server" Text="חיפוש מבצעים"></asp:Label>
        <br />
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="חיפוש" OnClick="btnSearch_Click" />
        <asp:Label ID="lblNotResultSearch" runat="server" BackColor="#FF5050"></asp:Label>
    </div>

    <br />
    <asp:Image ID="ImageLogo" runat="server" ImageUrl="~/images/imgPng.png" />


</asp:Content>
