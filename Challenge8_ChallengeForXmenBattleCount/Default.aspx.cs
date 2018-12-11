using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";


            // Your Code Here!

            int largestIndexNum = 0;
            int smallestIndexNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > numbers[largestIndexNum]){
                    largestIndexNum = i; }

                if (numbers[i] < numbers[smallestIndexNum])
                {
                    smallestIndexNum = i;
                }

                result = string.Format("{0} is the X-Man with the highest battle count: ({1}) <br />"
                    + "{2} is the X-Man with the least battle count: ({3})",
                    names[largestIndexNum], numbers[largestIndexNum],
                    names[smallestIndexNum], numbers[smallestIndexNum]);
            }




            resultLabel.Text = result;
            
        }
    }
}