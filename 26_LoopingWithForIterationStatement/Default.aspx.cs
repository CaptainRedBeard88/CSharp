using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loopingWithForIterationStatement
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = " ";

            /* for(int i = 0; i<10; i++)
             {
                 result += "<br />" + i.ToString();
             } */

            //for (int i = 5; i <= 15; i++)
            //{
            //    result += "<br /> " + i.ToString();
            //}

            //for (int i = 15; i >= 5; i--)
            //{
            //    result += "<br /> " + i.ToString();
            //}

            //for (int i = 5; i <= 15; i+=3)
            //{
            //    result += "<br /> " + i.ToString();
            //}

            string[] names = new string[] { "Wolverine", "Deadpool", "Cable", "Invader Zim" };

            Array.Sort(names);
            Array.Reverse(names);

            //for (int i = 0; i < names.Length; i++)
            //{
            //    result += "<br /> " + names[i];
            //}

            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] == "Cable")
                {
                    result = string.Format("{0} is at index {1} in the list", names[i], i);
                    break;
                }

            }

            resultLabel.Text = result;
        }
    }
}