using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Thêm thư viện
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


// thêm
using BUS_QLSV_DA;
using ET_QLSV_DA;

namespace GUI_QLSV_DA
{
    public partial class InSinhVienThuocKhoa : Form
    {
        public InSinhVienThuocKhoa()
        {
            InitializeComponent();
        }
        BUS_Khoa busKhoa = new BUS_Khoa();

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            InDanhSachSinhVienThuocKhoa rp = new InDanhSachSinhVienThuocKhoa();

            // Khai báo các tham số cho report
            ParameterValues para = new ParameterValues();

            // Giá trị cho tham số
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue();

            // Lấy giá trị cho tham số
            paraValue.Value = cboMaKhoa.SelectedValue.ToString();

            // Thế vào
            para.Add(paraValue);

            // Thêm vào report
            rp.DataDefinition.ParameterFields["@maKhoa"].ApplyCurrentValues(para);

            crystalReportViewer1.ReportSource = rp;
        }

        private void InSinhVienThuocKhoa_Load(object sender, EventArgs e)
        {
            // Thêm thư viện vào combobox
            cboMaKhoa.DataSource = busKhoa.layDSKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
        }
    }
}
