using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge5_DaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*int firstDate = Calendar1.SelectedDate.Day;
            int secondDate = Calendar2.SelectedDate.Day;
            if (firstDate >= secondDate)
            {
                int difference = firstDate - secondDate;
                resultLabel.Text = difference.ToString();
            }
            if (secondDate > firstDate){
                int difference = secondDate - firstDate;
                resultLabel.Text = difference.ToString(); } */
            if(Calendar1.SelectedDate >= Calendar2.SelectedDate)
            resultLabel.Text = Calendar1.SelectedDate.
                    Subtract(Calendar2.SelectedDate).
                    TotalDays.ToString();

            else resultLabel.Text = Calendar2.SelectedDate.
                    Subtract(Calendar1.SelectedDate).
                    TotalDays.ToString();
        }
    }
}