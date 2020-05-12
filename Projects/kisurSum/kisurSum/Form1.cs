using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kisurSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstTB.Text);
            double second = double.Parse(secondTB.Text);
            double sum = first + second;
            MessageBox.Show("Your sum is:" +sum);
        }
    }
}
