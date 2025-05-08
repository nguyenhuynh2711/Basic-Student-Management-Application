namespace GUI_QLSV_DA
{
    partial class DanhSachKetQuaBiXoa
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
            this.btnTimKiemKQ = new System.Windows.Forms.Button();
            this.txtTimKiemKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnKhoiPhucKQ = new System.Windows.Forms.Button();
            this.dgvKetQuaAn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(569, 31);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(72, 32);
            this.btnLamMoi.TabIndex = 35;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemKQ);
            this.groupBox1.Controls.Add(this.txtTimKiemKQ);
            this.groupBox1.Location = new System.Drawing.Point(276, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(365, 82);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnTimKiemKQ
            // 
            this.btnTimKiemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKQ.Location = new System.Drawing.Point(293, 42);
            this.btnTimKiemKQ.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemKQ.Name = "btnTimKiemKQ";
            this.btnTimKiemKQ.Size = new System.Drawing.Size(68, 32);
            this.btnTimKiemKQ.TabIndex = 1;
            this.btnTimKiemKQ.Text = "Tìm Kiếm";
            this.btnTimKiemKQ.UseVisualStyleBackColor = true;
            this.btnTimKiemKQ.Click += new System.EventHandler(this.btnTimKiemKQ_Click);
            // 
            // txtTimKiemKQ
            // 
            this.txtTimKiemKQ.Location = new System.Drawing.Point(5, 18);
            this.txtTimKiemKQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemKQ.Name = "txtTimKiemKQ";
            this.txtTimKiemKQ.Size = new System.Drawing.Size(356, 20);
            this.txtTimKiemKQ.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Học Kỳ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Điểm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Môn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã SV :";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(92, 102);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(168, 20);
            this.txtDiem.TabIndex = 29;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(381, 8);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(261, 20);
            this.txtHocKy.TabIndex = 28;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(92, 52);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(168, 20);
            this.txtMaMon.TabIndex = 27;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(92, 8);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(168, 20);
            this.txtMaSV.TabIndex = 26;
            // 
            // btnKhoiPhucKQ
            // 
            this.btnKhoiPhucKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhucKQ.Location = new System.Drawing.Point(473, 31);
            this.btnKhoiPhucKQ.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoiPhucKQ.Name = "btnKhoiPhucKQ";
            this.btnKhoiPhucKQ.Size = new System.Drawing.Size(86, 30);
            this.btnKhoiPhucKQ.TabIndex = 25;
            this.btnKhoiPhucKQ.Text = "Khôi Phục";
            this.btnKhoiPhucKQ.UseVisualStyleBackColor = true;
            this.btnKhoiPhucKQ.Click += new System.EventHandler(this.btnKhoiPhucKQ_Click);
            // 
            // dgvKetQuaAn
            // 
            this.dgvKetQuaAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKetQuaAn.Location = new System.Drawing.Point(0, 190);
            this.dgvKetQuaAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKetQuaAn.Name = "dgvKetQuaAn";
            this.dgvKetQuaAn.RowHeadersWidth = 51;
            this.dgvKetQuaAn.RowTemplate.Height = 24;
            this.dgvKetQuaAn.Size = new System.Drawing.Size(800, 260);
            this.dgvKetQuaAn.TabIndex = 24;
            this.dgvKetQuaAn.Click += new System.EventHandler(this.dgvKetQuaAn_Click);
            // 
            // DanhSachKetQuaBiXoa
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
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnKhoiPhucKQ);
            this.Controls.Add(this.dgvKetQuaAn);
            this.Name = "DanhSachKetQuaBiXoa";
            this.Text = "DanhSachKetQuaBiXoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachKetQuaBiXoa_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachKetQuaBiXoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiemKQ;
        private System.Windows.Forms.TextBox txtTimKiemKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnKhoiPhucKQ;
        private System.Windows.Forms.DataGridView dgvKetQuaAn;
    }
}