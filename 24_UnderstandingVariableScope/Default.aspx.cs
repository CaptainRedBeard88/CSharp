using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnderstandingVariableScope
{
    public partial class Default : System.Web.UI.Page
    {

        string z = " ";

        protected void Page_Load(object sender, EventArgs e)
        {
            z = "Hello";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int x = 1;

            z += " Adriano";
            if (x == 1) {
                x = 2;
                //int y = 3;
                z += " Nannini";
            }

            string result = z;
            resultLabel.Text = result;
        }
    }
}