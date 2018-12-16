using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IntermediateDemoWeek3
{
    public partial class MainForm : Form
    {
        //private string[] names = { "Jill", "Joe", "James", "Jody", "Jack" };
        private List<string> names = new List<string>();
        private int nameIndex = -1;

        public MainForm() // Constructor
        {
            InitializeComponent();

            names.Add("Jill");
            names.Add("Joe");
            names.Add("James");
            names.Add("Jody");
            names.Add("Jack");
        }

        private void mnuColorForm_Click(object sender, EventArgs e)
        {
            nameIndex++;
            string name = names[nameIndex];
            if (nameIndex >= names.Count)
            {
                nameIndex = 0;
            }

            ColorForm frmColor = new ColorForm();
            frmColor.MdiParent = this;
            frmColor.Text = name;
            frmColor.Show();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            foreach(Form child in MdiChildren)
            {
                child.Close();
            }
        }

        private void mnuNameForm_Click(object sender, EventArgs e)
        {
            NewNameForm frmNewName = new NewNameForm();
            if (frmNewName.ShowDialog() == DialogResult.OK)
            {
                names.Add(frmNewName.NewName);
            }
        }
    }
}
