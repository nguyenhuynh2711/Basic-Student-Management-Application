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
    public partial class QuanLyGiaoVien : Form
    {
        public QuanLyGiaoVien()
        {
            InitializeComponent();
        }
        BUS_GiaoVien busGiaoVien = new BUS_GiaoVien();

        BUS_Khoa busKhoa = new BUS_Khoa();
        private void QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachGiaoVien.DataSource = busGiaoVien.layDSGiaoVien();

            // Chuyền dữ liệu vào combobox
            cboMaKhoa.DataSource = busKhoa.layDSKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            ET_GiaoVien etThemGiaoVien = new ET_GiaoVien(txtMaGV.Text, txtTenGV.Text, datNgaySinh.Value, gioiTinh, cboMaKhoa.SelectedValue.ToString());

            if (busGiaoVien.ThemGiaoVien(etThemGiaoVien) == true)
            {
                MessageBox.Show("Thêm  Thành Công");
                dgvDanhSachGiaoVien.DataSource = busGiaoVien.layDSGiaoVien();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            ET_GiaoVien etSuaGiaoVien = new ET_GiaoVien(txtMaGV.Text, txtTenGV.Text, datNgaySinh.Value, gioiTinh, cboMaKhoa.SelectedValue.ToString());

            if (busGiaoVien.SuaGiaoVien(etSuaGiaoVien) == true)
            {
                MessageBox.Show("Sửa Thành Công");
                dgvDanhSachGiaoVien.DataSource = busGiaoVien.layDSGiaoVien();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            ET_GiaoVien etXoaGiaoVien = new ET_GiaoVien(txtMaGV.Text, txtTenGV.Text, datNgaySinh.Value, gioiTinh, cboMaKhoa.SelectedValue.ToString());

            if (busGiaoVien.AnGiaoVien(etXoaGiaoVien) == true)
            {
                MessageBox.Show("Xóa Thành Công");
                dgvDanhSachGiaoVien.DataSource = busGiaoVien.layDSGiaoVien();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Enabled = true;

            txtMaGV.Clear();
            txtTenGV.Clear();

            rdoNam.Checked = true;
            rdoNu.Checked = false;
   
            cboMaKhoa.SelectedIndex = 0;

            txtTimKiemGV.Clear();

            dgvDanhSachGiaoVien.DataSource = busGiaoVien.layDSGiaoVien();

            txtMaGV.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtTenGV.Clear();

            rdoNam.Checked = true;
            rdoNu.Checked = false;
   
            cboMaKhoa.SelectedIndex = 0;

            string keyword = txtTimKiemGV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataTable result = new DataTable();

            result= busGiaoVien.TimKiemGiaoVien(keyword);

            if (result.Rows.Count > 0)
            {
                dgvDanhSachGiaoVien.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy gíao viên nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachGiaoVien.DataSource = null;
            }
        }

        private void QuanLyGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát ?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void dgvDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaGV.Enabled = false;

                int dong = dgvDanhSachGiaoVien.CurrentCell.RowIndex;

                txtMaGV.Text = dgvDanhSachGiaoVien.Rows[dong].Cells[0].Value.ToString();
                txtTenGV.Text = dgvDanhSachGiaoVien.Rows[dong].Cells[1].Value.ToString();
                datNgaySinh.Text = dgvDanhSachGiaoVien.Rows[dong].Cells[2].Value.ToString();

                if (dgvDanhSachGiaoVien.Rows[dong].Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }

                string maKhoa = dgvDanhSachGiaoVien.Rows[dong].Cells[4].Value.ToString() ;
                cboMaKhoa.SelectedValue = maKhoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
