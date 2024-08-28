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
    public partial class AddBookForm : Form
    {
        private Books book;
        public AddBookForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Category)));
            comboBox1.SelectedIndex = (int)Category.Fiction;
        }
        
        public AddBookForm(Books books)
        {

            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Category)));
            this.book = books;
            InitializeGUI();


        }
        private void InitializeGUI()
        {
            txt_Name.Text = book.BookName;
            txt_Author.Text = book.author;
            txt_Qty.Text = book.quentity.ToString();
            comboBox1.SelectedIndex = (int)book.catagory;
            txt_Desc.Text = book.description;



        }


        public Books books
        {
            get { return book; }
            set { book = value; }
        }

        private bool NewBook()// Add a book to the list and check if the information Enterd buy the user is correct
                              
        {
            int Qty = 0;
            bool ok = int.TryParse(txt_Qty.Text, out Qty);
            if (ok &&
                 !string.IsNullOrEmpty(txt_Name.Text) &&
                 !string.IsNullOrEmpty(txt_Author.Text) &&
                 !string.IsNullOrEmpty(txt_Desc.Text) )
            {
                Books book = new Books();
                book.BookName = txt_Name.Text;
                book.author = txt_Author.Text;


                book.catagory = (Category)comboBox1.SelectedIndex;
                book.quentity = Qty;
                book.description = txt_Desc.Text;
                this.book = book;

                return true;
            }

            else
                return false;

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)//Retun OK to main forn if the Entered Info is correct
        {
            if (NewBook())
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Please Fill all the fields with a valid value...!!!");
            
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)//Close the Form
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

       
    }
}
