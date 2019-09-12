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
    public partial class DataTypeUi : Form
    {
        public DataTypeUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //string msg = "10";

            //int firstNumber = 10;
            //int secondNumber = firstNumber;
            //double thirdNumber = firstNumber;

            //secondNumber = (int)thirdNumber;

            //msg =Convert.ToString(secondNumber);
            //msg =secondNumber.ToString();

            //secondNumber = Convert.ToInt32(msg);

            if (itemComboBox.Text == "")
            {
                MessageBox.Show("Select item");
            }
            else
            {
                MessageBox.Show(itemComboBox.Text + " is selected");
            }

        }
    }
}
