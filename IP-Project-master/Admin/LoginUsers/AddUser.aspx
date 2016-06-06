<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Admin_LoginUsers_AddUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="2">
                    Add new Customer Details</td>
            </tr>
            <tr>
                <td class="style2">
                    Username:</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server" ReadOnly="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" 
                    ControlToValidate="txtCustName" ErrorMessage="* Required" ForeColor="Red"></asp:RequiredFieldValidator>
                
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtCustName" ErrorMessage="* Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Job Description:</td>
                <td>
                    <asp:DropDownList ID="dropDownJob" runat="server">
                        <asp:ListItem>Technician</asp:ListItem>
                        <asp:ListItem>Staff</asp:ListItem>
                        <asp:ListItem Value="Admin">Admin</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="btnCustInsertNext" runat="server" Height="26px" 
                        onclick="btnCustInsertNext_Click" Text="Next" Width="106px" />
                </td>
                <td>
                    <asp:Button ID="btnCustInsertClear" runat="server" 
                        onclick="btnCustInsertClear_Click" Text=" Add User" Width="105px" 
                        style="height: 26px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
