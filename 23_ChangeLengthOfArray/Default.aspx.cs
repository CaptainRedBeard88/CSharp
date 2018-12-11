using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace changeLengthOfArray
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];

            Array.Resize(ref hours, hours.Length+1);

            //gets upper most from first index of array
            int newestItem = hours.GetUpperBound(0);

            hours[newestItem] = double.Parse(hoursTextBox.Text);
            ViewState["Hours"] = hours;
            resultLabel.Text = string.Format("Total Hours: {0} <br />Most hours: {1}"
                + "<br />least hours: {2} <br /> Average Hours: {3:N2}", hours.Sum(),
                hours.Max(), hours.Min(), hours.Average());
        }
    }
}