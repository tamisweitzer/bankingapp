using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntermediateDemoWeek3
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
            int red = random.Next(255);
            int green = random.Next(255);
            int blue = random.Next(255);

            BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
