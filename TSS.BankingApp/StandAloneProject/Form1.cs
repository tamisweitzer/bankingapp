using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is a proof of concept to see if I can do it
// because I got so stuck on the assignment

namespace StandAloneProject
{

    
    public partial class Form1 : Form
    {
        // Start by creating a field that will be used by all members
        // to do stuff
        private CustomerCollection cust = new CustomerCollection();
        

        public Form1()
        {
            InitializeComponent();
        }

        // The load event 
        private void Form1_Load(object sender, EventArgs e)
        {

            // Call the populate() method from the CustomerCollection file
            // and then call the rebind customers function from this file

            cust.PopulateTestData();
            RebindCustomers();

        }


        private void RebindCustomers()
        {
            lbxCustomerList.DataSource = null;
            lbxCustomerList.DataSource = cust;
            lbxCustomerList.DisplayMember = "FullName";
        }




    }
}
