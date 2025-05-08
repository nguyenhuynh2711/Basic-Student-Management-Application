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
    public partial class DanhSachGiaoVienBiXoa : Form
    {
        public DanhSachGiaoVienBiXoa()
        {
            InitializeComponent();
        }
        BUS_GiaoVien busGiaoVien = new BUS_GiaoVien();

        private void DanhSachGiaoVienBiXoa_Load(object sender, EventArgs e)
        {
            dgvGiaoVien.DataSource = busGiaoVien.LayGiaoVienAn();
        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvGiaoVien.CurrentCell.RowIndex;

                txtMaGV.Text = dgvGiaoVien.Rows[dong].Cells[0].Value.ToString();

                txtMaGV.Enabled = false;

                txtHoTen.Text = dgvGiaoVien.Rows[dong].Cells[1].Value.ToString();
                datNgaySinh.Text = dgvGiaoVien.Rows[dong].Cells[2].Value.ToString();

                if (dgvGiaoVien.Rows[dong].Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }

               

                txtMaKhoa.Text = dgvGiaoVien.Rows[dong].Cells[4].Value.ToString();

            }
            catch (Exception ex) { throw ex; }
        }

        private void btnKhoiPhucGV_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            ET_GiaoVien etKhoiPhucGV = new ET_GiaoVien(txtMaGV.Text, txtHoTen.Text, datNgaySinh.Value, gioiTinh,  txtMaKhoa.Text);


            if (busGiaoVien.KhoiPhucGiaoVien(etKhoiPhucGV))
            {
                MessageBox.Show("Khôi phục Giáo Viên thành công.");

                dgvGiaoVien.DataSource = busGiaoVien.LayGiaoVienAn();
            }
            else
            {
                MessageBox.Show("Khôi phục Giáo Viên không thành công.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
           
            txtMaKhoa.Clear();

            dgvGiaoVien.DataSource = busGiaoVien.LayGiaoVienAn();
            txtMaGV.Focus();
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
         
            txtMaKhoa.Clear();

            string keyword = txtTimKiemGV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô tìm kiếm");
                return;
            }

            DataTable result = new DataTable();
            result = busGiaoVien.TimKiemGiaoVien(keyword);

            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy");
                dgvGiaoVien.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                dgvGiaoVien.DataSource = null;
            }
        }

        private void DanhSachGiaoVienBiXoa_FormClosing(object sender, FormClosingEventArgs e)
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
