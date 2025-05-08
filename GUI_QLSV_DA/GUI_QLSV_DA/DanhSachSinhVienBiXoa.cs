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
    public partial class DanhSachSinhVienBiXoa : Form
    {
        public DanhSachSinhVienBiXoa()
        {
            InitializeComponent();
        }
        BUS_SinhVien busSinhVien = new BUS_SinhVien();

        private void DanhSachSinhVienBiXoa_Load(object sender, EventArgs e)
        {
            dgvDSSinhVienAn.DataSource = busSinhVien.LaySinhVienAn();
        }

        private void dgvDSSinhVienAn_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDSSinhVienAn.CurrentCell.RowIndex;

                txtMaSV.Text = dgvDSSinhVienAn.Rows[dong].Cells[0].Value.ToString();

                txtMaSV.Enabled = false;

                txtHoTen.Text = dgvDSSinhVienAn.Rows[dong].Cells[1].Value.ToString();
                datNgaySinh.Text = dgvDSSinhVienAn.Rows[dong].Cells[2].Value.ToString();

                if (dgvDSSinhVienAn.Rows[dong].Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }

                txtDiaChi.Text = dgvDSSinhVienAn.Rows[dong].Cells[4].Value.ToString();

                txtMaKhoa.Text = dgvDSSinhVienAn.Rows[dong].Cells[5].Value.ToString();
                
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnKhoiPhucSVAn_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            
            ET_SinhVien etKhoiPhucSV = new ET_SinhVien(txtMaSV.Text, txtHoTen.Text, datNgaySinh.Value, gioiTinh, txtDiaChi.Text, txtMaKhoa.Text);

            
            if (busSinhVien.KhoiPhucSinhVien(etKhoiPhucSV))
            {
                MessageBox.Show("Khôi phục Sinh Viên thành công.");

                dgvDSSinhVienAn.DataSource = busSinhVien.LaySinhVienAn(); 
            }
            else
            {
                MessageBox.Show("Khôi phục Sinh Viên không thành công.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaKhoa.Clear();
            txtMaSV.Focus();
            dgvDSSinhVienAn.DataSource = busSinhVien.LaySinhVienAn();
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaKhoa.Clear();

            string keyword = txtTimKiemSinhVien.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô tìm kiếm");
                return;
            }

            DataTable result = new DataTable();
            result = busSinhVien.TimKiemSinhVien(keyword);

            if(result.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy");
                dgvDSSinhVienAn.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                dgvDSSinhVienAn.DataSource = null;
            }
        }

        private void DanhSachSinhVienBiXoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
