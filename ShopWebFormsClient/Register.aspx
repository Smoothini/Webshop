<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ShopWebFormsClient.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Table1 {
            width: 260px;
            height: 93px;
        }
        .auto-style1 {
            height: 80px;
        }
        .auto-style2 {
            height: 78px;
        }
        .auto-style3 {
            height: 111px;
            width: 363px;
        }
        .auto-style4 {
            height: 78px;
            width: 81px;
        }
        .auto-style5 {
            height: 80px;
            width: 81px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table ID="Table1" runat="server" class="auto-style3">
            <tr>
                <td class="auto-style4">
                        <label>Username: </label>
                </td>
                <td class="auto-style2">
                        <asp:TextBox ID="UserBox" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                        <label>Password: </label>
                </td>
                <td class="auto-style1">
                        <asp:TextBox ID="PasswordBox" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" Text="Register" />
        </p>
        <p>
            <asp:HyperLink ID="GoBack" runat="server" NavigateUrl="~/Index.aspx">Go back</asp:HyperLink>
        </p>
    </form>
</body>
</html>
