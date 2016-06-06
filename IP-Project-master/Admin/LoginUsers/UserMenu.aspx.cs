using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_LoginUsers_UserMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCustSubmit_Click(object sender, EventArgs e)
    {
        if (rbUserInsert.Checked == true)
        {
            Response.Redirect("AddUser.aspx");
        }
        else if (rbUserEdit.Checked == true)
        {
            Response.Redirect("UpdateCustomer.aspx");
        }
        else if (rbUserDelete.Checked == true)
        {
            Response.Redirect("DeleteUser.aspx");
        }
        else
        {
            Response.Write("Please select a choice");
        }
    }
}