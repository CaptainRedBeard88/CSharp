using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormattingStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = string.Format("Thank you {0}, for your business", nameTextBox.Text);

            int ssi = int.Parse(ssiTextBox.Text);
            double phone = double.Parse(phoneNumberTextBox.Text);
            /* string result = string.Format("Thank you {0}, for your business." +
                 "<br> Your phone number is: {1:(000)-000-0000}" +
               "<br> Your social security number is: {2:000-00-0000}"
               +"<br> Loan Application Date: {3:ddd -- d,M,yy}", 
               nameTextBox.Text, phone, 
               ssi, 
               myCalendar.SelectedDate);*/

            double salary = double.Parse(salaryTextBox.Text);

            string result = string.Format("Thank you {0}, for your business." +
            "<br> Your phone number is: {1:(000)-000-0000}" +
          "<br> Your social security number is: {2:000-00-0000}"
          + "<br> Loan Application Date: {3:ddd -- d,M,yy}" +
          "<br> Salary: {4:C}",
          nameTextBox.Text, phone,
          ssi,
          myCalendar.SelectedDate,
          salary);

            resultLabel.Text = result;
        }
    }
}