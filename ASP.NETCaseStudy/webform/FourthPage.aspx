<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FourthPage.aspx.cs" Inherits="webform.FourthPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is Post message<br />
            Message<br />
            subject:<asp:TextBox ID="txtsub" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtsub" ErrorMessage="subject is mandatory"></asp:RequiredFieldValidator>
            <br />
            Message:<asp:TextBox ID="txtMsg" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMsg" ErrorMessage="Description is Mandatory"></asp:RequiredFieldValidator>
            <br />
            ParentName:<asp:TextBox ID="txtParentName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCreatePost" runat="server" Text="Create" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="DispalyMsg" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FirstPage.aspx">Back to List</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
