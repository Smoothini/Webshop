<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ShopWebFormsClient.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td rowspan ="4">img?</td>
                <td><asp:Label ID ="labelName" Text ="Name" runat ="server"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID ="labelDescription" Text ="Description" runat ="server"></asp:Label><br />
                    Price: <asp:Label ID ="labelPrice" Text ="hgf" runat ="server"></asp:Label></td>
                <asp:Label ID="labelQuantity" Text ="" runat="server"></asp:Label>
            </tr>
            <tr>
                <td>Product ID: <asp:Label ID ="labelId" Text ="" runat ="server"></asp:Label></td>
                <td>Quantity:
                <asp:DropDownList ID ="quantitySelect" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td><asp:Label ID ="labelAvailable" Text ="Available" runat ="server"></asp:Label></td>
                <td><asp:Button ID="btnAddToCart" runat="server" Text="Add to cart" OnClick="btnAddToCart_Click"/></td>
            </tr>
        </table>
        <asp:HyperLink ID="GoBackLink" runat="server" NavigateUrl="~/Main.aspx">Go back</asp:HyperLink><br />
        <asp:Label ID="AddStatus" runat="server"></asp:Label><br />
        <asp:HyperLink ID="ViewCart" runat="server" NavigateUrl="~/Cart.aspx">View cart</asp:HyperLink>
        
    </form>
</body>
</html>
