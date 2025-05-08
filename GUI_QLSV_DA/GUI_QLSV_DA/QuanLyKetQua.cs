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
    public partial class QuanLyKetQua : Form
    {
        public QuanLyKetQua()
        {
            InitializeComponent();
        }
        BUS_KetQua busKetQua = new BUS_KetQua();
        BUS_SinhVien busSinhVien = new BUS_SinhVien();
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        private void QuanLyKetQua_Load(object sender, EventArgs e)
        {
            dgvDanhSachKQ.DataSource = busKetQua.layDSKetQua();

            cboMaSV.DataSource = busSinhVien.layDSSinhVien();
            cboMaSV.DisplayMember = "HoTen";
            cboMaSV.ValueMember = "MaSV";

            cboMaMon.DataSource = busMonHoc.layDSMonHoc();
            cboMaMon.DisplayMember = "TenMon";
            cboMaMon.ValueMember = "MaMon";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            decimal Diem = decimal.Parse(txtDiem.Text);

            ET_KetQua etThemKetQua = new ET_KetQua(cboMaSV.SelectedValue.ToString(),cboMaMon.SelectedValue.ToString(), Diem,txtHocKy.Text);

            if (busKetQua.ThemKetQua(etThemKetQua) == true)
            {

                MessageBox.Show("Thêm Thành Công");
                dgvDanhSachKQ.DataSource = busKetQua.layDSKetQua();
            }
            else
            {
                MessageBox.Show("Thêm ko Thành Công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            decimal Diem = decimal.Parse(txtDiem.Text);

            ET_KetQua etXoaKetQua = new ET_KetQua(cboMaSV.SelectedValue.ToString(), cboMaMon.SelectedValue.ToString(), Diem, txtHocKy.Text);

            if (busKetQua.AnKetQua(etXoaKetQua) == true)
            {

                MessageBox.Show("Xoá Thành Công");
                dgvDanhSachKQ.DataSource = busKetQua.layDSKetQua();
            }
            else
            {
                MessageBox.Show("Xoá ko Thành Công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal Diem = decimal.Parse(txtDiem.Text);

            ET_KetQua etSuaKetQua = new ET_KetQua(cboMaSV.SelectedValue.ToString(), cboMaMon.SelectedValue.ToString(), Diem, txtHocKy.Text);

            if (busKetQua.SuaKetQua(etSuaKetQua) == true)
            {

                MessageBox.Show("Sửa Thành Công");
                dgvDanhSachKQ.DataSource = busKetQua.layDSKetQua();
            }
            else
            {
                MessageBox.Show("Sửa ko Thành Công");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaMon.Enabled = true;
            cboMaSV.Enabled = true;
            cboMaSV.SelectedIndex = 0;
            cboMaMon.SelectedIndex = 0;
            txtDiem.Clear();
            txtHocKy.Clear();


            txtTimKiemKQ.Clear();

            cboMaSV.Focus();
            dgvDanhSachKQ.DataSource = busKetQua.layDSKetQua();
        }

        private void dgvDanhSachKQ_Click(object sender, EventArgs e)
        {
            cboMaMon.Enabled = false;
            cboMaSV.Enabled = false;

            int dong = dgvDanhSachKQ.CurrentCell.RowIndex;

            string maSV = dgvDanhSachKQ.Rows[dong].Cells[0].Value.ToString();
            cboMaSV.SelectedValue = maSV;

            string maMon = dgvDanhSachKQ.Rows[dong].Cells[1].Value.ToString();
            cboMaMon.SelectedValue = maMon;

            txtDiem.Text = dgvDanhSachKQ.Rows[dong].Cells[2].Value.ToString();
            txtHocKy.Text = dgvDanhSachKQ.Rows[dong].Cells[3].Value.ToString();
        }

        private void QuanLyKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát ?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnTimKiemKQ_Click(object sender, EventArgs e)
        {
            cboMaSV.SelectedIndex = 0;
            cboMaMon.SelectedIndex = 0;
            txtDiem.Clear();
            txtHocKy.Clear();


            string keyword = txtTimKiemKQ.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataTable result = busKetQua.TimKiemKetQua(keyword);

            if (result.Rows.Count > 0)
            {
                dgvDanhSachKQ.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachKQ.DataSource = null;
            }
        }

       
    }
}
