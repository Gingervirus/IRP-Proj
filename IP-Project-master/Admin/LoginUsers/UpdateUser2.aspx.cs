using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_LoginUsers_UpdateUser2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getSessionData();
    }
    protected void btnCustInsert_Click(object sender, EventArgs e)
    {
        LoginDTO dto = (LoginDTO)Session["LoginDTO"];
        LoginDAO doa = new LoginDAO();
        doa.saveLogin(dto);
        Session.Abandon();
        Response.Redirect("~/Admin/DefaultAdmin.aspx");
    }

    private void getSessionData()
    {
        LoginDTO dto = (LoginDTO)Session["LoginDTO"];
        txtUsername.Text = dto.loginID;
        txtPassword.Text = dto.password;
        dropDownJob.SelectedValue = dto.jobDescription;
       
    }
}