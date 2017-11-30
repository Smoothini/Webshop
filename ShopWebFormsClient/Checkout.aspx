<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ShopWebFormsClient.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Checkout cart</h2>
            <h4>Order details</h4>
            <asp:Literal ID="OrderDetails" runat="server" Text=""></asp:Literal><br /><br />
            <asp:TextBox ID="CardInput" runat="server"></asp:TextBox><br />
            <asp:Button ID="PlaceOrder" runat="server" Text="Pay and place order" OnClick="PlaceOrder_Click" /><br /><br />
            <asp:Label ID="OrderStatus" runat="server" Text=""></asp:Label><br /> <br /><br />
            <asp:HyperLink ID="GoBack" runat="server" NavigateUrl="~/Main.aspx">Go back</asp:HyperLink>
        </div>
    </form>
</body>
</html>
