using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// add reference to access the db
using System.Web.ModelBinding;

namespace comp2084_week06
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the departments to display in the gridview
            getDepartments();
        }

        protected void getDepartments()
        {
            // connect to the db
            var conn = new ContosoEntities();
            // run the query using LINQ
            var Departments = from d in conn.Departments
                              select d;
            // display query result in gridview
            grdDepartments.DataSource = Departments.ToList();
            grdDepartments.DataBind();
        }
    }
}