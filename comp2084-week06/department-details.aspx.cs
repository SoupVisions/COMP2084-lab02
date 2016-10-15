﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// reference the model binding library
using System.Web.ModelBinding;
namespace comp2084_week06
{
    public partial class department_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();

            // use the Department class to create a new Department obj
            Department d = new Department();

            // fill the properties of the new Department obj
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);

            // save the new object
            conn.Departments.Add(d);
            conn.SaveChanges();

            // redirect to the departments page
            Response.Redirect("departments.aspx");
        }
    }
}