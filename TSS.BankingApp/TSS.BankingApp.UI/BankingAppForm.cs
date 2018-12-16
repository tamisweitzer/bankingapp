using System;
using System.Windows.Forms;
using TSS.BankingApp.BL;



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
                txtBirthDate.Text = (selected.BirthDate).ToString();
                lblDisplayAge.Text = (DateTime.Now.Year - selected.BirthDate.Year).ToString();

                RebindCustomers(selected);
            }
        }
    }
}
