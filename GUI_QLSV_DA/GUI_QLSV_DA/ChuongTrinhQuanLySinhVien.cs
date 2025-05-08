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

namespace GUI_QLSV_DA
{
    public partial class ChuongTrinhQuanLySinhVien : Form
    {
        public ChuongTrinhQuanLySinhVien()
        {
            InitializeComponent();

            // Tắt menu chức năng
            chứcNăngToolStripMenuItem.Enabled = true;
        }

        

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinKhoa ttKhoa = new ThongTinKhoa();
            ttKhoa.MdiParent = this;
            ttKhoa.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien qlSinhVien = new QuanLySinhVien();
            qlSinhVien.MdiParent = this;
            qlSinhVien.Show();
        }

        private void ChuongTrinhQuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát ?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị form đăng nhập
            TrangDangNhap trangDangNhap = new TrangDangNhap();

            // Kiểm tra
            if (trangDangNhap.ShowDialog() == DialogResult.OK)
            {
                chứcNăngToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xử lý đăng xuất
            chứcNăngToolStripMenuItem.Enabled = false;

            MessageBox.Show("Bạn đã đăng xuất người quản lý !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien dsSinhVien = new DanhSachSinhVien();
            dsSinhVien.MdiParent = this;
            dsSinhVien.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhoa dsKhoa = new DanhSachKhoa();
            dsKhoa.MdiParent = this;
            dsKhoa.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc qlMonHoc = new QuanLyMonHoc();
            qlMonHoc.MdiParent = this;  
            qlMonHoc.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachMonHoc dsMonHoc = new DanhSachMonHoc();
            dsMonHoc.MdiParent = this;
            dsMonHoc.Show();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVien dsGiaoVien = new DanhSachGiaoVien();
            dsGiaoVien.MdiParent = this;
            dsGiaoVien.Show();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKetQua dsKetQua = new DanhSachKetQua();
            dsKetQua.MdiParent = this;
            dsKetQua.Show();
        }

        private void quảnLýKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKetQua qlKetQua = new QuanLyKetQua();
            qlKetQua.MdiParent= this;
            qlKetQua.Show();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyGiaoVien qlGiaoVien = new QuanLyGiaoVien();
            qlGiaoVien.MdiParent =this;
            qlGiaoVien.Show();
        }

        private void danhSáchKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InDanhSachKhoa inDanhSachKhoa = new InDanhSachKhoa();
            inDanhSachKhoa.MdiParent = this;
            inDanhSachKhoa.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InDanhSachSinhVien inDanhSachSinhVien = new InDanhSachSinhVien();
            inDanhSachSinhVien.MdiParent = this;
            inDanhSachSinhVien.Show() ;
        }

        private void danhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InDanhSachMonHoc inDanhSachMonHoc = new InDanhSachMonHoc(); 
            inDanhSachMonHoc.MdiParent = this;
            inDanhSachMonHoc.Show();
        }

        private void danhSáchKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InDanhSachKetQua inDanhSachKetQua = new InDanhSachKetQua();
            inDanhSachKetQua.MdiParent = this;
            inDanhSachKetQua.Show();
        }

        private void danhSáchGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InDanhSachGiaoVien inDanhSachGiaoVien = new InDanhSachGiaoVien();
            inDanhSachGiaoVien.MdiParent = this;
            inDanhSachGiaoVien.Show();
        }

        private void inBảngĐiểmCho1SVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBangDiem1SV inBangDiem1SV = new InBangDiem1SV();
            inBangDiem1SV.MdiParent = this;
            inBangDiem1SV.Show();
        }

        private void danhSáchKhoaBịXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhoaBiXoa dsKhoaXoa = new DanhSachKhoaBiXoa();
            dsKhoaXoa.MdiParent = this;
            dsKhoaXoa.Show();
        }

        private void danhSáchSinhViênBịXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSinhVienBiXoa dsSinhVienXoa = new DanhSachSinhVienBiXoa();
            dsSinhVienXoa.MdiParent = this;
            dsSinhVienXoa.Show();
        }

        private void danhSáchMônHọcBịXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachMonHocBiCoa dsMonHocXoa = new DanhSachMonHocBiCoa();
            dsMonHocXoa.MdiParent = this;
            dsMonHocXoa.Show();
        }

        private void danhSáchKếtQuảBịXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKetQuaBiXoa dsKetQuaXoa = new DanhSachKetQuaBiXoa();
            dsKetQuaXoa.MdiParent = this;
            dsKetQuaXoa.Show();
        }

        private void danhSáchGiáoViênBịXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVienBiXoa dsGiaoVienXoa = new DanhSachGiaoVienBiXoa();
            dsGiaoVienXoa.MdiParent = this;
            dsGiaoVienXoa.Show();
        }

        private void inDanhSáchSinhViênTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InSinhVienThuocKhoa inSinhVienThuocKhoa = new InSinhVienThuocKhoa();
            inSinhVienThuocKhoa.MdiParent = this;
            inSinhVienThuocKhoa.Show(); 
        }
    }
}
