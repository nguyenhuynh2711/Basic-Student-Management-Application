using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLSV_DA;

namespace GUI_QLSV_DA
{
    public partial class DanhSachGiaoVien : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();
        }
        BUS_GiaoVien busGiaoVien = new BUS_GiaoVien();
        private void DanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            dgvDSGiaoVien.DataSource = busGiaoVien.layDSGiaoVien();
        }
    }
}
