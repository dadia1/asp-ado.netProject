<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="MyProject.ShowUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmShowUser" runat="server">
        <div>            
             <asp:Repeater ID="rptShowUsers" runat="server">
                 <HeaderTemplate>
                     <table border="2">
                         <tr>
                             <th colspan="6">Users Details
                             </th>
                         </tr>
                         <tr>
                             <th>FirstName
                             </th>
                             <th>lastName
                             </th>
                             <th>userName
                             </th>
                             <th>Email
                             </th>
                             <th>Phone
                             </th>
                             <th>IsAdmin
                             </th>
                         </tr>
                 </HeaderTemplate>
                 <ItemTemplate>
                     <tr>
                         <td>
                             <%# Eval("firstName")%>
                         </td>
                         <td>
                             <%# Eval("lastName")%>
                         </td>
                         <td>
                             <%# Eval("UserName")%>
                         </td>
                         <td>
                             <%# Eval("Email")%>
                         </td>
                         <td>
                             <%# Eval("Phone")%>
                         </td>
                         <td>
                             <%# Eval("IsAdmin")%>
                         </td>
                     </tr>
                 </ItemTemplate>
                 <FooterTemplate>
                     </table>
                 </FooterTemplate>
             </asp:Repeater>
        </div>
    </form>
</body>
</html>
