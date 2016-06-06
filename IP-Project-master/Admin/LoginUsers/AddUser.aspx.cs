using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_LoginUsers_AddUser : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void clearText()
    {
        txtUsername.Text = "";
        txtPassword.Text = "";
    }
    protected void btnCustInsertClear_Click(object sender, EventArgs e)
    {
        clearText();
    }
    protected void btnCustInsertNext_Click(object sender, EventArgs e)
    {
        LoginDTO login = new LoginDTO();
        login.loginID = txtUsername.Text;
        login.password = txtPassword.Text;
        login.jobDescription = dropDownJob.SelectedValue;
        LoginDAO doa = new LoginDAO();
        doa.saveLogin(login);
        Response.Redirect("~/Admin/LoginUsers/UserMenu.aspx");
    }
}