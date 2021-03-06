﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace understandingMultidimensionalArrays
{
    public partial class Default : System.Web.UI.Page
    {
        double[,] priceGrid;

        protected void Page_Load(object sender, EventArgs e)
        {
            //double[,] priceGrid = new double[3, 3];
            //0 - Chicago
            //1 - NY
            //2 - London
            priceGrid = new double[3, 3];
            priceGrid[0, 1] = 350;
            priceGrid[0, 2] = 750;
            priceGrid[1, 0] = 400;
            priceGrid[1, 2] = 700d;
            priceGrid[2, 0] = 800d;
            priceGrid[2, 1] = 805d;

           // resultLabel.Text = priceGrid[1, 2].ToString();
        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            int fromCity;
            if (fromChicagoRadioButton.Checked) fromCity = 0;
            else if (fromNewYorkRadioButton.Checked) fromCity = 1;
            else fromCity = 2;

            int toCity;
            if (toChicagoRadioButton.Checked) toCity = 0;
            else if (toNewYorkRadioButton.Checked) toCity = 1;
            else toCity = 2;

            if (fromCity == toCity)
            {
                resultLabel.Text = "Invalid selection";
                return;
            }

            resultLabel.Text = priceGrid[fromCity, toCity].ToString();
        }
    }
}