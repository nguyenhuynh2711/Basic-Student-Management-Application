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
    public partial class DanhSachKetQuaBiXoa : Form
    {
        public DanhSachKetQuaBiXoa()
        {
            InitializeComponent();
        }
        BUS_KetQua busKetQua = new BUS_KetQua();

        private void DanhSachKetQuaBiXoa_Load(object sender, EventArgs e)
        {
            dgvKetQuaAn.DataSource = busKetQua.LayKetQuaAn();
        }

        private void dgvKetQuaAn_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKetQuaAn.CurrentCell.RowIndex;
                txtMaSV.Text = dgvKetQuaAn.Rows[dong].Cells[0].Value.ToString();
                txtMaMon.Text = dgvKetQuaAn.Rows[dong].Cells[1].Value.ToString();
                txtDiem.Text = dgvKetQuaAn.Rows[dong].Cells[2].Value.ToString();
                txtHocKy.Text = dgvKetQuaAn.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnKhoiPhucKQ_Click(object sender, EventArgs e)
        {
            decimal diem = decimal.Parse(txtDiem.Text);
            // Lấy thông tin KetQua từ textbox
            ET_KetQua etKhoiPhucKetQua = new ET_KetQua(txtMaSV.Text, txtMaMon.Text, diem, txtHocKy.Text);

            // Gọi BUS để khôi phục
            if (busKetQua.KhoiPhucKetQua(etKhoiPhucKetQua))
            {
                MessageBox.Show("Khôi phục KetQua thành công.");

                // Cập nhật lại danh sách
                dgvKetQuaAn.DataSource = busKetQua.LayKetQuaAn();  // Cập nhật danh sách các MonHoc ẩn
            }
            else
            {
                MessageBox.Show("Khôi phục KetQua không thành công.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtMaMon.Clear();
            txtDiem.Clear();
            txtHocKy.Clear();
            txtTimKiemKQ.Clear();
            dgvKetQuaAn.DataSource = busKetQua.LayKetQuaAn();

            txtMaSV.Focus();
        }

        private void btnTimKiemKQ_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtMaMon.Clear();
            txtDiem.Clear();
            txtHocKy.Clear();
            txtTimKiemKQ.Focus();

            string keyword = txtTimKiemKQ.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }

            DataTable result = new DataTable();
            result = busKetQua.TimKiemKetQua(keyword);
            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy");
                dgvKetQuaAn.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiemKQ.Clear();
                dgvKetQuaAn.DataSource = null;
            }
        }

        private void DanhSachKetQuaBiXoa_FormClosing(object sender, FormClosingEventArgs e)
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
