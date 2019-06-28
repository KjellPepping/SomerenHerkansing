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
    public partial class LoginDialog : Form
    {
        private string AdminUsername = "rita@infhaarlem.nl";
        private string AdminPassword = "qd6VqFfyzF5UgPRDNy9NSCb4";
        private string VisitorUsername = "piet@infhaarlem.nl";
        private string VisitorPassword = "t78Dx4BfhqfEamxdnAkLCpbC";

        User user = new User();


        public LoginDialog()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == AdminUsername && textBox_Password.Text == AdminPassword)
            {
                user.IsAdmin = true;
                SomerenUI UI = new SomerenUI(user);
                UI.Show();
            }
            else if (textBox_Username.Text == VisitorUsername && textBox_Password.Text == VisitorPassword)
            {
                user.IsAdmin = false;
                SomerenUI UI = new SomerenUI(user);
                UI.Show();
            }
            else
            {
                textBox_Username.Text = string.Empty;
                textBox_Password.Text = string.Empty;
                lbl_Warning.Show();
            }
        }

        private void btn_Login_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
