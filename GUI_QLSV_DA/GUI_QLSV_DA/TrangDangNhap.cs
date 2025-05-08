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
    public partial class TrangDangNhap : Form
    {
        public TrangDangNhap()
        {
            InitializeComponent();
        }

        // Thông tin đăng nhập
        private string tenDangNhapDung = "admin";
        private string matKhauDung = "123";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (tenDangNhap == tenDangNhapDung && matKhau == matKhauDung)
            {
                MessageBox.Show("Đăng nhập quyền quản lý thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

       
    }
}
