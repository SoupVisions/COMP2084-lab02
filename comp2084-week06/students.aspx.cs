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
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the students to display in the gridview
            getStudents();
        }

        protected void getStudents()
        {
            // connect to the db
            var conn = new ContosoEntities();
            // run the query using LINQ
            var Students = from s in conn.Students
                              select s;
            // display query result in gridview
            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();
        }
    }
}