using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Thêm
using BUS_QLSV_DA;
using ET_QLSV_DA;

namespace GUI_QLSV_DA
{
    public partial class DanhSachKhoa : Form
    {
        public DanhSachKhoa()
        {
            InitializeComponent();
        }
        BUS_Khoa busKhoa = new BUS_Khoa();

        private void DanhSachKhoa_Load(object sender, EventArgs e)
        {
            dgvDanhSachKhoa.DataSource = busKhoa.layDSKhoa();
        }
    }
}
