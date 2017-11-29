<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ShopWebFormsClient.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Items for sale</h2>
            <h4>Categories</h4>
            <asp:DropDownList ID="ListCategories" runat="server"></asp:DropDownList>
            <asp:Panel ID="PanelProducts" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>
