using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Namata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void namTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    label1.Text = label1.Text + namTB.Text + " X " + i.ToString() + " = " + (Convert.ToInt32(namTB.Text.Trim()) * i) + "\n";
                }
            }
            catch { namTB.Text = ""; label1.Text = ""; };
        }
    }
}
