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
    public partial class ThongTinKhoa : Form
    {
        public ThongTinKhoa()
        {
            InitializeComponent();
        }

        BUS_Khoa busKhoa = new BUS_Khoa();

        private void ThongtinKhoa_Load(object sender, EventArgs e)
        {
            dgvDSKhoa.DataSource = busKhoa.layDSKhoa();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            ET_Khoa etThemKhoa = new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChiKhoa.Text, txtSoDienThoaiKhoa.Text);
            if (busKhoa.ThemKhoa(etThemKhoa) == true)
            {
                MessageBox.Show("Thêm Thành Công");
                dgvDSKhoa.DataSource = busKhoa.layDSKhoa();
            }
            else {
                MessageBox.Show("Thêm Không Thành Công");
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            //ET_Khoa etXoaKhoa = new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChiKhoa.Text, txtSoDienThoaiKhoa.Text);
            //if (busKhoa.XoaKhoa(etXoaKhoa) == true)
            //{
            //    MessageBox.Show("Xóa Thành Công");
            //    dgvDSKhoa.DataSource = busKhoa.layDSKhoa();
            //}
            //else
            //{
            //    MessageBox.Show("Xóa Không Thành Công");
            //}

            // Ẩn Khoa
            ET_Khoa etXoaKhoa = new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChiKhoa.Text, txtSoDienThoaiKhoa.Text);
            if (busKhoa.AnKhoa(etXoaKhoa))
            {
                MessageBox.Show("Khoa đã xóa thành công.");
                dgvDSKhoa.DataSource = busKhoa.layDSKhoa();
            }
            else
            {
                MessageBox.Show("Xóa Khoa không thành công.");
            }
        }

        private void dgvDSKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaKhoa.Enabled = false;

                int dong = dgvDSKhoa.CurrentCell.RowIndex;
                txtMaKhoa.Text = dgvDSKhoa.Rows[dong].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvDSKhoa.Rows[dong].Cells[1].Value.ToString();
                txtDiaChiKhoa.Text = dgvDSKhoa.Rows[dong].Cells[2].Value.ToString();
                txtSoDienThoaiKhoa.Text = dgvDSKhoa.Rows[dong].Cells[3].Value.ToString();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            ET_Khoa etSuaKhoa = new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChiKhoa.Text, txtSoDienThoaiKhoa.Text);
            if (busKhoa.SuaKhoa(etSuaKhoa) == true)
            {
                MessageBox.Show("Thay Đổi Thông Tin Thành Công");
                dgvDSKhoa.DataSource = busKhoa.layDSKhoa();
            }
            else
            {
                MessageBox.Show("Thay Đổi Thông Tin Không Thành Công");
            }
        }

        private void btnLamMoiKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = true;
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtDiaChiKhoa.Clear();
            txtSoDienThoaiKhoa.Clear();

            txtTimKiemKhoa.Clear();

            txtMaKhoa.Focus();
            dgvDSKhoa.DataSource = busKhoa.layDSKhoa();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();

            txtDiaChiKhoa.Clear();
            txtSoDienThoaiKhoa.Clear();

            string keyword = txtTimKiemKhoa.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataTable result = busKhoa.TimKiemKhoa(keyword);

            if (result.Rows.Count > 0)
            {
                dgvDSKhoa.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khoa nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDSKhoa.DataSource = null;
            }
        }

        private void ThongTinKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát ?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
