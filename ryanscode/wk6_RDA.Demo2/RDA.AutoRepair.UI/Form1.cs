using RDA.AutoRepair.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "DisplayName";
        }
    }
}
