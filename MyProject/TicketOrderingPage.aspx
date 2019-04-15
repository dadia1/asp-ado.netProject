<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="TicketOrderingPage.aspx.cs" Inherits="MyProject.TicketOrderingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">

    <asp:LinkButton ID="LinkLogOut" runat="server" OnClick="LinkLogOut_Click" Font-Bold="True">Log Out</asp:LinkButton>

    <br />
    <br />

    <table dir="rtl">
        <tr>
            <td>מספר כרטיסים
            </td>
            <td>
                <asp:DropDownList ID="ddlTicketNumber" runat="server" Width="80px" Font-Size="X-Large" Font-Bold="True">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
                &nbsp &nbsp
                <asp:Label ID="lblTicketNumber" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>בחירת הופעה
            </td>
            <td>
                <asp:DropDownList ID="ddlArtist" runat="server" Width="150px" DataSourceID="SqlDataSource1" DataTextField="Msg" DataValueField="Msg">
                </asp:DropDownList>
                &nbsp &nbsp
                <asp:Label ID="lblArtist" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnectionString %>" SelectCommand="SELECT [Msg] FROM [MonthMsg]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>מספר כרטיס אשראי
            </td>
            <td>
                <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
                &nbsp &nbsp
                <asp:Label ID="lblCardNumber" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>תוקף
            </td>
            <td>
                <asp:DropDownList ID="ddlMonthCard" runat="server" Width="50px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlYearCard" runat="server" Width="50px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2026</asp:ListItem>
                    <asp:ListItem>2027</asp:ListItem>
                    <asp:ListItem>2028</asp:ListItem>
                    <asp:ListItem>2029</asp:ListItem>
                    <asp:ListItem>2030</asp:ListItem>
                </asp:DropDownList>
                &nbsp &nbsp
                <asp:Label ID="lblDate" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>ת"ז של בעל הכרטיס
            </td>
            <td>
                <asp:TextBox ID="txtIdPay" runat="server"></asp:TextBox>
                &nbsp &nbsp
                <asp:Label ID="lblIdPay" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>שם בעל הכרטיס
            </td>
            <td>
                <asp:TextBox ID="txtNamePAy" runat="server"></asp:TextBox>
                &nbsp &nbsp
                <asp:Label ID="lblNamePay" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>כתובת בעל הכרטיס
            </td>
            <td>
                <asp:TextBox ID="txtAdressPay" runat="server"></asp:TextBox>
                &nbsp &nbsp
                <asp:Label ID="lblAdressPay" runat="server" Text="*" BackColor="Red" Font-Size="XX-Large" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
                <asp:Button ID="btnOrder" runat="server" Text="הזמן" BorderColor="#0000CC" BorderStyle="Outset" CssClass="center" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Width="150px" OnClick="btnOrder_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
