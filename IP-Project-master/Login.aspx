﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
    <asp:Label ID="LblMessage" runat="server" Text="Label" Width="300px"></asp:Label>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" />
    </p>
    </form>
</body>
</html>
