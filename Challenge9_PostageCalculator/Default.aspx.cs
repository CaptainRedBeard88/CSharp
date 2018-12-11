using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostageCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShippingCost();
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShippingCost();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShippingCost();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateShippingCost();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateShippingCost();
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateShippingCost();
        }

        private void calculateShippingCost()
        {
            //check there is something in required fields
            if (!valuesExist()) return;

            //check to see if valid and get volume
            int volume = 0;
            if (!getVolume(out volume)) return;

            //determine postage multiplier
            double postMultiplier = determinePostageMultiplier();

            //give customer cost
            double cost = volume * postMultiplier;
            resultLabel.Text = string.Format("Your package will cost {0:C} to ship", cost);

        }

        private bool valuesExist()
        {
            if (!groundRadioButton.Checked &&
                !airRadioButton.Checked &&
                !nextDayRadioButton.Checked)
                return false;

            if (lengthTextBox.Text.Trim().Length == 0 ||
                widthTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private bool getVolume(out int volume)
        {
            volume = 0;
            int length = 0;
            int width = 0;
            int height = 0;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) return false;
            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) height = 1;

            volume = length * width * height;
            return true;
        }

        private double determinePostageMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;
        }
    }
}