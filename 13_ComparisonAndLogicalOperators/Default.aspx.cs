using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comparisonAndLogicalOperators
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonTypeLabel.Text = "equal to";
            //comparisonTypeLabel.Text = "not equal to";
            //comparisonTypeLabel.Text = "greater than or equal to";
            comparisonTypeLabel.Text = "less than or equal to";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // resultLabel.Text = (TextBox1.Text == TextBox2.Text) ? "Yes" : "No";

            //resultLabel.Text = (TextBox1.Text != TextBox2.Text) ? "Yes" : "No";

            //int first = int.Parse(TextBox1.Text);
            //int second = int.Parse(TextBox2.Text);
            //resultLabel.Text = (first >= second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";

            //resultLabel.Text = (CheckBox1.Checked) ? "Yes" : "No";

            /* if (CheckBox1.Checked &&
                 TextBox1.Text == "Adriano" &&
                 TextBox2.Text == "Nannini")
             {
                 resultLabel.Text = "Perfect";
             }
             else resultLabel.Text = "Something is wrong";
         } */

            if (CheckBox1.Checked &&
                TextBox1.Text == "Adriano" &&
                TextBox2.Text == "Nannini")
            {
                resultLabel.Text = "Perfect";
            }

            else if (CheckBox1.Checked &&
    (TextBox1.Text == "Adriano" ||
    TextBox2.Text == "Nannini"))
            {
                resultLabel.Text = "two for 3. so close";
            }
            else if (CheckBox1.Checked ||
    TextBox1.Text == "Adriano" ||
    TextBox2.Text == "Nannini")
            {
                resultLabel.Text = "One out of 3 ain't bad";
            }
            else resultLabel.Text = "What are you even doing?";
        }
    }
}