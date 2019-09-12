using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            string name = nameTextBox.Text;

            MessageBox.Show("Hello "  + name);

            showLabel.Text = name;
        }
    }
}
