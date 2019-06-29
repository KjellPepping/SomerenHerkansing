using System;
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
    public partial class ActivityDialog : Form
    {
        Activity currentActivity = new Activity();
       
        public ActivityDialog(Activity currentActivity)
        {
            InitializeComponent();
            this.currentActivity = currentActivity;
            lbl_EditActivity.Text = "Edit Activity";
            btn_Act_Add.Visible = false;
            btn_Act_Submit.Visible = true;
            FillTextBox();
        }

        public ActivityDialog()
        {
            InitializeComponent();
            lbl_EditActivity.Text = "Add Activity";
            btn_Act_Add.Visible = true;
            btn_Act_Submit.Visible = false;
        }

        private void FillTextBox()
        {
            textBox_Act_Name.Text = currentActivity.Description;
            textBox_Act_ID.Text = currentActivity.Id.ToString();
            textBox_Act_Students.Text = currentActivity.countStudents.ToString();
            textBox_Act_Mentors.Text = currentActivity.countMentors.ToString();
        }

        private void btn_Act_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Act_Submit_Click(object sender, EventArgs e)
        {
            currentActivity.Description = textBox_Act_Name.Text;
            currentActivity.Id = int.Parse(textBox_Act_ID.Text);
            currentActivity.countMentors = int.Parse(textBox_Act_Mentors.Text);
            currentActivity.countStudents = int.Parse(textBox_Act_Students.Text);

            SomerenLogic.Activity_Service actService = new SomerenLogic.Activity_Service();
            actService.UpdateActivity(currentActivity);
            this.Close();
        }

        private void btn_Act_Add_Click(object sender, EventArgs e)
        {
            currentActivity.Description = textBox_Act_Name.Text;
            currentActivity.Id = int.Parse(textBox_Act_ID.Text);
            currentActivity.countMentors = int.Parse(textBox_Act_Mentors.Text);
            currentActivity.countStudents = int.Parse(textBox_Act_Students.Text);

            SomerenLogic.Activity_Service actService = new SomerenLogic.Activity_Service();
            actService.AddActivity(currentActivity);
            this.Close();
        }
    }
}
