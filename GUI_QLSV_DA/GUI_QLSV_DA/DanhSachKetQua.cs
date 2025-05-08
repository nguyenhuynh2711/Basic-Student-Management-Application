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
    public partial class DanhSachKetQua : Form
    {
        public DanhSachKetQua()
        {
            InitializeComponent();
        }
        BUS_KetQua busKetQua = new BUS_KetQua();
        private void DanhSachKetQua_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = busKetQua.layDSKetQua();
        }
    }
}
