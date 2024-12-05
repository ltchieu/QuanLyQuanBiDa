namespace QL_Bida
{
    partial class frmLichSu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_DSHD = new System.Windows.Forms.DataGridView();
            this.dtp_ngayBD = new System.Windows.Forms.DateTimePicker();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_locTheoKH = new System.Windows.Forms.RadioButton();
            this.rdb_locTheoNV = new System.Windows.Forms.RadioButton();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.ck_locTheoNgay = new System.Windows.Forms.CheckBox();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_XemCT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_DSHD
            // 
            this.dtgv_DSHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DSHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.tenkh,
            this.sdt,
            this.ngayLap,
            this.giamgia,
            this.ngayDat,
            this.tenNV});
            this.dtgv_DSHD.Location = new System.Drawing.Point(3, 328);
            this.dtgv_DSHD.Name = "dtgv_DSHD";
            this.dtgv_DSHD.ReadOnly = true;
            this.dtgv_DSHD.RowHeadersVisible = false;
            this.dtgv_DSHD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgv_DSHD.RowTemplate.Height = 24;
            this.dtgv_DSHD.Size = new System.Drawing.Size(1495, 520);
            this.dtgv_DSHD.TabIndex = 0;
            this.dtgv_DSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DSHD_CellClick);
            // 
            // dtp_ngayBD
            // 
            this.dtp_ngayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngayBD.CustomFormat = "dd-MM-yyyy";
            this.dtp_ngayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayBD.Location = new System.Drawing.Point(250, 106);
            this.dtp_ngayBD.Name = "dtp_ngayBD";
            this.dtp_ngayBD.Size = new System.Drawing.Size(234, 30);
            this.dtp_ngayBD.TabIndex = 1;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Loc.BackColor = System.Drawing.Color.Khaki;
            this.btn_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loc.Location = new System.Drawing.Point(167, 283);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(122, 39);
            this.btn_Loc.TabIndex = 2;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // dtp_NgayKT
            // 
            this.dtp_NgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayKT.CustomFormat = "dd-MM-yyyy";
            this.dtp_NgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayKT.Location = new System.Drawing.Point(250, 176);
            this.dtp_NgayKT.Name = "dtp_NgayKT";
            this.dtp_NgayKT.Size = new System.Drawing.Size(234, 30);
            this.dtp_NgayKT.TabIndex = 4;
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtKH.Location = new System.Drawing.Point(945, 108);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(266, 30);
            this.txt_sdtKH.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "SDT khách hàng:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(833, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhân viên:";
            // 
            // rdb_locTheoKH
            // 
            this.rdb_locTheoKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_locTheoKH.AutoSize = true;
            this.rdb_locTheoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_locTheoKH.Location = new System.Drawing.Point(838, 49);
            this.rdb_locTheoKH.Name = "rdb_locTheoKH";
            this.rdb_locTheoKH.Size = new System.Drawing.Size(167, 22);
            this.rdb_locTheoKH.TabIndex = 12;
            this.rdb_locTheoKH.TabStop = true;
            this.rdb_locTheoKH.Text = "Lọc theo khách hàng";
            this.rdb_locTheoKH.UseVisualStyleBackColor = true;
            this.rdb_locTheoKH.CheckedChanged += new System.EventHandler(this.rdb_locTheoKH_CheckedChanged);
            // 
            // rdb_locTheoNV
            // 
            this.rdb_locTheoNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_locTheoNV.AutoSize = true;
            this.rdb_locTheoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_locTheoNV.Location = new System.Drawing.Point(1114, 49);
            this.rdb_locTheoNV.Name = "rdb_locTheoNV";
            this.rdb_locTheoNV.Size = new System.Drawing.Size(153, 22);
            this.rdb_locTheoNV.TabIndex = 13;
            this.rdb_locTheoNV.TabStop = true;
            this.rdb_locTheoNV.Text = "Lọc theo nhân viên";
            this.rdb_locTheoNV.UseVisualStyleBackColor = true;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNV.Location = new System.Drawing.Point(945, 181);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(266, 30);
            this.txt_maNV.TabIndex = 14;
            // 
            // ck_locTheoNgay
            // 
            this.ck_locTheoNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ck_locTheoNgay.AutoSize = true;
            this.ck_locTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_locTheoNgay.Location = new System.Drawing.Point(264, 49);
            this.ck_locTheoNgay.Name = "ck_locTheoNgay";
            this.ck_locTheoNgay.Size = new System.Drawing.Size(150, 24);
            this.ck_locTheoNgay.TabIndex = 15;
            this.ck_locTheoNgay.Text = "Lọc theo ngày ?";
            this.ck_locTheoNgay.UseVisualStyleBackColor = true;
            // 
            // mahd
            // 
            this.mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahd.DataPropertyName = "MaHD";
            this.mahd.FillWeight = 80F;
            this.mahd.HeaderText = "Mã HD";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // tenkh
            // 
            this.tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkh.DataPropertyName = "TenKH";
            this.tenkh.FillWeight = 110F;
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // ngayLap
            // 
            this.ngayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayLap.DataPropertyName = "NgayLap";
            this.ngayLap.HeaderText = "Ngày tạo HD";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.ReadOnly = true;
            // 
            // giamgia
            // 
            this.giamgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giamgia.DataPropertyName = "GIAMGIA";
            this.giamgia.FillWeight = 50F;
            this.giamgia.HeaderText = "Phần trăm KM";
            this.giamgia.MinimumWidth = 6;
            this.giamgia.Name = "giamgia";
            this.giamgia.ReadOnly = true;
            // 
            // ngayDat
            // 
            this.ngayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayDat.DataPropertyName = "NgayDat";
            this.ngayDat.FillWeight = 70F;
            this.ngayDat.HeaderText = "Ngày đặt bàn";
            this.ngayDat.MinimumWidth = 6;
            this.ngayDat.Name = "ngayDat";
            this.ngayDat.ReadOnly = true;
            // 
            // tenNV
            // 
            this.tenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNV.DataPropertyName = "TENNV";
            this.tenNV.HeaderText = "Tên Nhân viên";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XemCT.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_XemCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemCT.Location = new System.Drawing.Point(350, 283);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(152, 39);
            this.btn_XemCT.TabIndex = 16;
            this.btn_XemCT.Text = "Xem chi tiết";
            this.btn_XemCT.UseVisualStyleBackColor = false;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1587, 848);
            this.Controls.Add(this.btn_XemCT);
            this.Controls.Add(this.ck_locTheoNgay);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.rdb_locTheoNV);
            this.Controls.Add(this.rdb_locTheoKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sdtKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_NgayKT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.dtp_ngayBD);
            this.Controls.Add(this.dtgv_DSHD);
            this.Name = "frmLichSu";
            this.Text = "frmLichSu";
            this.Load += new System.EventHandler(this.frmLichSu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLichSu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_DSHD;
        private System.Windows.Forms.DateTimePicker dtp_ngayBD;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_NgayKT;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_locTheoKH;
        private System.Windows.Forms.RadioButton rdb_locTheoNV;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.CheckBox ck_locTheoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.Button btn_XemCT;
    }
}