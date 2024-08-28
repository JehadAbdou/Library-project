using Library.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Customers
    {
        private string Name;
        private string Email;
        private int Phone;
        private string Address;
        private DateTime backDate;
        
        private string BookName;
        private string BuyorLoan;

        public Customers(Books books)
        {
            

        }
        [DisplayName("Name")]//Set the headers name for the DataGridView
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        [DisplayName("Email")]
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        [DisplayName("Phone")]
        public int phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        [DisplayName("Address")]
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        [DisplayName("Return or Purchess Date")]
        public DateTime date
        {
            get
            {
                return backDate;
            }
            set
            {
                backDate = value;
            }
            
        }
        [DisplayName("Book Name")]
        public string bookName
        {
            get { return BookName ; }
            set { BookName = value; }
            
        }

        [DisplayName("Buy or Loan")]
        public string BuyOrLoan
        {
            get { return BuyorLoan; }
            set { BuyorLoan = value; }
        }



    }
}
