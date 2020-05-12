using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biomedical_Parameter_Treatment.doctor
{
    public partial class homepage : Form
    {
        public int doctor_id ;
        public homepage()
        {
            InitializeComponent();
        }

        private void add_patientB_Click(object sender, EventArgs e)
        {
            //this.Visible = true;
            add_patient aa = new add_patient();
            aa.Visible = true;

        }

        private void logoutB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 ss = new Form1();
            ss.Visible = true;
        }

        private void show_patientB_Click(object sender, EventArgs e)
        {
            show_patient sp = new show_patient();
            sp.Visible = true;

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            doctoridL.Text = "Doctor ID: " + doctor_id;
        }

        private void assign_patientB_Click(object sender, EventArgs e)
        {
            assign_patient ap = new assign_patient();
            ap.Visible = true;

        }

        private void treatment_Click(object sender, EventArgs e)
        {
            treatment tt = new treatment();
            tt.doctorid = this.doctor_id;
            tt.Visible = true;
        }
    }
}
