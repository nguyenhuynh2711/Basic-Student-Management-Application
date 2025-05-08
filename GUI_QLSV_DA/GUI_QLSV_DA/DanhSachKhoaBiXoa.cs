using BUS_QLSV_DA;
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
    public partial class DanhSachKhoaBiXoa : Form
    {
        public DanhSachKhoaBiXoa()
        {
            InitializeComponent();
        }
        BUS_Khoa busKhoa = new BUS_Khoa();
        
        private void DanhSachKhoaBiXoa_Load(object sender, EventArgs e)
        {
            dgvKhoaAn.DataSource = busKhoa.LayKhoaAn();  // Hiển thị các khoa đã bị ẩn
        }

        private void dgvKhoaAn_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhoaAn.CurrentCell.RowIndex;
                txtMaKhoa.Text = dgvKhoaAn.Rows[dong].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvKhoaAn.Rows[dong].Cells[1].Value.ToString();
                txtDiaChiKhoa.Text = dgvKhoaAn.Rows[dong].Cells[2].Value.ToString();
                txtSoDienThoaiKhoa.Text = dgvKhoaAn.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnKhoiPhucKhoa_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khoa từ textbox
            ET_Khoa etKhoiPhucKhoa = new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChiKhoa.Text, txtSoDienThoaiKhoa.Text);

            // Gọi BUS để khôi phục
            if (busKhoa.KhoiPhucKhoa(etKhoiPhucKhoa))
            {
                MessageBox.Show("Khôi phục khoa thành công.");

                // Cập nhật lại danh sách
                dgvKhoaAn.DataSource = busKhoa.LayKhoaAn();  // Cập nhật danh sách các khoa ẩn
            }
            else
            {
                MessageBox.Show("Khôi phục khoa không thành công.");
            }
        }

        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtDiaChiKhoa.Clear();
            txtSoDienThoaiKhoa.Clear();
            txtTimKiemKhoa.Focus();

            string keyword = txtTimKiemKhoa.Text.Trim();

            if(string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }

            DataTable result = new DataTable();
            result = busKhoa.TimKiemKhoa(keyword);
            if(result.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy");
                dgvKhoaAn.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiemKhoa.Clear();
                dgvKhoaAn.DataSource = null;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtDiaChiKhoa.Clear();
            txtSoDienThoaiKhoa.Clear();
            txtTimKiemKhoa.Clear();

            dgvKhoaAn.DataSource = busKhoa.LayKhoaAn();

            txtMaKhoa.Focus();
        }

        private void DanhSachKhoaBiXoa_FormClosing(object sender, FormClosingEventArgs e)
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
