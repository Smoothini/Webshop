
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ShopWebFormsClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="index" runat="server">
        <p>
            <asp:HyperLink ID="LoginLink" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="RegisterLink" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
        </p>
        
        <p>
            <asp:Label ID="StatusLabel" runat="server" Text="Loading..."></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
