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
    public partial class show_patient : Form
    {
        Database.information_load il = new Database.information_load();
        public int doctorid;
        public show_patient()
        {
            InitializeComponent();
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            String sql = "";
            string search_value= searchTB.Text;

            if (searchTB.Text == "")
                sql = "SELECT ps.pres_id,p.`p_id`,p.p_name,p.p_age,ps.`medicine_info`,ps.`advice` FROM `prescription` as ps,`patient` as p WHERE `remote_d_id` ="+doctorid+" and p.p_id = ps . p_id";
            else
                sql = "SELECT ps.pres_id,p.`p_id`,p.p_name,p.p_age,ps.`medicine_info`,ps.`advice` FROM `prescription` as ps,`patient` as p WHERE `remote_d_id` ="+doctorid+" and p.p_id = ps . p_id  and  p.`p_name` LIKE '%" + search_value + "%' OR p.`p_address` LIKE '%" + search_value + "%'";
            
            il.datagridview_load(sql, dataGridView1);


            
        }
    }
}
