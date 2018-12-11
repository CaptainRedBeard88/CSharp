using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace epicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] spyName = new string[0];
                int[] electRigged = new int[0];
                double[] subterfuge = new double[0];

                ViewState.Add("SpyName", spyName);
                ViewState.Add("ElectRigged", electRigged);
                ViewState.Add("Subterfuge", subterfuge);
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            string[] spyName = (string[])ViewState["SpyName"];
            int[] electRigged = (int[])ViewState["ElectRigged"];
            double[] subterfuge = (double[])ViewState["Subterfuge"];

            Array.Resize(ref spyName, spyName.Length + 1);
            Array.Resize(ref electRigged, electRigged.Length + 1);
            Array.Resize(ref subterfuge, subterfuge.Length + 1);

            //gets upper most from first index of array
            int newestItem = spyName.GetUpperBound(0);

            spyName[newestItem] = nameTextBox.Text;
            electRigged[newestItem] = int.Parse(electionsTextBox.Text);
            subterfuge[newestItem] = double.Parse(subterfugeTextBox.Text);

            ViewState["SpyName"] = spyName;
            ViewState["ElectRigged"] = electRigged;
            ViewState["Subterfuge"] = subterfuge;

            resultLabel.Text = string.Format("Total Elections Rigged: {0} <br />"
                + " Average acts of subterfuge: {1:N2} <br />"
                + "(Last asset added: {2})", 
                electRigged.Sum(),
                subterfuge.Average(), 
                spyName.Last());

            nameTextBox.Text = " ";
            electionsTextBox.Text = " ";
            subterfugeTextBox.Text = " ";
        }
    }
}