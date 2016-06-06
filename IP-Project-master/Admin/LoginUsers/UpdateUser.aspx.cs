using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_LoginUsers_UpdateUser : System.Web.UI.Page
{
    String conn = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            LoginDTO login = new LoginDTO();
            conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConn = new SqlConnection(conn);
            myConn.Open();
            string selectStatement = "Select * from Login where (login_Id="; selectStatement += dropDownUserID.SelectedValue + ")";
            SqlCommand selectCmd = new SqlCommand(selectStatement, myConn);
            SqlDataReader myReader;
            myReader = selectCmd.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader.GetString(0) == dropDownUserID.SelectedValue)
                {
                    login.loginID = myReader.GetString(0);
                    login.jobDescription = myReader.GetString(1);
                    login.password = myReader.GetString(2);
                    
                    break;
                }
            }
            myConn.Close();
            Session["LoginDTO"] = login;
            Server.Transfer("UpdateUser2.aspx");
        }
        catch (SqlException ex)
        {
            Console.Write("Error : " + ex.ToString());
        }
    }
}