using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace ExcellFileImport
{
    public partial class Form1 : Form
    {


        public MySqlConnection connection;
        public string server;
        public string data;
        public string uid;
        public string password;

        public Form1()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            server = "localhost";
            data = "excellupload";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + data + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        
        }

        private void bBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            bTB.Text = openFileDialog1.FileName;

            if (dr == DialogResult.OK)
            {

             string connectionString =
             String.Format( @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""",openFileDialog1.FileName);
             string query = String.Format("select * from [{0}$]", "Sheet1");
             OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
             DataSet dataSet = new DataSet();
             dataAdapter.Fill(dataSet);
             showDGV.DataSource = dataSet.Tables[0];

           }
        }

        private void saveBT_Click(object sender, EventArgs e)
               {
            string StrQuery;
               {
                for (int i = 0; i < showDGV.Rows.Count; i++)
                {
             
                    StrQuery = "INSERT INTO student_info(name,class_roll,registration_no,session) VALUES ('" + showDGV.Rows[i].Cells[0].Value + "',' " +
                               showDGV.Rows[i].Cells[1].Value + "','" + showDGV.Rows[i].Cells[2].Value + "','" + showDGV.Rows[i].Cells[3].Value + "','" + showDGV.Rows[i].Cells[4].Value + "')";

                    MySqlCommand comm = new MySqlCommand(StrQuery, connection);
                    comm.CommandText = StrQuery;
             
                    comm.ExecuteNonQuery();
           
                }
                MessageBox.Show("Data Insert Successful.");

              }

             }

    }
}
