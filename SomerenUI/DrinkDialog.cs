﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class DrinkDialog : Form
    {
        Drink currentDrink;
      
        

        public DrinkDialog(Drink currentDrink)
        {
            InitializeComponent();
            this.currentDrink = currentDrink;
            FillTextbox();
        }

        public DrinkDialog()
        {
            InitializeComponent();
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTextbox()
        {
            textBox_Name.Text = currentDrink.Name;
            textBox_Price.Text = currentDrink.Price.ToString();
            textBox_Supply.Text = currentDrink.Supply.ToString();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            currentDrink.Name = textBox_Name.Text;
            currentDrink.Price = decimal.Parse(textBox_Price.Text);
            currentDrink.Supply = int.Parse(textBox_Supply.Text);

            SomerenLogic.Drink_Service drink_Service = new SomerenLogic.Drink_Service();
            drink_Service.UpdateDrink(currentDrink);
            this.Close();
        }
    }
}
