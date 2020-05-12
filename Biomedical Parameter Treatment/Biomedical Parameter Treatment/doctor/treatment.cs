﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biomedical_Parameter_Treatment.doctor
{
    public partial class treatment : Form
    {
        Database.dbConnect dbo = new Database.dbConnect();
        Database.information_load il = new Database.information_load();
        public int doctorid;
        public treatment()
        {
            InitializeComponent();
        }

        private void treatment_Load(object sender, EventArgs e)
        {

        }

        private void searchB_Click(object sender, EventArgs e)
        {
            String sql = "";
            string search_value = searchTB.Text;

            if (searchTB.Text == "")
                sql = "SELECT ps.pres_id,p.`p_id`,p.p_name,p.p_age,p.p_sex,p.p_phone,p.p_disease_info, ps.`medicine_info`,ps.`advice` FROM `prescription` as ps,`patient` as p WHERE ps.`d_id` =" + doctorid + " and p.p_id = ps . p_id";
            else
                sql = "SELECT ps.pres_id,p.`p_id`,p.p_name,p.p_age,p.p_sex,p.p_phone,p.p_disease_info, ps.`medicine_info`,ps.`advice` FROM `prescription` as ps,`patient` as p WHERE ps.`d_id` =" + doctorid + " and p.p_id = ps . p_id  and  p.`p_name` LIKE '%" + search_value + "%' OR p.`p_address` LIKE '%" + search_value + "%'";

            il.datagridview_load(sql, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            presidL.Text = dataGridView1[0, e.RowIndex].Value.ToString() ;
            pidL.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            pnameL.Text = dataGridView1[2, e.RowIndex].Value.ToString();
           pageL.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            psexL.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            pphoneL.Text= dataGridView1[5, e.RowIndex].Value.ToString();
            pdiseaseL.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            medicineTB.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            adviceTB.Text = dataGridView1[8, e.RowIndex].Value.ToString();
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (presidL.Text == "") {

                MessageBox.Show("Please select a patient.");
                return;
            }


            string query = "UPDATE `biomedical`.`prescription` SET `medicine_info` = '"+medicineTB.Text+"',`advice` = '"+adviceTB.Text+"' WHERE `prescription`.`pres_id` ="+presidL.Text+";";
            dbo.Update(query);
        }
    }
}
