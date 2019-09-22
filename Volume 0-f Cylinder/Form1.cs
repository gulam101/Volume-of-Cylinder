using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_0_f_Cylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var AreYouSure = MessageBox.Show("Are you sure you want to exit?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (AreYouSure == DialogResult.Yes);
                {
                    Application.Exit();
                }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtRadius.Clear();
        }

        private void cmdCalc_Click(object sender, EventArgs e)
        {
            //Calculates the volume of the cylinder
            Single height = float.Parse(txtHeight.Text);
            Single radius = float.Parse(txtRadius.Text);
            Single volume = (float)22 / (float)7 * radius * radius * height;
            txtVolume.Text = volume.ToString();
        }
    }
}