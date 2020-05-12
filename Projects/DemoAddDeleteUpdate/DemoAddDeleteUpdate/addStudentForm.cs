using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemoAddDeleteUpdate
{
    public partial class addStudentForm : Form
    {
       dbConnect dbo = new dbConnect();
        
        public addStudentForm()
        {
            InitializeComponent();
            //sSessionCB.SelectedIndex = sSessionCB.FindStringExact("2009-2010");
            //sSessionCB.SelectedIndex = 0;
            //sSemesterCB.SelectedIndex = 0;
             //dbConnect.Initialize();
            
        }

        private void addSBT_Click(object sender, EventArgs e)
        {
            // string roll = sClassRollTB.Text;
            MySqlConnection con = dbConnect.Initialize();

            if (sNameTB.Text == "" || sClassRollTB.Text == "" || sExamRollTB.Text == "" || sRegisTB.Text == "")
            {

                MessageBox.Show("empty field is not allow. try again.", "Empty");
                return; 
            }
          
           
              
                con.Open();

                string sql = "insert into `student_info`(`s_name`,`s_c_roll`,`s_e_roll`,`s_reg_number`,`session`,`semester`) values('" + sNameTB.Text + "','" + sClassRollTB.Text + "','" + sExamRollTB.Text + "','" + sRegisTB.Text + "','" + sSessionCB.SelectedItem+ "','" + sSemesterCB.SelectedItem+"');";
                //dbo.inupdel(sql, "New Student Has Been Created");
                try
                {
                    DialogResult d = MessageBox.Show("Are you sure to do this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully data inserted.", "Success");
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message:" + ex.Message);
                    con.Close();

                }
            
           
        }

        private void cancelSBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

    }
}
