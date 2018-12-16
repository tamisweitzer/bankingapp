using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateDemoWeek3
{
    public partial class NewNameForm : Form
    {
        public string NewName { get; set; }

        public NewNameForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NewName = txtName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
