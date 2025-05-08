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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        BUS_SinhVien busSinhVien = new BUS_SinhVien();

        BUS_Khoa busKhoa = new BUS_Khoa();

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachSinhVien.DataSource = busSinhVien.layDSSinhVien();

            // Chuyền dữ liệu vào combobox
            cboMaKhoa.DataSource = busKhoa.layDSKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            ET_SinhVien etThemSinhVien = new ET_SinhVien(txtMaSV.Text, txtTenSV.Text, datNgaySinh.Value, gioiTinh, txtDiaChi.Text, cboMaKhoa.SelectedValue.ToString());

            if (busSinhVien.ThemSinhVien(etThemSinhVien) == true)
            {
                MessageBox.Show("Thêm Sinh Viên Thành Công");
                dgvDanhSachSinhVien.DataSource = busSinhVien.layDSSinhVien();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
        }

        private void dgvDanhSachSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDanhSachSinhVien.CurrentCell.RowIndex;

                txtMaSV.Text = dgvDanhSachSinhVien.Rows[dong].Cells[0].Value.ToString();

                txtMaSV.Enabled = false;

                txtTenSV.Text = dgvDanhSachSinhVien.Rows[dong].Cells[1].Value.ToString();
                datNgaySinh.Text = dgvDanhSachSinhVien.Rows[dong].Cells[2].Value.ToString();

                if (dgvDanhSachSinhVien.Rows[dong].Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }

                txtDiaChi.Text = dgvDanhSachSinhVien.Rows[dong].Cells[4].Value.ToString();

                string tenKhoa = dgvDanhSachSinhVien.Rows[dong].Cells[5].Value.ToString();
                cboMaKhoa.SelectedValue = tenKhoa;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            ET_SinhVien etSuaSV = new ET_SinhVien(txtMaSV.Text, txtTenSV.Text, datNgaySinh.Value, gioiTinh, txtDiaChi.Text, cboMaKhoa.SelectedValue.ToString());

            if(busSinhVien.SuaSinhVien(etSuaSV) == true)
            {
                MessageBox.Show("Sửa Thành Công");
                dgvDanhSachSinhVien.DataSource = busSinhVien.layDSSinhVien();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công");
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            //string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            //ET_SinhVien etXoaSV = new ET_SinhVien(txtMaSV.Text, txtTenSV.Text, datNgaySinh.Value, gioiTinh, txtDiaChi.Text, cboMaKhoa.SelectedValue.ToString());

            //if (busSinhVien.XoaSinhVIen(etXoaSV) == true)
            //{
            //    MessageBox.Show("Xóa Thành Công");
            //    dgvDanhSachSinhVien.DataSource = busSinhVien.layDSSinhVien();
            //}
            //else
            //{
            //    MessageBox.Show("Xóa Không Thành Công");
            //}

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            ET_SinhVien etAnSV = new ET_SinhVien(txtMaSV.Text, txtTenSV.Text, datNgaySinh.Value, gioiTinh, txtDiaChi.Text, cboMaKhoa.SelectedValue.ToString());

            if (busSinhVien.AnSinhVien(etAnSV) == true)
            {
                MessageBox.Show("Xóa Thành Công");
                dgvDanhSachSinhVien.DataSource = busSinhVien.layDSSinhVien();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtTenSV.Clear();

            rdoNam.Checked = true;
            rdoNu.Checked = false;

            txtDiaChi.Clear();
            cboMaKhoa.SelectedIndex = 0;

            string keyword = txtTimKiemSV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập vào thanh tìm kiếm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable result = new DataTable();

            result = busSinhVien.TimKiemSinhVien(keyword);

            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvDanhSachSinhVien.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvDanhSachSinhVien.DataSource = null;
            }
        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtMaSV.Enabled = true;
            txtTenSV.Clear();

            rdoNam.Checked = true;
            rdoNu.Checked = false;

            txtDiaChi.Clear();
            cboMaKhoa.SelectedIndex = 0;

            txtTimKiemSV.Clear();

            dgvDanhSachSinhVien.DataSource = busSinhVien.layDSSinhVien();

            txtMaSV.Focus();
        }

        private void QuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát ?", "Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
