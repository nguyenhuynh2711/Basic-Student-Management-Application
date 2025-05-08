namespace GUI_QLSV_DA
{
    partial class DanhSachKhoaBiXoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKhoaAn = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhucKhoa = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtDiaChiKhoa = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiemKhoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhoaAn
            // 
            this.dgvKhoaAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoaAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoaAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhoaAn.Location = new System.Drawing.Point(0, 242);
            this.dgvKhoaAn.Name = "dgvKhoaAn";
            this.dgvKhoaAn.RowHeadersWidth = 51;
            this.dgvKhoaAn.RowTemplate.Height = 24;
            this.dgvKhoaAn.Size = new System.Drawing.Size(887, 260);
            this.dgvKhoaAn.TabIndex = 0;
            this.dgvKhoaAn.Click += new System.EventHandler(this.dgvKhoaAn_Click);
            // 
            // btnKhoiPhucKhoa
            // 
            this.btnKhoiPhucKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhucKhoa.Location = new System.Drawing.Point(631, 66);
            this.btnKhoiPhucKhoa.Name = "btnKhoiPhucKhoa";
            this.btnKhoiPhucKhoa.Size = new System.Drawing.Size(114, 37);
            this.btnKhoiPhucKhoa.TabIndex = 1;
            this.btnKhoiPhucKhoa.Text = "Khôi Phục";
            this.btnKhoiPhucKhoa.UseVisualStyleBackColor = true;
            this.btnKhoiPhucKhoa.Click += new System.EventHandler(this.btnKhoiPhucKhoa_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(122, 38);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(222, 22);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(122, 92);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(222, 22);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // txtDiaChiKhoa
            // 
            this.txtDiaChiKhoa.Location = new System.Drawing.Point(508, 38);
            this.txtDiaChiKhoa.Name = "txtDiaChiKhoa";
            this.txtDiaChiKhoa.Size = new System.Drawing.Size(347, 22);
            this.txtDiaChiKhoa.TabIndex = 4;
            // 
            // txtSoDienThoaiKhoa
            // 
            this.txtSoDienThoaiKhoa.Location = new System.Drawing.Point(122, 154);
            this.txtSoDienThoaiKhoa.Name = "txtSoDienThoaiKhoa";
            this.txtSoDienThoaiKhoa.Size = new System.Drawing.Size(222, 22);
            this.txtSoDienThoaiKhoa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Khoa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Khoa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "SĐT Khoa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa Chỉ Khoa :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemKhoa);
            this.groupBox1.Controls.Add(this.txtTimKiemKhoa);
            this.groupBox1.Location = new System.Drawing.Point(368, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtTimKiemKhoa
            // 
            this.txtTimKiemKhoa.Location = new System.Drawing.Point(7, 22);
            this.txtTimKiemKhoa.Name = "txtTimKiemKhoa";
            this.txtTimKiemKhoa.Size = new System.Drawing.Size(474, 22);
            this.txtTimKiemKhoa.TabIndex = 0;
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(391, 52);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(90, 40);
            this.btnTimKiemKhoa.TabIndex = 1;
            this.btnTimKiemKhoa.Text = "Tìm Kiếm";
            this.btnTimKiemKhoa.UseVisualStyleBackColor = true;
            this.btnTimKiemKhoa.Click += new System.EventHandler(this.btnTimKiemKhoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(759, 66);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 39);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // DanhSachKhoaBiXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 502);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoDienThoaiKhoa);
            this.Controls.Add(this.txtDiaChiKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.btnKhoiPhucKhoa);
            this.Controls.Add(this.dgvKhoaAn);
            this.Name = "DanhSachKhoaBiXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachKhoaBiXoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachKhoaBiXoa_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachKhoaBiXoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoaAn;
        private System.Windows.Forms.Button btnKhoiPhucKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtDiaChiKhoa;
        private System.Windows.Forms.TextBox txtSoDienThoaiKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemKhoa;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}