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
    public partial class DanhSachMonHoc : Form
    {
        public DanhSachMonHoc()
        {
            InitializeComponent();
        }
        BUS_MonHoc busMonHoc  = new BUS_MonHoc();

        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
                     
            dgvDanhSachMonHoc.DataSource = busMonHoc.layDSMonHoc();     
        }
    }
}
