using Library.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ContactDetails : Form
    {
        
        private BookListManger listManger;
        private Customers Customer;
        private DateTime PurchessDate;
        private int index;
        public ContactDetails(int index,BookListManger manger)//A consturctor that recives the index of the book from the list
            //and BookListManger class as a parameter
        {
            
            listManger = manger;
            InitializeComponent();
            this.index = index;
            rbtn_Loan.Checked = true;//set the radio button to loan as defult
            dateTimePicker1.MinDate = DateTime.Today; //set the min date that the customer can set
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(30);//set the max date that the customer can loan the book for
        }
        
       
       

        
        public Customers customers
        {
            get { return Customer; }
            set
            {
                Customer = value;
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)//close the form
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if(Check())
            {
                
                
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("One or more of the fileds is not correct..!!!");
            }
           
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool Check()//check if the info that the customer registerd ar correct
        {
            int Phone;
            
            if(int.TryParse(txt_Phone.Text, out Phone) &&
            txt_mail.Text.Contains("@") &&
            txt_mail.Text.Contains("mail.com"))
            {
                Books book = listManger.List[index];
                Customers customer = new Customers(book);
                customer.name = txt_name.Text;
                customer.email = txt_mail.Text;
                customer.phone = Phone;
                customer.address = txt_address.Text;
                customer.bookName = book.BookName ;
                if (rbtn_buy.Checked)
                {
                    customer.date = PurchessDate;
                    customer.BuyOrLoan = "Buy";
                }
                else
                {
                    customer.date = dateTimePicker1.Value;
                    customer.BuyOrLoan = "Loan";
                }

                Customer = customer;



                return true;
            }
            else
            return false;
        }

        private void rbtn_buy_CheckedChanged(object sender, EventArgs e)//IF the customer want to buy the book
        {
            if (rbtn_buy.Checked)
            {
                dateTimePicker1.Visible = false;
                label5.Visible = false;
                PurchessDate = DateTime.Today;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//If the customer want to Loan the book
        {
            if (rbtn_Loan.Checked)
            {
                dateTimePicker1.Visible = true;
                label5.Visible = true;
                
            }

        }

       
    }
}
