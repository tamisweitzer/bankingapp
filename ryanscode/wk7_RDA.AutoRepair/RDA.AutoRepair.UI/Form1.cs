using RDA.AutoRepair.BL;
using System;
using System.Windows.Forms;

namespace RDA.AutoRepair.UI
{
    public partial class Form1 : Form
    {
        // Field
        private CustomerCollection customers = new CustomerCollection();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customers.PopulateTestData();
            RebindCustomers();
        }

        private void RebindCustomers()
        {
            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "DisplayName";
        }

        private void RebindCars(Customer c)
        {
            lstCars.DataSource = null;
            lstCars.DataSource = c.Cars;
            lstCars.DisplayMember = "DisplayName";
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Customer selected = lstCustomers.SelectedItem as Customer;
            //if (selected != null)

            if (lstCustomers.SelectedItem is Customer selected) // same as above
            {
                txtFirstName.Text = selected.FirstName;
                txtLastName.Text = selected.LastName;
                txtPhone.Text = selected.PhoneNumber;

                RebindCars(selected);
            }
        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCars.SelectedItem is Car selected)
            {
                txtMake.Text = selected.Make;
                txtModel.Text = selected.Model;
                txtYear.Text = selected.Year.ToString();
                txtVIN.Text = selected.VIN;
            }
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedItem is Car selected)
            {
                try
                {
                    selected.Year = int.Parse(txtYear.Text);
                }
                catch (InvalidYearException iye)
                {
                    MessageBox.Show(iye.InvalidYear + " is not a valid year.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Year must be an iteger.");
                }
            }
        }
    }
}
