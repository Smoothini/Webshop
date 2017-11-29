<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShopWebFormsClient.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Your cart</h2>
            <h4>Items</h4>
            <asp:Table ID="CartProducts" runat="server">
            </asp:Table>
        </div>
        <asp:Button ID="EmptyCart" runat="server" OnClick="EmptyCart_Click" Text="Empty cart" />
    </form>
</body>
</html>
