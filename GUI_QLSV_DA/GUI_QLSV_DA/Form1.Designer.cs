namespace GUI_QLSV_DA
{
    partial class ThongTinKhoa
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
            this.dgvDSKhoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtDiaChiKhoa = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiKhoa = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnLamMoiKhoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimKiemKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSKhoa
            // 
            this.dgvDSKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSKhoa.Location = new System.Drawing.Point(0, 276);
            this.dgvDSKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSKhoa.Name = "dgvDSKhoa";
            this.dgvDSKhoa.RowHeadersWidth = 51;
            this.dgvDSKhoa.Size = new System.Drawing.Size(1067, 278);
            this.dgvDSKhoa.TabIndex = 0;
            this.dgvDSKhoa.Click += new System.EventHandler(this.dgvDSKhoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(361, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ KHOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khoa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khoa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Điện Thoại Khoa :";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(245, 73);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(284, 22);
            this.txtMaKhoa.TabIndex = 6;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(245, 127);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(284, 22);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // txtDiaChiKhoa
            // 
            this.txtDiaChiKhoa.Location = new System.Drawing.Point(245, 178);
            this.txtDiaChiKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChiKhoa.Name = "txtDiaChiKhoa";
            this.txtDiaChiKhoa.Size = new System.Drawing.Size(284, 22);
            this.txtDiaChiKhoa.TabIndex = 8;
            // 
            // txtSoDienThoaiKhoa
            // 
            this.txtSoDienThoaiKhoa.Location = new System.Drawing.Point(245, 229);
            this.txtSoDienThoaiKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoDienThoaiKhoa.Name = "txtSoDienThoaiKhoa";
            this.txtSoDienThoaiKhoa.Size = new System.Drawing.Size(284, 22);
            this.txtSoDienThoaiKhoa.TabIndex = 9;
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(565, 70);
            this.btnThemKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(100, 78);
            this.btnThemKhoa.TabIndex = 10;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(696, 70);
            this.btnXoaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(100, 78);
            this.btnXoaKhoa.TabIndex = 11;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(816, 70);
            this.btnSuaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(100, 78);
            this.btnSuaKhoa.TabIndex = 12;
            this.btnSuaKhoa.Text = "Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnLamMoiKhoa
            // 
            this.btnLamMoiKhoa.Location = new System.Drawing.Point(943, 74);
            this.btnLamMoiKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoiKhoa.Name = "btnLamMoiKhoa";
            this.btnLamMoiKhoa.Size = new System.Drawing.Size(100, 74);
            this.btnLamMoiKhoa.TabIndex = 13;
            this.btnLamMoiKhoa.Text = "Làm mới";
            this.btnLamMoiKhoa.UseVisualStyleBackColor = true;
            this.btnLamMoiKhoa.Click += new System.EventHandler(this.btnLamMoiKhoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTimKiemKhoa);
            this.groupBox1.Location = new System.Drawing.Point(565, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(485, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(377, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiemKhoa
            // 
            this.txtTimKiemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemKhoa.Location = new System.Drawing.Point(9, 23);
            this.txtTimKiemKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemKhoa.Name = "txtTimKiemKhoa";
            this.txtTimKiemKhoa.Size = new System.Drawing.Size(467, 26);
            this.txtTimKiemKhoa.TabIndex = 0;
            // 
            // ThongTinKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLamMoiKhoa);
            this.Controls.Add(this.btnSuaKhoa);
            this.Controls.Add(this.btnXoaKhoa);
            this.Controls.Add(this.btnThemKhoa);
            this.Controls.Add(this.txtSoDienThoaiKhoa);
            this.Controls.Add(this.txtDiaChiKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSKhoa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongTinKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongTinKhoa_FormClosing);
            this.Load += new System.EventHandler(this.ThongtinKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtDiaChiKhoa;
        private System.Windows.Forms.TextBox txtSoDienThoaiKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnLamMoiKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimKiemKhoa;
    }
}

