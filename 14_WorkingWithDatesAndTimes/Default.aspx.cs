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
            //DateTime myValue = DateTime.Now;
            /* resultLabel.Text = myValue.ToString() + "<br/>" +
             myValue.ToLongTimeString() +"<br/>" +
             myValue.ToLongDateString() +"<br/>" +
             myValue.ToShortDateString() +"<br/>" +
             myValue.ToShortTimeString(); */

            //resultLabel.Text = myValue.AddDays(2).ToString();
            //resultLabel.Text = myValue.AddMonths(-2).ToString();

            //resultLabel.Text = myValue.Month.ToString();


            //DateTime myValue = DateTime.Parse("6/3/1987");
            DateTime myValue = new DateTime(1987, 6, 3);
            resultLabel.Text = myValue.ToLongDateString();
        }
    }
}