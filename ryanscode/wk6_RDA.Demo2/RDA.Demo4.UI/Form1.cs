using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RDA.Demo4.UI
{
    public partial class Form1 : Form
    {

        // Fields
        private List<Entree> entrees = new List<Entree>();
        private Order order = new Order();

        public Form1() // Constructor 
        {
            InitializeComponent();

            Entree e;
            e = new Entree();
            e.Name = "Pizza";
            e.BaseCost = 1.5;
            e.AddOns.Add(new AddOn() { Name = "Sausage", Cost = .75 });
            e.AddOns.Add(new AddOn() { Name = "Pepperoni", Cost = .75 });
            e.AddOns.Add(new AddOn() { Name = "Olives", Cost = .50 });
            entrees.Add(e);

            e = new Entree();
            e.Name = "Hamburger";
            e.BaseCost = 1;
            e.AddOns.Add(new AddOn() { Name = "Lettuce", Cost = .25 });
            e.AddOns.Add(new AddOn() { Name = "Mayo", Cost = .25 });
            e.AddOns.Add(new AddOn() { Name = "Bacon", Cost = 1 });
            entrees.Add(e);

            Temp();
        }

        private void Temp()
        {
            cboEntrees.Items.Add("Pizza");
            cboEntrees.Items.Add("Hamburger");
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblTotal.Text = order.Total.ToString("c");

        }

        private void btnAddEntree_Click(object sender, EventArgs e)
        {
            if (cboEntrees.SelectedIndex >= 0)
            {
                order.Items.Add(entrees[cboEntrees.SelectedIndex].Clone());
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Button pressed = sender as Button;

            MessageBox.Show(pressed.Text);
        }
    }
}
