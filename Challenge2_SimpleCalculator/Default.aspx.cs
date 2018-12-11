using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void plusButton_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(inputBox1.Text);
            double secondNum = double.Parse(inputBox2.Text);

            double total = firstNum + secondNum;
            resultLabel.Text = total.ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(inputBox1.Text);
            double secondNum = double.Parse(inputBox2.Text);

            double total = firstNum - secondNum;
            resultLabel.Text = total.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(inputBox1.Text);
            double secondNum = double.Parse(inputBox2.Text);

            double total = firstNum * secondNum;
            resultLabel.Text = total.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(inputBox1.Text);
            double secondNum = double.Parse(inputBox2.Text);

            double total = firstNum / secondNum;
            resultLabel.Text = total.ToString();
        }
    }
}