namespace GUI_QLSV_DA
{
    partial class DanhSachMonHocBiCoa
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemMH = new System.Windows.Forms.Button();
            this.txtTimKiemMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.btnKhoiPhucMH = new System.Windows.Forms.Button();
            this.dgvMonHocAn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(569, 39);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(72, 32);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemMH);
            this.groupBox1.Controls.Add(this.txtTimKiemMH);
            this.groupBox1.Location = new System.Drawing.Point(276, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(365, 82);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnTimKiemMH
            // 
            this.btnTimKiemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemMH.Location = new System.Drawing.Point(293, 42);
            this.btnTimKiemMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemMH.Name = "btnTimKiemMH";
            this.btnTimKiemMH.Size = new System.Drawing.Size(68, 32);
            this.btnTimKiemMH.TabIndex = 1;
            this.btnTimKiemMH.Text = "Tìm Kiếm";
            this.btnTimKiemMH.UseVisualStyleBackColor = true;
            this.btnTimKiemMH.Click += new System.EventHandler(this.btnTimKiemMH_Click);
            // 
            // txtTimKiemMH
            // 
            this.txtTimKiemMH.Location = new System.Drawing.Point(5, 18);
            this.txtTimKiemMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemMH.Name = "txtTimKiemMH";
            this.txtTimKiemMH.Size = new System.Drawing.Size(356, 20);
            this.txtTimKiemMH.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số Tín Chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Môn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Môn :";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(92, 110);
            this.txtSoTinChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(168, 20);
            this.txtSoTinChi.TabIndex = 17;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(381, 16);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(261, 20);
            this.txtMaKhoa.TabIndex = 16;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(92, 60);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(168, 20);
            this.txtTenMon.TabIndex = 15;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(92, 16);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(168, 20);
            this.txtMaMon.TabIndex = 14;
            // 
            // btnKhoiPhucMH
            // 
            this.btnKhoiPhucMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhucMH.Location = new System.Drawing.Point(473, 39);
            this.btnKhoiPhucMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoiPhucMH.Name = "btnKhoiPhucMH";
            this.btnKhoiPhucMH.Size = new System.Drawing.Size(86, 30);
            this.btnKhoiPhucMH.TabIndex = 13;
            this.btnKhoiPhucMH.Text = "Khôi Phục";
            this.btnKhoiPhucMH.UseVisualStyleBackColor = true;
            this.btnKhoiPhucMH.Click += new System.EventHandler(this.btnKhoiPhucMH_Click);
            // 
            // dgvMonHocAn
            // 
            this.dgvMonHocAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHocAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHocAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMonHocAn.Location = new System.Drawing.Point(0, 190);
            this.dgvMonHocAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMonHocAn.Name = "dgvMonHocAn";
            this.dgvMonHocAn.RowHeadersWidth = 51;
            this.dgvMonHocAn.RowTemplate.Height = 24;
            this.dgvMonHocAn.Size = new System.Drawing.Size(800, 260);
            this.dgvMonHocAn.TabIndex = 12;
            this.dgvMonHocAn.Click += new System.EventHandler(this.dgvMonHocAn_Click);
            // 
            // DanhSachMonHocBiCoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.btnKhoiPhucMH);
            this.Controls.Add(this.dgvMonHocAn);
            this.Name = "DanhSachMonHocBiCoa";
            this.Text = "DanhSachMonHocBiCoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachMonHocBiCoa_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachMonHocBiCoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHocAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiemMH;
        private System.Windows.Forms.TextBox txtTimKiemMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Button btnKhoiPhucMH;
        private System.Windows.Forms.DataGridView dgvMonHocAn;
    }
}