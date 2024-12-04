namespace QL_Bida
{
    partial class frmThemKH
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_TenKH = new System.Windows.Forms.TextBox();
			this.txt_MaKH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_DiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_TaoMaKH = new System.Windows.Forms.Button();
			this.btn_ThemKH = new System.Windows.Forms.Button();
			this.txt_SDT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_LoaiKH = new System.Windows.Forms.TextBox();
			this.txt_SoDiemThuong = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.dtgv_dsKH = new System.Windows.Forms.DataGridView();
			this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diemthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_dsKH)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1068, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 25);
			this.label6.TabIndex = 120;
			this.label6.Text = "Nhóm khách:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên khách hàng:";
			// 
			// txt_TenKH
			// 
			this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenKH.Location = new System.Drawing.Point(200, 90);
			this.txt_TenKH.Name = "txt_TenKH";
			this.txt_TenKH.Size = new System.Drawing.Size(237, 30);
			this.txt_TenKH.TabIndex = 1;
			this.txt_TenKH.Leave += new System.EventHandler(this.txt_TenKH_Leave);
			// 
			// txt_MaKH
			// 
			this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MaKH.Location = new System.Drawing.Point(200, 35);
			this.txt_MaKH.Name = "txt_MaKH";
			this.txt_MaKH.ReadOnly = true;
			this.txt_MaKH.Size = new System.Drawing.Size(237, 30);
			this.txt_MaKH.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã khách hàng:";
			// 
			// txt_DiaChi
			// 
			this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_DiaChi.Location = new System.Drawing.Point(653, 35);
			this.txt_DiaChi.Name = "txt_DiaChi";
			this.txt_DiaChi.Size = new System.Drawing.Size(362, 30);
			this.txt_DiaChi.TabIndex = 5;
			this.txt_DiaChi.Leave += new System.EventHandler(this.txt_TenKH_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(542, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ:";
			// 
			// btn_TaoMaKH
			// 
			this.btn_TaoMaKH.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btn_TaoMaKH.FlatAppearance.BorderSize = 0;
			this.btn_TaoMaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_TaoMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TaoMaKH.Location = new System.Drawing.Point(97, 181);
			this.btn_TaoMaKH.Name = "btn_TaoMaKH";
			this.btn_TaoMaKH.Size = new System.Drawing.Size(198, 43);
			this.btn_TaoMaKH.TabIndex = 113;
			this.btn_TaoMaKH.Text = "Tạo mã KH";
			this.btn_TaoMaKH.UseVisualStyleBackColor = false;
			this.btn_TaoMaKH.Click += new System.EventHandler(this.btn_TaoMaKH_Click);
			// 
			// btn_ThemKH
			// 
			this.btn_ThemKH.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btn_ThemKH.FlatAppearance.BorderSize = 0;
			this.btn_ThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_ThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThemKH.Location = new System.Drawing.Point(853, 181);
			this.btn_ThemKH.Name = "btn_ThemKH";
			this.btn_ThemKH.Size = new System.Drawing.Size(137, 43);
			this.btn_ThemKH.TabIndex = 114;
			this.btn_ThemKH.Text = "Thêm";
			this.btn_ThemKH.UseVisualStyleBackColor = false;
			this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
			// 
			// txt_SDT
			// 
			this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_SDT.Location = new System.Drawing.Point(698, 92);
			this.txt_SDT.Name = "txt_SDT";
			this.txt_SDT.Size = new System.Drawing.Size(317, 30);
			this.txt_SDT.TabIndex = 116;
			this.txt_SDT.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged);
			this.txt_SDT.Leave += new System.EventHandler(this.txt_TenKH_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(532, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 25);
			this.label4.TabIndex = 115;
			this.label4.Text = "Số điện thoại:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.txt_LoaiKH);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_SoDiemThuong);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.txt_SDT);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_TenKH);
			this.groupBox1.Controls.Add(this.btn_ThemKH);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btn_TaoMaKH);
			this.groupBox1.Controls.Add(this.txt_MaKH);
			this.groupBox1.Controls.Add(this.txt_DiaChi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(30, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1438, 258);
			this.groupBox1.TabIndex = 117;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin khách hàng";
			// 
			// txt_LoaiKH
			// 
			this.txt_LoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LoaiKH.Location = new System.Drawing.Point(1211, 35);
			this.txt_LoaiKH.Name = "txt_LoaiKH";
			this.txt_LoaiKH.ReadOnly = true;
			this.txt_LoaiKH.Size = new System.Drawing.Size(188, 30);
			this.txt_LoaiKH.TabIndex = 121;
			this.txt_LoaiKH.Text = "Thành viên";
			// 
			// txt_SoDiemThuong
			// 
			this.txt_SoDiemThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_SoDiemThuong.Location = new System.Drawing.Point(1211, 90);
			this.txt_SoDiemThuong.Name = "txt_SoDiemThuong";
			this.txt_SoDiemThuong.ReadOnly = true;
			this.txt_SoDiemThuong.Size = new System.Drawing.Size(188, 30);
			this.txt_SoDiemThuong.TabIndex = 119;
			this.txt_SoDiemThuong.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1066, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 25);
			this.label5.TabIndex = 118;
			this.label5.Text = "Điểm thưởng:";
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnSua.FlatAppearance.BorderSize = 0;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(1095, 181);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(137, 43);
			this.btnSua.TabIndex = 117;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// dtgv_dsKH
			// 
			this.dtgv_dsKH.Anchor = System.Windows.Forms.AnchorStyles.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv_dsKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgv_dsKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv_dsKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenKh,
            this.sdt,
            this.diemthuong,
            this.LoaiKhach,
            this.diaChi});
			this.dtgv_dsKH.Location = new System.Drawing.Point(-1, 309);
			this.dtgv_dsKH.Name = "dtgv_dsKH";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv_dsKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgv_dsKH.RowHeadersVisible = false;
			this.dtgv_dsKH.RowHeadersWidth = 51;
			this.dtgv_dsKH.RowTemplate.Height = 24;
			this.dtgv_dsKH.Size = new System.Drawing.Size(1501, 428);
			this.dtgv_dsKH.TabIndex = 118;
			this.dtgv_dsKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsKH_CellClick);
			// 
			// makh
			// 
			this.makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.makh.DataPropertyName = "MaKH";
			this.makh.FillWeight = 70F;
			this.makh.HeaderText = "Mã KH";
			this.makh.MinimumWidth = 6;
			this.makh.Name = "makh";
			// 
			// tenKh
			// 
			this.tenKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tenKh.DataPropertyName = "TenKH";
			this.tenKh.FillWeight = 150F;
			this.tenKh.HeaderText = "Họ và tên";
			this.tenKh.MinimumWidth = 6;
			this.tenKh.Name = "tenKh";
			// 
			// sdt
			// 
			this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sdt.DataPropertyName = "SDT";
			this.sdt.HeaderText = "SDT";
			this.sdt.MinimumWidth = 6;
			this.sdt.Name = "sdt";
			// 
			// diemthuong
			// 
			this.diemthuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.diemthuong.DataPropertyName = "SODIEMTHUONG";
			this.diemthuong.FillWeight = 40F;
			this.diemthuong.HeaderText = "Điểm thưởng";
			this.diemthuong.MinimumWidth = 6;
			this.diemthuong.Name = "diemthuong";
			// 
			// LoaiKhach
			// 
			this.LoaiKhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LoaiKhach.DataPropertyName = "TENLOAIKH";
			this.LoaiKhach.FillWeight = 80F;
			this.LoaiKhach.HeaderText = "Nhóm khách hàng";
			this.LoaiKhach.MinimumWidth = 6;
			this.LoaiKhach.Name = "LoaiKhach";
			// 
			// diaChi
			// 
			this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.diaChi.DataPropertyName = "DiaChi";
			this.diaChi.FillWeight = 160F;
			this.diaChi.HeaderText = "Địa chỉ";
			this.diaChi.MinimumWidth = 6;
			this.diaChi.Name = "diaChi";
			// 
			// frmThemKH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1499, 737);
			this.Controls.Add(this.dtgv_dsKH);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmThemKH";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm Khách Hàng";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmThemKH_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_dsKH)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_TenKH;
		private System.Windows.Forms.TextBox txt_MaKH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_DiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_TaoMaKH;
		private System.Windows.Forms.Button btn_ThemKH;
		private System.Windows.Forms.TextBox txt_SDT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.DataGridView dtgv_dsKH;
		private System.Windows.Forms.TextBox txt_SoDiemThuong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn makh;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKh;
		private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
		private System.Windows.Forms.DataGridViewTextBoxColumn diemthuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKhach;
		private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
		private System.Windows.Forms.TextBox txt_LoaiKH;
		private System.Windows.Forms.Label label6;
	}
}