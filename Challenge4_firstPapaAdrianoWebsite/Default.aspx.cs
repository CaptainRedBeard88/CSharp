using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstPapaAdrianoWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (smallPizzaSize.Checked) total += 10;
            else if (mediumPizzaSize.Checked) total += 13;
            else if (largePizzaSize.Checked) total += 16;


            if (deepDishRadioButton.Checked) total += 2;


            total = (pepperoniCheckBox.Checked) ? total += 1.5 : total;
            total = (onionCheckBox.Checked) ? total += .75 : total;
            total = (greenPeppersCheckBox.Checked) ? total += .5 : total;
            total = (redPeppersCheckBox.Checked) ? total += .75 : total;
            total = (AnchoviesCheckBox.Checked) ? total += 2 : total;

            if ((pepperoniCheckBox.Checked && 
                greenPeppersCheckBox.Checked &&
                AnchoviesCheckBox.Checked) || 
                (pepperoniCheckBox.Checked && 
                redPeppersCheckBox.Checked &&
                onionCheckBox.Checked)) total -= 2;

            resultLabel.Text = "Your total is " + string.Format("{0:C}", total);
        }
    }
}