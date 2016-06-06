<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserMenu.aspx.cs" Inherits="Admin_LoginUsers_UserMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
    <h1>User Menu</h1>

    </div>
    <table class="style1">
        <tr>
            <td>
                <asp:RadioButton ID="rbUserInsert" runat="server" GroupName="rbCust" 
                    Text="Add New User" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="rbUserEdit" runat="server" GroupName="rbCust" 
                    Text="Edit User Login" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="rbUserDelete" runat="server" GroupName="rbCust" 
                    Text="Remove User" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnUserSubmit" runat="server" Text="Submit Choice" 
                    onclick="btnCustSubmit_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
