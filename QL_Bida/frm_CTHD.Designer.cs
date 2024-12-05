namespace QL_Bida
{
    partial class frm_CTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_cthd = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cthd)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_cthd
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_cthd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_cthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.tenkh,
            this.ngaylap,
            this.maBan,
            this.gioBD,
            this.gioKT,
            this.tendv,
            this.sl});
            this.dtgv_cthd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_cthd.Location = new System.Drawing.Point(0, 0);
            this.dtgv_cthd.Name = "dtgv_cthd";
            this.dtgv_cthd.RowHeadersVisible = false;
            this.dtgv_cthd.RowHeadersWidth = 51;
            this.dtgv_cthd.RowTemplate.Height = 24;
            this.dtgv_cthd.Size = new System.Drawing.Size(1273, 186);
            this.dtgv_cthd.TabIndex = 0;
            // 
            // mahd
            // 
            this.mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahd.DataPropertyName = "MaHD";
            this.mahd.HeaderText = "Mã HD";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            // 
            // tenkh
            // 
            this.tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkh.DataPropertyName = "TenKH";
            this.tenkh.FillWeight = 130F;
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            // 
            // ngaylap
            // 
            this.ngaylap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaylap.DataPropertyName = "NgayLap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            // 
            // maBan
            // 
            this.maBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maBan.DataPropertyName = "MABAN";
            this.maBan.HeaderText = "Số bàn";
            this.maBan.MinimumWidth = 6;
            this.maBan.Name = "maBan";
            // 
            // gioBD
            // 
            this.gioBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioBD.DataPropertyName = "GIOBATDAU";
            this.gioBD.HeaderText = "Giờ bắt đầu";
            this.gioBD.MinimumWidth = 6;
            this.gioBD.Name = "gioBD";
            // 
            // gioKT
            // 
            this.gioKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioKT.DataPropertyName = "GIOKETTHUC";
            this.gioKT.HeaderText = "Giờ kết thúc";
            this.gioKT.MinimumWidth = 6;
            this.gioKT.Name = "gioKT";
            // 
            // tendv
            // 
            this.tendv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tendv.DataPropertyName = "TenDV";
            this.tendv.HeaderText = "Tên DV";
            this.tendv.MinimumWidth = 6;
            this.tendv.Name = "tendv";
            // 
            // sl
            // 
            this.sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sl.DataPropertyName = "SoLuong";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            // 
            // frm_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 186);
            this.Controls.Add(this.dtgv_cthd);
            this.Name = "frm_CTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết một hóa đơn";
            this.Load += new System.EventHandler(this.frm_CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_cthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
    }
}