using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    private string conn = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            LoginDTO login = new LoginDTO();
            conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConn = new SqlConnection(conn);
            myConn.Open();
            string selectStatement = "Select * from Login where (login_Id =" + TxtUsername.Text + ") AND (password = '" + TxtPassword.Text + "')" ;
            SqlCommand selectCmd = new SqlCommand(selectStatement, myConn);
            SqlDataReader myReader;
            myReader = selectCmd.ExecuteReader();
           
            while (myReader.Read())
            {
                if ((String)myReader["login_Id"] == TxtUsername.Text.ToString())
                {
                    login.loginID = (String)myReader["login_Id"];
                    login.jobDescription = (String)myReader["jobDescription"];
                    login.password = (String)myReader["password"];
                    break;
                }
            }
            
            LblMessage.Text = login.loginID + ", " + login.jobDescription + ", " + login.password;
            if(login.loginID == TxtUsername.Text && login.password == TxtPassword.Text)
            {
                if (login.jobDescription.Equals("Technician"))
                {
                    myConn.Close();
                    Session["LoginDTO"] = login;
                    //Response.Redirect("~/Technicians/TechniciansHome.aspx");
                    Server.Transfer("~/Technicians/TechniciansHome.aspx");
                }
                else if (login.jobDescription.Equals("Staff"))
                {
                    myConn.Close();
                    Session["LoginDTO"] = login;
                    Server.Transfer("~/Staff/Customers/AdminHome.aspx");
                }
                else if (login.jobDescription.Equals("Admin"))
                {
                    myConn.Close();
                    Session["LoginDTO"] = login;
                    Server.Transfer("~/Admin/DefaultAdmin.aspx");
                }
            }
           
            
        }
        catch (SqlException ex)
        {
            Console.Write("Error : " + ex.ToString());
        }
    }
}