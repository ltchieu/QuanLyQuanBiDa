namespace QL_Bida
{
	partial class frmDatBan
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
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_ngayDat = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_gioDat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmb_LoaiBan = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmb_maBan = new System.Windows.Forms.ComboBox();
			this.btn_DatBan = new System.Windows.Forms.Button();
			this.txt_sdtKH = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.dtgv_dsDatBan = new System.Windows.Forms.DataGridView();
			this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_TimKH = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_dsDatBan)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 24);
			this.label1.TabIndex = 28;
			this.label1.Text = "SDT khách hàng:";
			// 
			// dtp_ngayDat
			// 
			this.dtp_ngayDat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtp_ngayDat.CustomFormat = "yyyy-MM-dd";
			this.dtp_ngayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_ngayDat.Location = new System.Drawing.Point(205, 164);
			this.dtp_ngayDat.Name = "dtp_ngayDat";
			this.dtp_ngayDat.Size = new System.Drawing.Size(235, 30);
			this.dtp_ngayDat.TabIndex = 30;
			this.dtp_ngayDat.ValueChanged += new System.EventHandler(this.dtp_ngayDat_ValueChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 31;
			this.label2.Text = "Ngày đặt:";
			// 
			// txt_gioDat
			// 
			this.txt_gioDat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_gioDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_gioDat.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.txt_gioDat.Location = new System.Drawing.Point(205, 229);
			this.txt_gioDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_gioDat.Name = "txt_gioDat";
			this.txt_gioDat.Size = new System.Drawing.Size(235, 28);
			this.txt_gioDat.TabIndex = 44;
			this.txt_gioDat.Text = "Ví dụ: 20:30";
			this.txt_gioDat.Enter += new System.EventHandler(this.txt_gioDat_Enter);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(95, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 24);
			this.label3.TabIndex = 43;
			this.label3.Text = "Vào lúc:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(87, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 24);
			this.label4.TabIndex = 45;
			this.label4.Text = "Loại bàn:";
			// 
			// cmb_LoaiBan
			// 
			this.cmb_LoaiBan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmb_LoaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_LoaiBan.FormattingEnabled = true;
			this.cmb_LoaiBan.Location = new System.Drawing.Point(205, 292);
			this.cmb_LoaiBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmb_LoaiBan.Name = "cmb_LoaiBan";
			this.cmb_LoaiBan.Size = new System.Drawing.Size(235, 33);
			this.cmb_LoaiBan.TabIndex = 46;
			this.cmb_LoaiBan.SelectedIndexChanged += new System.EventHandler(this.cmb_LoaiBan_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(99, 365);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 24);
			this.label5.TabIndex = 47;
			this.label5.Text = "Số bàn:";
			// 
			// cmb_maBan
			// 
			this.cmb_maBan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmb_maBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_maBan.FormattingEnabled = true;
			this.cmb_maBan.Location = new System.Drawing.Point(205, 360);
			this.cmb_maBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmb_maBan.Name = "cmb_maBan";
			this.cmb_maBan.Size = new System.Drawing.Size(235, 33);
			this.cmb_maBan.TabIndex = 48;
			// 
			// btn_DatBan
			// 
			this.btn_DatBan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_DatBan.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_DatBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_DatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DatBan.Location = new System.Drawing.Point(143, 434);
			this.btn_DatBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_DatBan.Name = "btn_DatBan";
			this.btn_DatBan.Size = new System.Drawing.Size(226, 50);
			this.btn_DatBan.TabIndex = 49;
			this.btn_DatBan.Text = "Đặt";
			this.btn_DatBan.UseVisualStyleBackColor = false;
			this.btn_DatBan.Click += new System.EventHandler(this.btn_DatBan_Click);
			// 
			// txt_sdtKH
			// 
			this.txt_sdtKH.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_sdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_sdtKH.Location = new System.Drawing.Point(205, 101);
			this.txt_sdtKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_sdtKH.Name = "txt_sdtKH";
			this.txt_sdtKH.Size = new System.Drawing.Size(235, 28);
			this.txt_sdtKH.TabIndex = 50;
			this.txt_sdtKH.TextChanged += new System.EventHandler(this.txt_gioDat_TextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// dtgv_dsDatBan
			// 
			this.dtgv_dsDatBan.Anchor = System.Windows.Forms.AnchorStyles.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv_dsDatBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgv_dsDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv_dsDatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenKH,
            this.sdt,
            this.maBan,
            this.ngayDat});
			this.dtgv_dsDatBan.Location = new System.Drawing.Point(488, 101);
			this.dtgv_dsDatBan.Name = "dtgv_dsDatBan";
			this.dtgv_dsDatBan.RowHeadersVisible = false;
			this.dtgv_dsDatBan.RowHeadersWidth = 51;
			this.dtgv_dsDatBan.RowTemplate.Height = 24;
			this.dtgv_dsDatBan.Size = new System.Drawing.Size(728, 519);
			this.dtgv_dsDatBan.TabIndex = 51;
			this.dtgv_dsDatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsDatBan_CellClick);
			this.dtgv_dsDatBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgv_dsDatBan_KeyDown);
			// 
			// makh
			// 
			this.makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.makh.DataPropertyName = "MaKH";
			this.makh.HeaderText = "Mã KH";
			this.makh.MinimumWidth = 6;
			this.makh.Name = "makh";
			// 
			// tenKH
			// 
			this.tenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tenKH.DataPropertyName = "TenKH";
			this.tenKH.HeaderText = "Tên KH";
			this.tenKH.MinimumWidth = 6;
			this.tenKH.Name = "tenKH";
			// 
			// sdt
			// 
			this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sdt.DataPropertyName = "SDT";
			this.sdt.HeaderText = "SDT";
			this.sdt.MinimumWidth = 6;
			this.sdt.Name = "sdt";
			// 
			// maBan
			// 
			this.maBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.maBan.DataPropertyName = "MaBan";
			this.maBan.HeaderText = "Số bàn";
			this.maBan.MinimumWidth = 6;
			this.maBan.Name = "maBan";
			// 
			// ngayDat
			// 
			this.ngayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ngayDat.DataPropertyName = "NgayDatBan";
			this.ngayDat.HeaderText = "Ngày đặt";
			this.ngayDat.MinimumWidth = 6;
			this.ngayDat.Name = "ngayDat";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(675, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(379, 29);
			this.label6.TabIndex = 52;
			this.label6.Text = "DANH SÁCH BÀN ĐƯỢC ĐẶT";
			// 
			// btn_TimKH
			// 
			this.btn_TimKH.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_TimKH.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_TimKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_TimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TimKH.Location = new System.Drawing.Point(308, 546);
			this.btn_TimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_TimKH.Name = "btn_TimKH";
			this.btn_TimKH.Size = new System.Drawing.Size(132, 50);
			this.btn_TimKH.TabIndex = 53;
			this.btn_TimKH.Text = "Tìm kiếm";
			this.btn_TimKH.UseVisualStyleBackColor = false;
			this.btn_TimKH.Click += new System.EventHandler(this.btn_TimKH_Click);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
			this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xoa.Location = new System.Drawing.Point(65, 546);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(132, 50);
			this.btn_Xoa.TabIndex = 54;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = false;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// frmDatBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1228, 632);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.btn_TimKH);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtgv_dsDatBan);
			this.Controls.Add(this.txt_sdtKH);
			this.Controls.Add(this.btn_DatBan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmb_maBan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmb_LoaiBan);
			this.Controls.Add(this.txt_gioDat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtp_ngayDat);
			this.Controls.Add(this.label1);
			this.Name = "frmDatBan";
			this.Text = "Đặt bàn";
			this.Load += new System.EventHandler(this.frmDatBan_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgv_dsDatBan_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_dsDatBan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_ngayDat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_gioDat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb_LoaiBan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmb_maBan;
		private System.Windows.Forms.Button btn_DatBan;
		private System.Windows.Forms.TextBox txt_sdtKH;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dtgv_dsDatBan;
		private System.Windows.Forms.Button btn_TimKH;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.DataGridViewTextBoxColumn makh;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
		private System.Windows.Forms.DataGridViewTextBoxColumn maBan;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayDat;
	}
}