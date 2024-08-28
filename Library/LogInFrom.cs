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
    public partial class LogInFrom : Form
    {
        
        public LogInFrom()
        {
            InitializeComponent();
        }

      
        private void label2_Click(object sender, EventArgs e)//Exit the application
        {
            Application.Exit();
        }

      

        private void label3_Click(object sender, EventArgs e)//pressing the login button
        {

            if (textBox1.Text.ToLower() == "admin" && textBox2.Text == "admin")//if the admin enters the right username and passowrd
            {
                MainForm form = new MainForm();
                this.Visible = false;
                form.Show();

            }

            else
            {
                MessageBox.Show("Wrong username or password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
    }
}
