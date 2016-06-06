using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for LoginDAO
/// </summary>
public class LoginDAO
{
    public String connString { get; set; }
	public LoginDAO()
	{
        connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
	}

    public void saveLogin(LoginDTO login)
    {
        try
        {
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string insertStatement = "insert into Login (login_Id, jobDescription, password) " +
                "values (@login_Id, @jobDescription, @password)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, myConn);
            insertCommand.Parameters.Add("@login_Id", SqlDbType.VarChar).Value = login.loginID;
            insertCommand.Parameters.Add("@jobDescription", SqlDbType.VarChar).Value = login.jobDescription;
            insertCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = login.password;

            int rows = insertCommand.ExecuteNonQuery();
            myConn.Close();
            if (rows != 1) throw new Exception("unexpected result");
        }
        catch (SqlException ex)
        {
            Console.Write("Error : " + ex.ToString());
        }
    }

    public void updateLogin(LoginDTO login)
    {
        try
        {
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string updateString = "UPDATE Login SET login_Id = @login_Id, jobDescription = @jobDescription, password = @password WHERE loginID = @loginID";
            SqlCommand updateComm = new SqlCommand(updateString, myConn);
            updateComm.Parameters.AddWithValue("@login_Id", login.loginID);
            updateComm.Parameters.AddWithValue("@jobDescription", login.jobDescription);
            updateComm.Parameters.AddWithValue("@password", login.password);
            int rows = updateComm.ExecuteNonQuery();
            myConn.Close();
            if (rows != 1) throw new Exception("Unexpected Result for Update");
        }
        catch (SqlException ex)
        {
            Console.Write("Error : " + ex.ToString());
        }
    }

    public void deleteLogin(string loginID)
    {
        try
        {
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string deleteString = "Delete from Login where login_Id = '" + loginID + "'";
            SqlCommand deleteComm = new SqlCommand(deleteString, myConn);
            int rows = deleteComm.ExecuteNonQuery();
            myConn.Close();
            if (rows != 1) throw new Exception("Unexpected Result for Update");
        }
        catch (SqlException ex)
        {
            Console.Write("Error : " + ex.ToString());
        }
    }
}