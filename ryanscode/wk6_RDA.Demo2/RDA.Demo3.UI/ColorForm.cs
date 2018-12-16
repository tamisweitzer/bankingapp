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
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(255);
            int g = random.Next(255);
            int b = random.Next(255);
            BackColor = Color.FromArgb(r, g, b);
        }
    }
}
