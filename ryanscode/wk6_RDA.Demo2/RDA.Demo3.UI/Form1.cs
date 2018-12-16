using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDA.Demo3.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNewColorForm_Click(object sender, EventArgs e)
        {
            ColorForm frmColor = new ColorForm();
            frmColor.MdiParent = this;
            frmColor.Show();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontally_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVertically_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
        }

        private void mnuNewOrderForm_Click(object sender, EventArgs e)
        {
            OrderForm frmOrder = new OrderForm();
            frmOrder.MdiParent = this;
            frmOrder.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnuNewOrderForm_Click(this, null);
        }
    }
}
