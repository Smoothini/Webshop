<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShopWebFormsClient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="UserBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        </p>
        <p>
            <asp:Label ID="LoginStatus" runat="server" Text="pls login"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="GoBack" runat="server" NavigateUrl="~/Index.aspx">Go back</asp:HyperLink>
        </p>
        <p>
            <asp:Button ID="Logout" runat="server" Visible = "false" Text ="Logout" OnClick="Logout_Click" />
        </p>
    </form>
</body>
</html>
