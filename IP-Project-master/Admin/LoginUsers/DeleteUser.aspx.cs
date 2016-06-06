using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_LoginUsers_DeleteUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDeleteCust_Click(object sender, EventArgs e)
    {
        LoginDAO dao = new LoginDAO();
        string userID = dropDownUserID.SelectedValue;
        dao.deleteLogin(userID);
        Response.Redirect("~/Admin/LoginUsers/UserMenu.aspx");
    }
}