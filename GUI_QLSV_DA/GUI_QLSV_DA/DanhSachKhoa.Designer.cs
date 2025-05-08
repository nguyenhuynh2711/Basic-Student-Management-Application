namespace GUI_QLSV_DA
{
    partial class DanhSachKhoa
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
            this.dgvDanhSachKhoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachKhoa
            // 
            this.dgvDanhSachKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachKhoa.Location = new System.Drawing.Point(0, 96);
            this.dgvDanhSachKhoa.Name = "dgvDanhSachKhoa";
            this.dgvDanhSachKhoa.Size = new System.Drawing.Size(800, 354);
            this.dgvDanhSachKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH TẤT CẢ KHOA";
            // 
            // DanhSachKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachKhoa);
            this.Name = "DanhSachKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachKhoa";
            this.Load += new System.EventHandler(this.DanhSachKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachKhoa;
        private System.Windows.Forms.Label label1;
    }
}