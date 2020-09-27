<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThirdPage.aspx.cs" Inherits="webform.ThirdPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Online Parents Group -Let us Talk for our kids </h1><hr />
            <h4>Browse Messages By Subject</h4>
            <p>select subject:<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>admission</asp:ListItem>
                <asp:ListItem>Fees</asp:ListItem>
                <asp:ListItem>Exam details</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
            </p>
        </div>
    </form>
</body>
</html>
