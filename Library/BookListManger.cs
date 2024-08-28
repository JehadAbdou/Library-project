using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Resources
{
    public class BookListManger
    {
        private BindingList<Books> booksList =  new BindingList<Books>(); //A binding list to Bind the list data to the Datagrid view


        public BookListManger()
        {
            

        }


        public BindingList<Books> List//prop to recive the list items
        {
            get { return booksList; }
        }

        public void AddBook(Books book)// Add a book the list
        {
            if (book != null)
            { booksList.Add(book); }

        }

        public void RemoveBook(int Index)//remove a book from the list
        {
            if (Index >= 0)
            { booksList.RemoveAt(Index); }

        }

        public void ChangeBook(int Index,Books book)//Change a book from the list
        {
            if(Index >= 0)
            {
                booksList[Index] = book;
            }


        }





    }
}
