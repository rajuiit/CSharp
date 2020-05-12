using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Badhon
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
           // bloodCB.SelectedIndex = 0;
            deptCB.SelectedIndex = 0;
            hallCB.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String blood = bloodCB.SelectedItem.ToString();
           // String serial = serialTB.Text;
            String name = nameTB.Text;
            //String father = fatherTB.Text;
           // String mother = motherTB.Text;
            String dept = deptCB.SelectedItem.ToString();
            String hall = hallCB.SelectedItem.ToString();
            //String session = sessionCB.SelectedItem.ToString();
            //String hallName = hallNameCB.SelectedItem.ToString();

            List<ReportParameter> rptPara = new List<ReportParameter>();
           // rptPara.Add(new ReportParameter("blood", blood));
           // rptPara.Add(new ReportParameter("serial", serial));
            rptPara.Add(new ReportParameter("name", name));
           // rptPara.Add(new ReportParameter("father", father));
           // rptPara.Add(new ReportParameter("mother", mother));
            rptPara.Add(new ReportParameter("dept", dept));
            rptPara.Add(new ReportParameter("hall", hall));
          

            reportViewer1.LocalReport.SetParameters(rptPara);
            
            
            this.reportViewer1.RefreshReport();
        }

       

      

        

       
    }
}
