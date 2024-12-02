namespace QL_Bida
{
	partial class frm_DichVu
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMADV = new System.Windows.Forms.TextBox();
			this.btnSua = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbLoaiDV = new System.Windows.Forms.ComboBox();
			this.txtGiaDV = new System.Windows.Forms.TextBox();
			this.txtTenDV = new System.Windows.Forms.TextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvDichVu = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.dgvDichVu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1387, 615);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(769, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 38);
			this.button1.TabIndex = 13;
			this.button1.Text = "Tìm kiếm";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.Location = new System.Drawing.Point(65, 108);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(698, 38);
			this.textBox1.TabIndex = 12;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.groupBox1.Controls.Add(this.txtMADV);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbLoaiDV);
			this.groupBox1.Controls.Add(this.txtGiaDV);
			this.groupBox1.Controls.Add(this.txtTenDV);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(902, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(403, 345);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin dịch vụ";
			// 
			// txtMADV
			// 
			this.txtMADV.Location = new System.Drawing.Point(215, 44);
			this.txtMADV.Name = "txtMADV";
			this.txtMADV.Size = new System.Drawing.Size(100, 28);
			this.txtMADV.TabIndex = 19;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(272, 233);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(98, 47);
			this.btnSua.TabIndex = 18;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 17;
			this.label3.Text = "Loại dịch vụ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(229, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "Giá";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Tên dịch vụ";
			// 
			// cbLoaiDV
			// 
			this.cbLoaiDV.FormattingEnabled = true;
			this.cbLoaiDV.Location = new System.Drawing.Point(37, 167);
			this.cbLoaiDV.Name = "cbLoaiDV";
			this.cbLoaiDV.Size = new System.Drawing.Size(121, 30);
			this.cbLoaiDV.TabIndex = 14;
			// 
			// txtGiaDV
			// 
			this.txtGiaDV.Location = new System.Drawing.Point(233, 129);
			this.txtGiaDV.Name = "txtGiaDV";
			this.txtGiaDV.Size = new System.Drawing.Size(100, 28);
			this.txtGiaDV.TabIndex = 13;
			// 
			// txtTenDV
			// 
			this.txtTenDV.Location = new System.Drawing.Point(37, 87);
			this.txtTenDV.Name = "txtTenDV";
			this.txtTenDV.Size = new System.Drawing.Size(121, 28);
			this.txtTenDV.TabIndex = 12;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(155, 233);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(98, 47);
			this.btnXoa.TabIndex = 11;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(37, 233);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(98, 47);
			this.btnThem.TabIndex = 10;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(613, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(291, 42);
			this.label4.TabIndex = 10;
			this.label4.Text = "Quản lý dịch vụ";
			// 
			// dgvDichVu
			// 
			this.dgvDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDichVu.Location = new System.Drawing.Point(65, 152);
			this.dgvDichVu.Name = "dgvDichVu";
			this.dgvDichVu.RowHeadersWidth = 51;
			this.dgvDichVu.RowTemplate.Height = 24;
			this.dgvDichVu.Size = new System.Drawing.Size(819, 301);
			this.dgvDichVu.TabIndex = 0;
			this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
			// 
			// frm_DichVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 615);
			this.Controls.Add(this.panel1);
			this.Name = "frm_DichVu";
			this.Text = "frm_DichVu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frm_DichVu_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvDichVu;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbLoaiDV;
		private System.Windows.Forms.TextBox txtGiaDV;
		private System.Windows.Forms.TextBox txtTenDV;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtMADV;
	}
}