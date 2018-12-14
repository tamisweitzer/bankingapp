using System;
using System.Windows.Forms;
using TSS.BankingApp.BL;



namespace TSS.BankingApp.UI
{
    public partial class BankingAppForm : Form
    { 
        // Field 
        private CustomerCollection customers = new BL.CustomerCollection();
    
        public BankingAppForm()
        {
            InitializeComponent();
        }

        private void BankingAppForm_Load(object sender, EventArgs e)
        {
            customers.Populate();
            
        }

     

       
       
    }
}
