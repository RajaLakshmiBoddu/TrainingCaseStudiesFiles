﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="webform.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SecondPage.aspx">Post Your Messages</asp:HyperLink>
        <div>
        </div>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ThirdPage.aspx">Browse Messages</asp:HyperLink>
    </form>
</body>
</html>