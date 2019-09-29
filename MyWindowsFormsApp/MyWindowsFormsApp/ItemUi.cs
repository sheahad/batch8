using System;
using System.Collections.Generic;
using System.ComponentModel;


using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price can not be Empty!!");
                return;
            }

            //Unique
            if (_itemManager.IsNameExist(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exist!!");
                return;
            }

            //Add/Insert
            if (_itemManager.Add(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text)))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource =_itemManager.Display();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Display();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            //Delete
            if (_itemManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            showDataGridView.DataSource = _itemManager.Display();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            if (_itemManager.Update(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
                showDataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           showDataGridView.DataSource=  _itemManager.Search(nameTextBox.Text);
        }

        
        
        
        
        
        
        
    }


}
