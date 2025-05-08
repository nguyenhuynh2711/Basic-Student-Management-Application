using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace GUI_QLSV_DA
{
    public partial class InBangDiem1SV : Form
    {
        public InBangDiem1SV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            rptInDanhSachDiem1SV rp = new rptInDanhSachDiem1SV();

            // khai bao cac tham so cho report
            ParameterValues para = new ParameterValues();
            // gia tri tham so
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue();
            // gia tri cho than
            paraValue.Value = txtMaSV.Text;

            // them vao
            para.Add(paraValue);

            //them vao report
            rp.DataDefinition.ParameterFields["@masv"].ApplyCurrentValues(para);
            crystalReportViewer1.ReportSource = rp;

        }
    }
}
