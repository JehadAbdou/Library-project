using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class CustomerManger
    {

        private BindingList<Customers> CustomerMNGR = new BindingList<Customers>();//Customers lIST

        

        public CustomerManger()
        {
            


        }


        public BindingList<Customers> CustomersList//return the items of the List
        {
            get { return CustomerMNGR; }
        }
       




        public void AddLoan(Customers customer)//Add a customer to the list
        {
            if(customer != null)
                CustomerMNGR.Add(customer);
        }
       




    }
}
