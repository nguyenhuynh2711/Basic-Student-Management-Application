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
using ET_QLSV_DA;

namespace GUI_QLSV_DA
{
    public partial class DanhSachMonHocBiCoa : Form
    {
        public DanhSachMonHocBiCoa()
        {
            InitializeComponent();
        }
         BUS_MonHoc busMonHoc = new BUS_MonHoc();

        private void DanhSachMonHocBiCoa_Load(object sender, EventArgs e)
        {
            dgvMonHocAn.DataSource = busMonHoc.LayMonHocAn();
        }

        private void dgvMonHocAn_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvMonHocAn.CurrentCell.RowIndex;
                txtMaMon.Text = dgvMonHocAn.Rows[dong].Cells[0].Value.ToString();
                txtTenMon.Text = dgvMonHocAn.Rows[dong].Cells[1].Value.ToString();
                txtSoTinChi.Text = dgvMonHocAn.Rows[dong].Cells[2].Value.ToString();
                txtMaKhoa.Text = dgvMonHocAn.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnKhoiPhucMH_Click(object sender, EventArgs e)
        {
            int soTinChi = int.Parse(txtSoTinChi.Text);
            // Lấy thông tin MonHoc từ textbox
            ET_MonHoc etKhoiPhucMonHoc = new ET_MonHoc(txtMaMon.Text, txtTenMon.Text, soTinChi, txtMaKhoa.Text);

            // Gọi BUS để khôi phục
            if (busMonHoc.KhoiPhucMonHoc(etKhoiPhucMonHoc))
            {
                MessageBox.Show("Khôi phục Mon Hoc thành công.");

                // Cập nhật lại danh sách
                dgvMonHocAn.DataSource = busMonHoc.LayMonHocAn();  // Cập nhật danh sách các MonHoc ẩn
            }
            else
            {
                MessageBox.Show("Khôi phục Mon Hoc không thành công.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTinChi.Clear();
            txtMaKhoa.Clear();
            txtTimKiemMH.Clear();
            dgvMonHocAn.DataSource = busMonHoc.LayMonHocAn();

            txtMaKhoa.Focus();
        }

        private void btnTimKiemMH_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTinChi.Clear();
            txtMaKhoa.Clear();
            txtTimKiemMH.Focus();

            string keyword = txtTimKiemMH.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }

            DataTable result = new DataTable();
            result = busMonHoc.TimKiemMonHoc(keyword);
            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy");
                dgvMonHocAn.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiemMH.Clear();
                dgvMonHocAn.DataSource = null;
            }
        }

        private void DanhSachMonHocBiCoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
