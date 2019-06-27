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
    public partial class DrinkDialog : Form
    {
        public DrinkDialog()
        {
            InitializeComponent();
        }

        public Drink getDrink()
        {
            Drink drink = new Drink();
            return drink;
        }
    }
}
