using Library.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class CustomersForm : Form
    {
        private CustomerManger customer;
        
        public CustomersForm(CustomerManger manger)//A list of Customers that loaned and Purchessed books
        {
            
            InitializeComponent();
            customer = manger;
            if (customer.CustomersList != null && customer.CustomersList.Any())
            {
                CustomerList_DG.AutoGenerateColumns = true;
                CustomerList_DG.DataSource = customer.CustomersList;//initialize the the data grid with Customers list
            }
            else
            {
                MessageBox.Show("Customers List is empty.");
            }
            
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)//Close the form
        {
            this.Close();
        }
    }
}
