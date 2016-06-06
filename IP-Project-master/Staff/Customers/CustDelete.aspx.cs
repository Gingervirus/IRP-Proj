﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customers_CustDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDeleteCust_Click(object sender, EventArgs e)
    {
        CustomerDAO dao = new CustomerDAO();
        string custID = dropDownCustID.SelectedValue;
        dao.deleteCustomer(custID);
        Response.Redirect("~/Staff/AdminHome.aspx");
    }
}