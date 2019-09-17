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
    public partial class ArrayUi : Form
    {
        const int size = 3;

        string[] name = new string[size];

        int[] age = new int[size];
        int index = 0;
        public ArrayUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            
            string message = "";
            for (int index = 0; index < size; index ++)
            {
                message += "Name: " + name[index] + " Age: " + age[index]+ "\n";
                //message = message + "Name: " + name[index] + " Age: " + age[index];
            }

            MessageBox.Show(message);
            showRichTextBox.Text = message;



        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (index < size)
            {

                name[index] = nameTextBox.Text;
                age[index] = Convert.ToInt32(ageTextBox.Text);
                index++;
            }
            else
            {
                MessageBox.Show("Array is Full");
            }
        }
    }
}
