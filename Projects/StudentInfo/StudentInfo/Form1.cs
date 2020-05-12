using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form

    {
        student sobj = new student();
        public Form1()
        {
            InitializeComponent();
            sexCB.DataSource = Enum.GetNames(typeof(student.sexE));
            sexCB.Text = "";
        }

        private void cBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sBT_Click(object sender, EventArgs e)
        {
             string welcomeNote =sobj.welcomeNote();
             string presentNote = sobj.presentNote();
             MessageBox.Show("\t" + welcomeNote + "\n\n"+presentNote+ "\n\nStudent Name: " + sobj.Name+ "\n\nRoll:"+sobj.Roll+ "\n\n CGPA:" +sobj.Cgpa+ "\n\n Sex:" +sobj.Sex+ "\n\n Date Of Birth:" +sobj.Dob);
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            if (rollTB.Text == "" || cgpaTB.Text == "" )
            {

                MessageBox.Show("Please fill all the required field first.........");
                rollTB.Focus();
                cgpaTB.Focus();

            }
            else
            {
                sobj.Name = nameTB.Text;
                sobj.Roll = rollTB.Text;
                sobj.Cgpa = cgpaTB.Text;
                sobj.Sex = sexCB.Text;
                sobj.Dob = dbDTP.Value.ToShortDateString();
            }

        }
    }
}
