using Library.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        private BookListManger listManger;
        private CustomerManger customerList;
        
        public MainForm()
        {
            
            listManger = new BookListManger();
            customerList = new CustomerManger();
            InitializeComponent();
           
            InitializeGUI();



        }
        private void InitializeGUI()//Initialize the DataGrid view and toioTip to help the user understand the functionality of the buttons
        {
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(Add_btn, "Add an book");
            toolTip1.SetToolTip(Edit_btn, "Edit book details");
            toolTip1.SetToolTip(Remove_btn, "Remove a book");
            toolTip1.SetToolTip(Customers_btn, "Customers List");
            BookList_DG.DataSource = listManger.List;

        }


       

        
        




        private void pictureBox1_Click(object sender, EventArgs e)//Exit the program
        {
            Application.Exit();

        }

        

        private void lbl_guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// To test the functionality of the Guest mode
        {
            GuestForm form = new GuestForm(listManger,customerList);
            DialogResult dlg = form.ShowDialog();
            if (dlg == DialogResult.Cancel)
            {
                BookList_DG.Refresh();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//To add a new book to the librar
        {
            Books books = new Books();
            AddBookForm form = new AddBookForm();
            bool OK = true ; 
            
            DialogResult dlg = form.ShowDialog();  
            if(dlg ==DialogResult.OK)
            {
                Books book = form.books;
                for(int i = 0; i < listManger.List.Count; i++)
                {
                    if(book.BookName == listManger.List[i].BookName)
                    {
                        MessageBox.Show("Book already exist please give another book name!!!");
                        OK = false;
                        break;
                    }
                }
                if (OK)
                {
                    listManger.AddBook(book);
                }

            }
            
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)//to remove a book from the library
        {
            if (BookList_DG.Rows.Count > 0)
            {
                if (BookList_DG.SelectedRows.Count > 0)
                {
                    int rowIndex = BookList_DG.SelectedRows[0].Index;
                    if (rowIndex >= 0 && rowIndex < BookList_DG.Rows.Count)
                    {
                        BookList_DG.Rows.RemoveAt(rowIndex);
                      
                        
                    }
                    else
                    {
                        MessageBox.Show("The selected row index is out of range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Handle the case where no row is selected
                }


            }
            
        
            else
            {

                MessageBox.Show("There are no rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Handle the case where there are no rows in the DataGridView
            }



}

        private void pictureBox4_Click(object sender, EventArgs e)//to edit a book in the library
        {
            int index = BookList_DG.SelectedRows[0].Index;

            Books book = listManger.List[index];

            AddBookForm form = new AddBookForm(book);
            
            DialogResult dlg = form.ShowDialog();
            
            if (dlg == DialogResult.OK)
            {
                Books books = form.books;
                listManger.List[index] = books;
                
            }


        }

        private void timer1_Tick(object sender, EventArgs e)//Gives the date and time of the day
        {
            lbl_clock.Text = DateTime.Now.ToString("F");
        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)//To go to the Customers list with data about loaned and purchessd booked
        {

            CustomersForm form = new CustomersForm(customerList);
            form.ShowDialog();

        }
    }
}
