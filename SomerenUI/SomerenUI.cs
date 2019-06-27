﻿using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if(panelName == "Dashboard")
            {
                pnl_Students.Hide();
                pnl_Drinks.Hide();
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Drinks.Hide();

                pnl_Students.Show();

                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                listViewStudents.Items.Clear();
               

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem item = new ListViewItem(s.Name);
                    item.SubItems.Add(s.Number.ToString());
                    item.SubItems.Add(s.BirthDate.ToString());
                    listViewStudents.Items.Add(item);
                }
            }

            else if(panelName == "Drinks")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();

                pnl_Drinks.Show();

                SomerenLogic.Drink_Service drinkService = new SomerenLogic.Drink_Service();
                List<Drink> drinkList = drinkService.GetDrinks();

                listViewDrinks.Items.Clear();

                foreach (SomerenModel.Drink d in drinkList)
                {
                    ListViewItem item = new ListViewItem(d.Name);
                    item.SubItems.Add(d.Price.ToString());
                    item.SubItems.Add(d.Supply.ToString());
                    listViewDrinks.Items.Add(item);
                }

            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void listViewDrinks_SelectedIndexChanged(Object sender,EventArgs e)
        {
        
        }

        private void listViewDrinks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_Edit.Enabled = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewDrinks.SelectedItems[0];
            
            DrinkDialog drinkDialog = new DrinkDialog();
            Drink editedDrink = drinkDialog.getDrink();
            drinkDialog.ShowDialog();
            btn_Edit.Enabled = false;
        }
    }
}
