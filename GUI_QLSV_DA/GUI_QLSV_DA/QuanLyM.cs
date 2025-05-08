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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        BUS_Khoa busKhoa = new BUS_Khoa();
        BUS_MonHoc busMonHoc = new BUS_MonHoc();

        private void QuanLyMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát ?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            dgvDanhSachMH.DataSource = busMonHoc.layDSMonHoc();

            // Chuyền dữ liệu vào combobox
            cboMaKhoa.DataSource = busKhoa.layDSKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soTinChi = int.Parse(txtSoTinChi.Text);

            ET_MonHoc etThemMonHoc = new ET_MonHoc(txtMaMon.Text,txtTenMon.Text,soTinChi,cboMaKhoa.SelectedValue.ToString());

            if (busMonHoc.ThemMonHoc(etThemMonHoc) == true)
            {
                MessageBox.Show("Thêm Thành Công");
                dgvDanhSachMH.DataSource = busMonHoc.layDSMonHoc();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int soTinChi = int.Parse(txtSoTinChi.Text);

            ET_MonHoc etXoaMonHoc = new ET_MonHoc(txtMaMon.Text, txtTenMon.Text,soTinChi, cboMaKhoa.SelectedValue.ToString());

            if (busMonHoc.XoaMonHoc(etXoaMonHoc) == true)
            {
                MessageBox.Show("Xoá Thành Công");
                dgvDanhSachMH.DataSource = busMonHoc.layDSMonHoc();
            }
            else
            {
                MessageBox.Show("Xoá Không Thành Công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int soTinChi = int.Parse(txtSoTinChi.Text);
            ET_MonHoc etSuaMonHoc = new ET_MonHoc(txtMaMon.Text,txtTenMon.Text,soTinChi,cboMaKhoa.SelectedValue.ToString());

            if (busMonHoc.SuaMonHoc(etSuaMonHoc)==true)
            {
                MessageBox.Show("SửaThành Công");
                dgvDanhSachMH.DataSource = busMonHoc.layDSMonHoc();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công");
            }
        }

        private void dgvDanhSachMH_Click(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            int dong = dgvDanhSachMH.CurrentCell.RowIndex;
            txtMaMon.Text = dgvDanhSachMH.Rows[dong].Cells[0].Value.ToString();
            txtTenMon.Text = dgvDanhSachMH.Rows[dong].Cells[1].Value.ToString();
            txtSoTinChi.Text = dgvDanhSachMH.Rows[dong].Cells[2].Value.ToString();

            string maKhoa = dgvDanhSachMH.Rows[dong].Cells[3].Value.ToString();
            cboMaKhoa.SelectedValue = maKhoa;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Enabled = true;
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTinChi.Clear();
            cboMaKhoa.SelectedIndex = 0;

            txtTimKiemMH.Clear();

            txtMaMon.Focus();
            dgvDanhSachMH.DataSource = busMonHoc.layDSMonHoc();
        }

        private void btnTimKiemMH_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtSoTinChi.Clear();
            

            string keyword = txtTimKiemMH.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataTable result = busMonHoc.TimKiemMonHoc(keyword);

            if (result.Rows.Count > 0)
            {
                dgvDanhSachMH.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachMH.DataSource = null;
            }
        }
    }
}
