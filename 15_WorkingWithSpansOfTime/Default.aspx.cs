using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //2 ways to create timespans
            //http://is.gd/timespan
            //Days.Hours:Minutes:Seconds.Milliseconds
            //TimeSpan myTimeSpan = TimeSpan.Parse("1.2:25:40.69");

            //counts hour as midnight because not specified
            DateTime myBirthday = DateTime.Parse("6/3/1987");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            //resultLabel.Text = myAge.Hours.ToString();

            resultLabel.Text = myAge.TotalDays.ToString();
        }
    }
}