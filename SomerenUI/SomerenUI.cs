using SomerenLogic;
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
        private User currentUser;
        private List<Drink> drinks = new List<Drink>();
        private List<Activity> activities = new List<Activity>();

        SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
        SomerenLogic.Drink_Service drinkService = new SomerenLogic.Drink_Service();
        //SomerenLogic.Activity_Service actService = new SomerenLogic.Activity_Service();
        
       
        public SomerenUI(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
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
                pnl_Activities.Hide();
            }
            else if(panelName == "Students")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Drinks.Hide();
                pnl_Activities.Hide();

                pnl_Students.Show();

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
                pnl_Activities.Hide();

                pnl_Drinks.Show();

                List<Drink> drinkList = drinkService.GetDrinks();
                drinks = drinkList;

                listViewDrinks.Items.Clear();

                foreach (SomerenModel.Drink d in drinkList)
                {
                    ListViewItem item = new ListViewItem(d.Name);
                    item.SubItems.Add(d.Price.ToString());
                    item.SubItems.Add(d.Supply.ToString());
                    listViewDrinks.Items.Add(item);
                }
            }

            else if (panelName == "Activities")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Drinks.Hide();

                pnl_Activities.Show();

                
                List<Activity> activityList = actService.GetActivities();
                activities = activityList;

                listViewActivities.Items.Clear();

                foreach (SomerenModel.Activity a in activityList)
                {
                    ListViewItem item = new ListViewItem(a.countStudents.ToString());
                    item.SubItems.Add(a.countMentors.ToString());
                    item.SubItems.Add(a.Id.ToString());
                    item.SubItems.Add(a.Description);
                    listViewActivities.Items.Add(item);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void listViewDrinks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(currentUser.isAdmin)
                {
                  btn_Edit_Drink.Enabled = true;
                  btn_Remove_Drink.Enabled = true;
                }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewDrinks.SelectedItems[0];
            Drink selectedDrink = drinks.Where(t => t.Name == selectedItem.Text).FirstOrDefault();
            DrinkDialog drinkDialog = new DrinkDialog(selectedDrink);
            drinkDialog.Show();
            btn_Edit_Drink.Enabled = false;
            showPanel("Drinks");
        }

        private void btn_Remove_Drink_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewDrinks.SelectedItems[0];
            Drink selectedDrink = drinks.Where(t => t.Name == selectedItem.Text).FirstOrDefault();
            Drink_Service drinkSer = new Drink_Service();
            drinkSer.DeleteDrink(selectedDrink.Name);
            btn_Remove_Drink.Enabled = false;
            showPanel("Drinks");
        }

        private void btn_Add_Drink_Click(object sender, EventArgs e)
        {
            DrinkDialog drinkDialog = new DrinkDialog();
            drinkDialog.Show();
        }

        private void btn_Edit_Activities_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewActivities.SelectedItems[0];
            Activity selectedActivity = activities.Where(t => t.countStudents == int.Parse(selectedItem.Text)).FirstOrDefault();
            ActivityDialog activityDialog = new ActivityDialog(selectedActivity);
            activityDialog.Show();
            btn_Edit_Activities.Enabled = false;
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(currentUser.isAdmin)
                {
            btn_Edit_Activities.Enabled = true;
            btn_Remove_Activity.Enabled = true;
                }
        }

        private void btn_Remove_Activity_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewActivities.SelectedItems[0];
            Activity selectedActivity = activities.Where(t => t.countStudents == int.Parse(selectedItem.Text)).FirstOrDefault();

            DialogResult dr = MessageBox.Show("Do you want to remove this activity?", "Removing activity", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Activity_Service actService = new Activity_Service();
                actService.DeleteActivity(selectedActivity.Id);            }
        }

        private void btn_Add_Activity_Click(object sender, EventArgs e)
        {
            ActivityDialog activityDialog = new ActivityDialog();
            activityDialog.Show();
        }
    }   
}
