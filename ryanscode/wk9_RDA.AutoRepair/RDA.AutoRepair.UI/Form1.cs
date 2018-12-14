using RDA.AutoRepair.BL;
using RDA.AutoRepair.PL;
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
            //customers.PopulateTestData();
            //customers.Sort();
            try
            {
                Type t = typeof(CustomerCollection);
                customers = DataAccess.LoadXml(t) as CustomerCollection;
            }
            catch
            {
                customers = new CustomerCollection();
            }

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
                #region Week 8 code (commented out)
                //try
                //{
                //    selected.Year = int.Parse(txtYear.Text);
                //}
                //catch (InvalidYearException iye)
                //{
                //    MessageBox.Show(iye.InvalidYear + " is not a valid year.");
                //}
                //catch (FormatException)
                //{
                //    MessageBox.Show("Year must be an iteger.");
                //}
                #endregion

                selected.VIN = txtVIN.Text;
                selected.Make = txtMake.Text;
                selected.Model = txtModel.Text;
                selected.Year = int.Parse(txtYear.Text);

                Customer c = lstCustomers.SelectedItem as Customer;
                RebindCars(c);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(txtFirstName.Text, txtLastName.Text, txtPhone.Text);
            customers.Add(c);
            RebindCustomers();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem is Customer selected)
            {
                selected.FirstName = txtFirstName.Text;
                selected.LastName = txtLastName.Text;
                selected.PhoneNumber = txtPhone.Text;

                RebindCustomers();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem is Customer selected)
            {
                customers.Remove(selected);
                RebindCustomers();
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem is Customer selected)
            {
                Car c = new Car(txtMake.Text, txtModel.Text, int.Parse(txtYear.Text));
                c.VIN = txtVIN.Text;
                selected.Cars.Add(c);
                RebindCars(selected);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedItem is Car selected)
            {
                Customer c = lstCustomers.SelectedItem as Customer;
                c.Cars.Remove(selected);
                RebindCars(c);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                customers.SaveXml();
            }
            catch
            {
                string m = "An error occurred. Do you want to exit (without saving)?";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                MessageBoxIcon i = MessageBoxIcon.Error;
                MessageBoxDefaultButton d = MessageBoxDefaultButton.Button2;
                DialogResult dlgResult = MessageBox.Show(m, "Error", b, i, d);
                if (dlgResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
