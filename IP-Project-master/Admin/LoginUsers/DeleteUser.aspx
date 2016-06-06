<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteUser.aspx.cs" Inherits="Admin_LoginUsers_DeleteUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <table class="style1">
            <tr>
                <td colspan="2">
                    Delete Customer Record</td>
            </tr>
            <tr>
                <td class="style3">
                    Select Customer ID:</td>
                <td>
                    <asp:DropDownList ID="dropDownUserID" runat="server" 
                        DataSourceID="SqlDataCustID" DataTextField="login_Id" 
                        DataValueField="login_Id">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="btnDeleteUser" runat="server" onclick="btnDeleteCust_Click" 
                        Text="Delete User" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:SqlDataSource ID="SqlDataUserID" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [login_Id] FROM [Login]"></asp:SqlDataSource>
    </form>
</body>
</html>
