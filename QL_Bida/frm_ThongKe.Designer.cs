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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.cThongke = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.cbThang = new System.Windows.Forms.ComboBox();
			this.cbNam = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cThongke)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// cThongke
			// 
			this.cThongke.Anchor = System.Windows.Forms.AnchorStyles.None;
			chartArea1.Name = "ChartArea1";
			this.cThongke.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.cThongke.Legends.Add(legend1);
			this.cThongke.Location = new System.Drawing.Point(12, 110);
			this.cThongke.Name = "cThongke";
			this.cThongke.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.cThongke.Series.Add(series1);
			this.cThongke.Size = new System.Drawing.Size(819, 422);
			this.cThongke.TabIndex = 0;
			this.cThongke.Text = "chart1";
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(837, 241);
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
			this.cbThang.Location = new System.Drawing.Point(837, 138);
			this.cbThang.Name = "cbThang";
			this.cbThang.Size = new System.Drawing.Size(121, 24);
			this.cbThang.TabIndex = 2;
			// 
			// cbNam
			// 
			this.cbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbNam.FormattingEnabled = true;
			this.cbNam.Location = new System.Drawing.Point(837, 200);
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
			this.label1.Location = new System.Drawing.Point(203, 65);
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
			this.label2.Location = new System.Drawing.Point(834, 112);
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
			this.label3.Location = new System.Drawing.Point(833, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Chọn năm";
			// 
			// chart1
			// 
			this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(1055, 142);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(366, 390);
			this.chart1.TabIndex = 7;
			this.chart1.Text = "chart1";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(1175, 112);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lucida Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(1080, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(294, 42);
			this.label4.TabIndex = 9;
			this.label4.Text = "Tỷ lệ chọn bàn";
			// 
			// frm_ThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1433, 687);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.chart1);
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
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
	}
}