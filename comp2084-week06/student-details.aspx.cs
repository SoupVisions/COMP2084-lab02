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
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();

            // use the Student class to create a new Department obj
            Student s = new Student();

            // fill the properties of the new Department obj
            s.LastName = txtLastName.Text;
            s.FirstMidName = txtFirstName.Text;
            s.EnrollmentDate = Convert.ToDateTime(txtEnrollment.Text);

            // save the new object
            conn.Students.Add(s);
            conn.SaveChanges();

            // redirect to the departments page
            Response.Redirect("students.aspx");

        }
    }
}