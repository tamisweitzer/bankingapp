using System;
using System.IO;
using System.Windows.Forms;

namespace RDA.Demo2.UI
{
    public enum DoorState
    {
        Closed,
        Opening,
        Open,
        Closing
    }

    public partial class Form1 : Form
    {
        // Fields
        private ColorDialog dlgColor = new ColorDialog();
        private FontDialog dlgFont = new FontDialog();


        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Text Files|*.txt|All Files|*.*";
            dlgOpen.Title = "Open File";
            DialogResult dlgResult = dlgOpen.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                try
                {
                    // TODO: Open the file
                    StreamReader reader = new StreamReader(dlgOpen.FileName);
                    txtDisplay.Text = reader.ReadToEnd();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Text Files|*.txt|All Files|*.*";
            dlgSave.Title = "Save File";
            DialogResult dlgResult = dlgSave.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                try
                {
                    // TODO: Save the file
                    StreamWriter writer = new StreamWriter(dlgSave.FileName);
                    writer.Write(txtDisplay.Text);
                    writer.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                txtDisplay.ForeColor = dlgColor.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtDisplay.Font = dlgFont.Font;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            DoorState garage2 = DoorState.Open; // Ryans wife is worried

            if (garage2 == DoorState.Closed)
            {
                // good
            }

            DialogResult dlgButtonPress =
            MessageBox.Show("fjdkls", "title", MessageBoxButtons.YesNoCancel);

            if (dlgButtonPress == DialogResult.Yes)
            {
                MessageBox.Show("You pressed yes");
            }
            else if(dlgButtonPress == DialogResult.No)
            {
                MessageBox.Show("You pressed no");
            }
            else
            {
                MessageBox.Show("You pressed cancel");
            }
            */
        }
    }
}
