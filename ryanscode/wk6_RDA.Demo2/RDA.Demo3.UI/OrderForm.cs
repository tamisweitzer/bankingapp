using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RDA.Demo3.UI
{
    public partial class OrderForm : Form
    {
        //private string[] entrees = new string[3];
        private string[] entrees = { "Pizza", "Hamburger", "Salad" };
        private RadioButton[] rdoEntrees = new RadioButton[3];
        private CheckBox[] chkAddOns = new CheckBox[3];

        // 2d array
        private string[,] addOns =
        {
            { "Sausage", "Pepperoni", "Extra Cheese" }, // Pizza
            { "Lettuce", "Tomato", "Bacon" }, // Hamburger
            { "Cheese", "Crutons", "Dressing" } // Salad
        };

        // list (dynamically grow)
        private List<int> numbers = new List<int>();

        public OrderForm()
        {
            InitializeComponent();

            numbers.Add(5);
            numbers.Add(12);
            numbers.Add(34);

            foreach (int i in numbers)
            {
                //MessageBox.Show(i.ToString());
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control c in grpEntrees.Controls)
            {
                if (c is RadioButton)
                {
                    rdoEntrees[i] = (RadioButton)c;
                    rdoEntrees[i].Text = entrees[i];
                    i++;
                }
            }

            i = 0;
            foreach (Control c in grpAddOns.Controls)
            {
                if (c is CheckBox)
                {
                    chkAddOns[i] = (CheckBox)c;
                    i++;
                }
            }

            foreach(string s in entrees)
            {
                cboEntrees.Items.Add(s);
            }

            rdoEntree1.Checked = true;
            cboEntrees.SelectedIndex = 0;
        }

        private void UpdateAddOns(int index)
        {
            int i = 0;
            foreach(CheckBox cb in chkAddOns)
            {
                cb.Text = addOns[index, i];
                i++;
            }
        }

        private void rdoEntree1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddOns(0);
        }

        private void rdoEntree2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddOns(1);
        }

        private void rdoEntree3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddOns(2);
        }

        private void cboEntrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddOns(cboEntrees.SelectedIndex);
            DoSomething();
        }

        private void DoSomething()
        {
            //throw new Exception();
        }
    }
}
