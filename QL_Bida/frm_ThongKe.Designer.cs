namespace QL_Bida
{
	partial class frm_ThongKe
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.cThongke = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.cbThang = new System.Windows.Forms.ComboBox();
			this.cbNam = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cThongke)).BeginInit();
			this.SuspendLayout();
			// 
			// cThongke
			// 
			this.cThongke.Anchor = System.Windows.Forms.AnchorStyles.None;
			chartArea1.Name = "ChartArea1";
			this.cThongke.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.cThongke.Legends.Add(legend1);
			this.cThongke.Location = new System.Drawing.Point(127, 111);
			this.cThongke.Name = "cThongke";
			this.cThongke.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.cThongke.Series.Add(series1);
			this.cThongke.Size = new System.Drawing.Size(918, 498);
			this.cThongke.TabIndex = 0;
			this.cThongke.Text = "chart1";
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(1055, 254);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 39);
			this.button1.TabIndex = 1;
			this.button1.Text = "Lọc";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbThang
			// 
			this.cbThang.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbThang.FormattingEnabled = true;
			this.cbThang.Location = new System.Drawing.Point(1055, 151);
			this.cbThang.Name = "cbThang";
			this.cbThang.Size = new System.Drawing.Size(121, 24);
			this.cbThang.TabIndex = 2;
			// 
			// cbNam
			// 
			this.cbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbNam.FormattingEnabled = true;
			this.cbNam.Location = new System.Drawing.Point(1055, 213);
			this.cbNam.Name = "cbNam";
			this.cbNam.Size = new System.Drawing.Size(121, 24);
			this.cbNam.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(367, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 42);
			this.label1.TabIndex = 4;
			this.label1.Text = "Thống kê doanh thu ";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1052, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Chọn tháng";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1051, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Chọn năm";
			// 
			// frm_ThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1302, 687);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbNam);
			this.Controls.Add(this.cbThang);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cThongke);
			this.Name = "frm_ThongKe";
			this.Text = "frm_ThongKe";
			this.Load += new System.EventHandler(this.frm_ThongKe_Load);
			((System.ComponentModel.ISupportInitialize)(this.cThongke)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
		private System.Windows.Forms.DataVisualization.Charting.Chart cThongke;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cbThang;
		private System.Windows.Forms.ComboBox cbNam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}