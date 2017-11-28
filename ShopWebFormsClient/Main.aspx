<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ShopWebFormsClient.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Items"></asp:Label>
                </p>
            <p>
                
                <asp:DropDownList ID="ListCategories" runat="server"></asp:DropDownList>
                
                </p>
            <p>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </p>
            <asp:Panel ID="PanelProducts" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>
