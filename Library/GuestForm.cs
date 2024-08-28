using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Resources
{
    public partial class GuestForm : Form
    {
        private BookListManger listManger;
        private BindingList<Books> filteredBooks;
        private CustomerManger customerList;
        public GuestForm(BookListManger manager,CustomerManger customer)
        {
            InitializeComponent();
            listManger = manager;
            customerList = customer;
            filteredBooks = new BindingList<Books>(listManger.List.ToList());//Creat a List for the serach box
            Book_DG.DataSource = filteredBooks;
            SearchBox_txt.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Change the items in list according the text written by the customer
        {
            string searchText = SearchBox_txt.Text.ToLower();
            List<Books> tempList = listManger.List.Where(book => book.BookName.ToLower().Contains(searchText)).ToList();
            filteredBooks.Clear();

            foreach (Books book in tempList)
            {
                filteredBooks.Add(book);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)//close the form
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Loan_Click(object sender, EventArgs e)//Buying or Loaning A book
        {
            
            if (Book_DG.SelectedRows.Count > 0)
            {
                int index = Book_DG.SelectedRows[0].Index;
                if (listManger.List[index].quentity > 0)
                {
                    ContactDetails contact = new ContactDetails(index,listManger);
                    DialogResult dlg = contact.ShowDialog();
                    if (dlg == DialogResult.OK)
                    {
                        Books book = listManger.List[index];
                        Customers customer = new Customers(book);
                        customer = contact.customers;
                        customerList.AddLoan(customer);

                        listManger.List[index].quentity -= 1;
                    }
                    Book_DG.Refresh();
                }
                else
                {
                    MessageBox.Show(" The book you are trying to loan is out of stock..!!");//if the book quentity is 0
                }

            }
            else
            {
                MessageBox.Show("No book is selected....!!!,Please select a book...!!!");//if the user didnt select any book from the list
            }


        }

       

        



        private void btn_Loan_MouseEnter(object sender, EventArgs e)//changing the color of the button when the mouse is over the button
        {
            btn_LoanAndBuy.BackColor = Color.DarkOrange;
        }

        private void btn_Loan_MouseLeave(object sender, EventArgs e)//changing the color of the button when the mouse leaves the button
        {
            btn_LoanAndBuy.BackColor = Color.RosyBrown;
        }



       


    }
}

