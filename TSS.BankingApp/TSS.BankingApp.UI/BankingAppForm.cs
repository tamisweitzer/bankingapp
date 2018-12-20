using System;
using System.Windows.Forms;
using TSS.BankingApp.BL;
using System.Data;
using System.Collections.Generic;

namespace TSS.BankingApp.UI
{
    public partial class BankingAppForm : Form
    {
        // Field 
        private CustomerCollection customers = new CustomerCollection();


        public BankingAppForm()
        {
            InitializeComponent();
        }


        private void BankingAppForm_Load(object sender, EventArgs e)
        {
            customers.Populate();
            RebindCustomers();
            
            // Deposit Table
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("LastName");
            //dt.Columns.Add("LastDeposit");
            dt.Columns.Add("BirthDate");

            foreach (var i in customers)
            {
                dt.Rows.Add(new object[] {
                    i.CustomerID,
                    i.LastName,
                    //i.LastDeposit.Amount.ToString(),
                    i.BirthDate.ToShortDateString()                    
                });
            }
            DgvDeposits.DataSource = dt;


            // Withdrawl table
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID");
            dt2.Columns.Add("FullName");
           // dt.Columns.Add("Last Withdrawl");
            //dt2.Columns.Add("Date");


            foreach (var i in customers)
            {
                dt2.Rows.Add(new object[] {
                    i.CustomerID,
                    i.FullName
                    //i.LastWithdrawl.Amount.ToString("c"),
                    //i.LastDeposit.Amount.ToString("c"),
                    //i.LastDeposit.DepositDate.ToString()
                });
            }
            DgvWithdrawls.DataSource = dt2;


            // TEMPORARY TABLE
            //  Deposit Table
            DataTable dtemp = new DataTable();
            dtemp.Columns.Add("ID");
            dtemp.Columns.Add("FirstName");
            dtemp.Columns.Add("LastName");
            dtemp.Columns.Add("BirthDate");
            dtemp.Columns.Add("LastDeposit");
            dtemp.Columns.Add("LastWithdrawl");
            

            foreach (var i in customers)
            {
                dtemp.Rows.Add(new object[] {
                    i.CustomerID,
                    i.FirstName,
                    i.LastName,
                    i.BirthDate.ToShortDateString(),
                    //i.LastDeposit.DepositAmount.ToString(), //BUG 'Object reference not set to an instance of an object.'
                    //i.LastWithdrawl.Amount.ToString() //BUG 'Object reference not set to an instance of an object.'
         
                }); 
                   
            }
            dgvTempTable.DataSource = dtemp;
        }


        


        private void RebindCustomers()
        {
            lstbxCustomersList.DataSource = null;
            lstbxCustomersList.DataSource = customers;
            lstbxCustomersList.DisplayMember = "FullName";
        }

        // Rebind after passing in the selected customer
        private void RebindCustomers(Customer c)
        {
            lstbxCustomersList.DataSource = null;
            lstbxCustomersList.DataSource = customers;
            lstbxCustomersList.DisplayMember = "FullName";
        }


        private void lstbxCustomersList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstbxCustomersList.SelectedItem is Customer selected)
            {
                lblDisplayID.Text = selected.CustomerID.ToString();
                txtFirstName.Text = selected.FirstName;
                txtLastName.Text = selected.LastName;
                txtSSN.Text = selected.SSN;
                dtBirthDate.Text = (selected.BirthDate).ToShortDateString();
                lblDisplayAge.Text = (DateTime.Now.Year - selected.BirthDate.Year).ToString();

                RebindCustomers(selected);
            }

            
        }

        

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int id = customers.IncrementID();
        
            Customer c = new Customer();
            c.CustomerID = id;
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.SSN = txtSSN.Text;
            c.BirthDate = dtBirthDate.Value;
            customers.Add(c);                      
        }


        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplayID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSSN.Text = "";
            //dtBirthDate.Value = DateTimePicker.MinimumDateTime;
            dtBirthDate.Value = DateTime.Now;
            lblDisplayAge.Text = "";
        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadFromXML_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {

        }

        private void btnReadFromDB_Click(object sender, EventArgs e)
        {

        }
    }
}
