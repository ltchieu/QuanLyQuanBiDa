namespace QL_Bida
{
	partial class frm_QLNV
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtManv = new System.Windows.Forms.TextBox();
			this.txtTennv = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.cb_Chucvu = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.btnThemNV = new System.Windows.Forms.Button();
			this.btnSuaNV = new System.Windows.Forms.Button();
			this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btn_TIemKiem = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnSuaNV);
			this.panel1.Controls.Add(this.btnThemNV);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.cb_Chucvu);
			this.panel1.Controls.Add(this.txtSDT);
			this.panel1.Controls.Add(this.txtDiaChi);
			this.panel1.Controls.Add(this.txtTennv);
			this.panel1.Controls.Add(this.txtManv);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(876, 93);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(588, 598);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(321, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhân viên";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Chức vụ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(320, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nhóm nhân viên";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(58, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Địa chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(320, 233);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "Số điện thoại";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(203, 326);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "Ngày vào làm";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// txtManv
			// 
			this.txtManv.Location = new System.Drawing.Point(61, 76);
			this.txtManv.Multiline = true;
			this.txtManv.Name = "txtManv";
			this.txtManv.Size = new System.Drawing.Size(134, 32);
			this.txtManv.TabIndex = 7;
			// 
			// txtTennv
			// 
			this.txtTennv.Location = new System.Drawing.Point(324, 76);
			this.txtTennv.Multiline = true;
			this.txtTennv.Name = "txtTennv";
			this.txtTennv.Size = new System.Drawing.Size(164, 32);
			this.txtTennv.TabIndex = 8;
			this.txtTennv.TextChanged += new System.EventHandler(this.txtTennv_TextChanged);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(62, 261);
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(136, 31);
			this.txtDiaChi.TabIndex = 9;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(324, 261);
			this.txtSDT.Multiline = true;
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(164, 31);
			this.txtSDT.TabIndex = 10;
			this.txtSDT.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// cb_Chucvu
			// 
			this.cb_Chucvu.FormattingEnabled = true;
			this.cb_Chucvu.Location = new System.Drawing.Point(61, 163);
			this.cb_Chucvu.Name = "cb_Chucvu";
			this.cb_Chucvu.Size = new System.Drawing.Size(136, 24);
			this.cb_Chucvu.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(154, 354);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(231, 22);
			this.dateTimePicker1.TabIndex = 13;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(324, 163);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(108, 29);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Full-time";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(324, 189);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(112, 29);
			this.checkBox2.TabIndex = 15;
			this.checkBox2.Text = "Part-time";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// btnThemNV
			// 
			this.btnThemNV.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnThemNV.FlatAppearance.BorderSize = 0;
			this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemNV.Location = new System.Drawing.Point(69, 461);
			this.btnThemNV.Name = "btnThemNV";
			this.btnThemNV.Size = new System.Drawing.Size(126, 54);
			this.btnThemNV.TabIndex = 16;
			this.btnThemNV.Text = "Thêm";
			this.btnThemNV.UseVisualStyleBackColor = false;
			// 
			// btnSuaNV
			// 
			this.btnSuaNV.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnSuaNV.FlatAppearance.BorderSize = 0;
			this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuaNV.Location = new System.Drawing.Point(373, 461);
			this.btnSuaNV.Name = "btnSuaNV";
			this.btnSuaNV.Size = new System.Drawing.Size(115, 54);
			this.btnSuaNV.TabIndex = 17;
			this.btnSuaNV.Text = "Sửa";
			this.btnSuaNV.UseVisualStyleBackColor = false;
			this.btnSuaNV.Click += new System.EventHandler(this.button2_Click);
			// 
			// dgv_NhanVien
			// 
			this.dgv_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_NhanVien.Location = new System.Drawing.Point(26, 141);
			this.dgv_NhanVien.Name = "dgv_NhanVien";
			this.dgv_NhanVien.RowHeadersWidth = 51;
			this.dgv_NhanVien.RowTemplate.Height = 24;
			this.dgv_NhanVien.Size = new System.Drawing.Size(844, 550);
			this.dgv_NhanVien.TabIndex = 0;
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSearch.Location = new System.Drawing.Point(26, 93);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(729, 42);
			this.txtSearch.TabIndex = 1;
			// 
			// btn_TIemKiem
			// 
			this.btn_TIemKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_TIemKiem.BackColor = System.Drawing.Color.Aqua;
			this.btn_TIemKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TIemKiem.Location = new System.Drawing.Point(761, 93);
			this.btn_TIemKiem.Name = "btn_TIemKiem";
			this.btn_TIemKiem.Size = new System.Drawing.Size(109, 42);
			this.btn_TIemKiem.TabIndex = 2;
			this.btn_TIemKiem.Text = "Search";
			this.btn_TIemKiem.UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(600, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(337, 42);
			this.label8.TabIndex = 4;
			this.label8.Text = "Quản lý nhân viên";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(222, 461);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(126, 54);
			this.btnXoa.TabIndex = 18;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			// 
			// frm_QLNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1492, 755);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_TIemKiem);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.dgv_NhanVien);
			this.Name = "frm_QLNV";
			this.Text = "frm_QLNV";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cb_Chucvu;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtTennv;
		private System.Windows.Forms.TextBox txtManv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnSuaNV;
		private System.Windows.Forms.Button btnThemNV;
		private System.Windows.Forms.DataGridView dgv_NhanVien;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btn_TIemKiem;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnXoa;
	}
}