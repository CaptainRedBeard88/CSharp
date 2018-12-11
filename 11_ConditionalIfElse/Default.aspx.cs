using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConditionalIfElse
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*if (TextBox1.Text == TextBox2.Text)
            {
                resultLabel.Text = "these numbers are equal";
            } else
            {
                resultLabel.Text = "They are not equal";
            } */

            /*if (coolCheckBox.Checked)
            {
                resultLabel.Text = "Yes, you rock!";
            } else
            {
                resultLabel.Text = "I think you are lying";
            } */

            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "I like the way you think!";
            } else if (saladRadioButton.Checked)
            {
                resultLabel.Text = "You must be a rabbit";
            } else if (pbjRadioButton.Checked)
            {
                resultLabel.Text = "Enjoy your PBJ sammy";
            } else
            {
                resultLabel.Text = "Check a radio button";
            }
        }
    }
}