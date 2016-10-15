using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp2084_week06
{
    public partial class tip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // get the amount from the textbox
            // save in a variable of type double (which holds decimals)
            Double amount = Convert.ToDouble(txtAmount.Text);
            // get tip percent
            Double tipPercent = Convert.ToDouble(ddlPercent.SelectedValue);
            // calculate the tip and total
            Double tipAmount = amount * tipPercent;
            Double total = amount + tipAmount;
            // display the results
            lblTip.Text = Convert.ToString(tipAmount);
            lblTotal.Text = Convert.ToString(total);

        }
    }
}