<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="webform.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body bgcolor="Pink">
    <form id="form1" runat="server">
        <div>
            This is the Registration Page<br />
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1" colspan="2">Registration Page</td>
                </tr>
                <tr>
                    <td>Username:</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FirstPage.aspx">Home</asp:HyperLink>
    </form>
</body>
</html>
