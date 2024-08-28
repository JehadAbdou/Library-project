using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Resources
{
    public class Books
    {
        private string Name;
        private string Author;
        private int Quentity;
        private string Description;
        private Category Catagory;
        [DisplayName("Book Name")] //To set the Headers Name in the data grid view For a better GUI 

        public string BookName
        {
            get { return Name; }
            set { Name = value; }
        }
        [DisplayName("Author")]
        public string author
        {
            get { return Author; }
            set { Author = value; }
        }
        [DisplayName("Catagory")]
        public Category catagory
        {
            get { return Catagory; }
            set { Catagory = value; }
        }

        [DisplayName("Quentity")]
        public int quentity
        {
            get { return Quentity; }
            set { Quentity = value; }
        }
        [DisplayName("Description")]
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }


        public Books()
        {

        }

        







    }
}
