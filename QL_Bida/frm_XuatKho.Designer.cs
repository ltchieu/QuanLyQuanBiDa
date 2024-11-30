namespace QL_Bida
{
    partial class frm_XuatKho
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
            this.btn_xoapx = new System.Windows.Forms.Button();
            this.btn_nhnl = new System.Windows.Forms.Button();
            this.dgv_xuathang = new System.Windows.Forms.DataGridView();
            this.btn_nhvl = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_nl_vl = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Thempx = new System.Windows.Forms.Button();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngayxuat = new System.Windows.Forms.DateTimePicker();
            this.btn_Taomapx = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mapx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_dsxuathang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xuathang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsxuathang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoapx
            // 
            this.btn_xoapx.Location = new System.Drawing.Point(274, 300);
            this.btn_xoapx.Name = "btn_xoapx";
            this.btn_xoapx.Size = new System.Drawing.Size(169, 28);
            this.btn_xoapx.TabIndex = 17;
            this.btn_xoapx.Text = "Xóa phiếu xuất";
            this.btn_xoapx.UseVisualStyleBackColor = true;
            this.btn_xoapx.Click += new System.EventHandler(this.btn_xoapx_Click);
            // 
            // btn_nhnl
            // 
            this.btn_nhnl.Location = new System.Drawing.Point(193, 379);
            this.btn_nhnl.Name = "btn_nhnl";
            this.btn_nhnl.Size = new System.Drawing.Size(222, 29);
            this.btn_nhnl.TabIndex = 15;
            this.btn_nhnl.Text = "Hiển thi xuất hàng nguyên liệu";
            this.btn_nhnl.UseVisualStyleBackColor = true;
            this.btn_nhnl.Click += new System.EventHandler(this.btn_nhnl_Click);
            // 
            // dgv_xuathang
            // 
            this.dgv_xuathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xuathang.Location = new System.Drawing.Point(3, 18);
            this.dgv_xuathang.Name = "dgv_xuathang";
            this.dgv_xuathang.RowHeadersWidth = 51;
            this.dgv_xuathang.RowTemplate.Height = 24;
            this.dgv_xuathang.Size = new System.Drawing.Size(645, 308);
            this.dgv_xuathang.TabIndex = 0;
            this.dgv_xuathang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_xuathang_CellMouseClick);
            // 
            // btn_nhvl
            // 
            this.btn_nhvl.Location = new System.Drawing.Point(435, 379);
            this.btn_nhvl.Name = "btn_nhvl";
            this.btn_nhvl.Size = new System.Drawing.Size(219, 29);
            this.btn_nhvl.TabIndex = 18;
            this.btn_nhvl.Text = "Hiển thị xuất hàng vật liệu";
            this.btn_nhvl.UseVisualStyleBackColor = true;
            this.btn_nhvl.Click += new System.EventHandler(this.btn_nhvl_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_xuathang);
            this.groupBox3.Location = new System.Drawing.Point(109, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 335);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng xuất hàng";
            // 
            // cb_nl_vl
            // 
            this.cb_nl_vl.FormattingEnabled = true;
            this.cb_nl_vl.Location = new System.Drawing.Point(274, 96);
            this.cb_nl_vl.Name = "cb_nl_vl";
            this.cb_nl_vl.Size = new System.Drawing.Size(230, 24);
            this.cb_nl_vl.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoapx);
            this.groupBox2.Controls.Add(this.cb_nl_vl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_tt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_Thempx);
            this.groupBox2.Controls.Add(this.txt_sl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(705, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 347);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm phiếu xuất";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(91, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thêm";
            // 
            // txt_tt
            // 
            this.txt_tt.HideSelection = false;
            this.txt_tt.Location = new System.Drawing.Point(274, 212);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.Size = new System.Drawing.Size(227, 22);
            this.txt_tt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thành tiền";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(331, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 20);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vật liệu";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(331, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 20);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nguyên liệu";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chọn nguyên liệu hoặc vật liệu";
            // 
            // btn_Thempx
            // 
            this.btn_Thempx.Location = new System.Drawing.Point(66, 300);
            this.btn_Thempx.Name = "btn_Thempx";
            this.btn_Thempx.Size = new System.Drawing.Size(169, 28);
            this.btn_Thempx.TabIndex = 9;
            this.btn_Thempx.Text = "Thêm phiếu xuất";
            this.btn_Thempx.UseVisualStyleBackColor = true;
            this.btn_Thempx.Click += new System.EventHandler(this.btn_Thempx_Click);
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(277, 157);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(227, 22);
            this.txt_sl.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(86, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngayxuat);
            this.groupBox1.Controls.Add(this.btn_Taomapx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mapx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 347);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu xuất";
            // 
            // ngayxuat
            // 
            this.ngayxuat.Location = new System.Drawing.Point(230, 121);
            this.ngayxuat.Name = "ngayxuat";
            this.ngayxuat.Size = new System.Drawing.Size(227, 22);
            this.ngayxuat.TabIndex = 10;
            // 
            // btn_Taomapx
            // 
            this.btn_Taomapx.Location = new System.Drawing.Point(187, 205);
            this.btn_Taomapx.Name = "btn_Taomapx";
            this.btn_Taomapx.Size = new System.Drawing.Size(169, 29);
            this.btn_Taomapx.TabIndex = 9;
            this.btn_Taomapx.Text = "Tạo mã phiếu xuất";
            this.btn_Taomapx.UseVisualStyleBackColor = true;
            this.btn_Taomapx.Click += new System.EventHandler(this.btn_Taomapx_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày nhập";
            // 
            // txt_mapx
            // 
            this.txt_mapx.Enabled = false;
            this.txt_mapx.Location = new System.Drawing.Point(230, 53);
            this.txt_mapx.Name = "txt_mapx";
            this.txt_mapx.Size = new System.Drawing.Size(227, 22);
            this.txt_mapx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_dsxuathang);
            this.groupBox4.Location = new System.Drawing.Point(825, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 326);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách xuất hàng";
            // 
            // dgv_dsxuathang
            // 
            this.dgv_dsxuathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsxuathang.Location = new System.Drawing.Point(3, 18);
            this.dgv_dsxuathang.Name = "dgv_dsxuathang";
            this.dgv_dsxuathang.RowHeadersWidth = 51;
            this.dgv_dsxuathang.RowTemplate.Height = 24;
            this.dgv_dsxuathang.Size = new System.Drawing.Size(453, 302);
            this.dgv_dsxuathang.TabIndex = 0;
            // 
            // frm_XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 760);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_nhnl);
            this.Controls.Add(this.btn_nhvl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_XuatKho";
            this.Text = "frm_XuatKho";
            this.Load += new System.EventHandler(this.frm_XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xuathang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsxuathang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_xoapx;
        private System.Windows.Forms.Button btn_nhnl;
        private System.Windows.Forms.DataGridView dgv_xuathang;
        private System.Windows.Forms.Button btn_nhvl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_nl_vl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Thempx;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker ngayxuat;
        private System.Windows.Forms.Button btn_Taomapx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mapx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_dsxuathang;
    }
}