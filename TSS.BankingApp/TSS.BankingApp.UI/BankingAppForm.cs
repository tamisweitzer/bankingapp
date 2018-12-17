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

            DataTable dt = new DataTable();
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("SSN");
            dt.Columns.Add("Birthdate");
            dt.Columns.Add("LastDeposit");
            foreach (var i in customers)
            {
                dt.Rows.Add(new object[] {
                    i.FirstName,
                    i.LastName,
                    i.SSN,
                    i.BirthDate.ToShortDateString(),
                    i.LastDeposit.Amount.ToString("c") });
            }
            DgvDeposits.DataSource = dt;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("FirsttName");
            dt2.Columns.Add("LastName");
            dt2.Columns.Add("SSN");
            dt2.Columns.Add("Birthdate");
            dt2.Columns.Add("LastWithdrawl");
            foreach (var i in customers)
            {
                dt2.Rows.Add(new object[] {
                    i.FirstName,
                    i.LastName,
                    i.SSN,
                    i.BirthDate.ToShortDateString(),
                    i.LastWithdrawl.Amount.ToString("c") });
            }
            DgvWithdrawls.DataSource = dt2;
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
                txtBirthDate.Text = (selected.BirthDate).ToShortDateString();
                lblDisplayAge.Text = (DateTime.Now.Year - selected.BirthDate.Year).ToString();

                RebindCustomers(selected);
            }
        }
    }
}
