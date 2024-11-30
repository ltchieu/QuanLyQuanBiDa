namespace QL_Bida
{
    partial class frm_NhapKho
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
            System.Windows.Forms.TextBox txt_tt;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btn_Taomapn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_nhacc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mapn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoapn = new System.Windows.Forms.Button();
            this.cb_nl_vl = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.btn_Thempn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_nhaphang = new System.Windows.Forms.DataGridView();
            this.btn_nhnl = new System.Windows.Forms.Button();
            this.btn_nhvl = new System.Windows.Forms.Button();
            txt_tt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngaynhap);
            this.groupBox1.Controls.Add(this.btn_Taomapn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_nhacc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mapn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // ngaynhap
            // 
            this.ngaynhap.Location = new System.Drawing.Point(230, 176);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Size = new System.Drawing.Size(227, 22);
            this.ngaynhap.TabIndex = 10;
            // 
            // btn_Taomapn
            // 
            this.btn_Taomapn.Location = new System.Drawing.Point(187, 260);
            this.btn_Taomapn.Name = "btn_Taomapn";
            this.btn_Taomapn.Size = new System.Drawing.Size(169, 29);
            this.btn_Taomapn.TabIndex = 9;
            this.btn_Taomapn.Text = "Tạo mã phiếu nhập";
            this.btn_Taomapn.UseVisualStyleBackColor = true;
            this.btn_Taomapn.Click += new System.EventHandler(this.btn_Taomapn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày nhập";
            // 
            // cb_nhacc
            // 
            this.cb_nhacc.FormattingEnabled = true;
            this.cb_nhacc.Location = new System.Drawing.Point(230, 103);
            this.cb_nhacc.Name = "cb_nhacc";
            this.cb_nhacc.Size = new System.Drawing.Size(227, 24);
            this.cb_nhacc.TabIndex = 6;
            this.cb_nhacc.SelectedIndexChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhà cung cấp";
            // 
            // txt_mapn
            // 
            this.txt_mapn.Enabled = false;
            this.txt_mapn.Location = new System.Drawing.Point(230, 53);
            this.txt_mapn.Name = "txt_mapn";
            this.txt_mapn.Size = new System.Drawing.Size(227, 22);
            this.txt_mapn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // txt_tt
            // 
            txt_tt.Enabled = false;
            txt_tt.Location = new System.Drawing.Point(277, 260);
            txt_tt.Name = "txt_tt";
            txt_tt.Size = new System.Drawing.Size(227, 22);
            txt_tt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(87, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thành tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoapn);
            this.groupBox2.Controls.Add(this.cb_nl_vl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(txt_tt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Gia);
            this.groupBox2.Controls.Add(this.btn_Thempn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_sl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(608, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 347);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm phiếu nhập";
            // 
            // btn_xoapn
            // 
            this.btn_xoapn.Location = new System.Drawing.Point(274, 300);
            this.btn_xoapn.Name = "btn_xoapn";
            this.btn_xoapn.Size = new System.Drawing.Size(169, 28);
            this.btn_xoapn.TabIndex = 17;
            this.btn_xoapn.Text = "Xóa phiếu nhập";
            this.btn_xoapn.UseVisualStyleBackColor = true;
            this.btn_xoapn.Click += new System.EventHandler(this.btn_xoapn_Click);
            // 
            // cb_nl_vl
            // 
            this.cb_nl_vl.FormattingEnabled = true;
            this.cb_nl_vl.Location = new System.Drawing.Point(274, 96);
            this.cb_nl_vl.Name = "cb_nl_vl";
            this.cb_nl_vl.Size = new System.Drawing.Size(230, 24);
            this.cb_nl_vl.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(91, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thêm";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(331, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 21);
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
            this.radioButton1.Size = new System.Drawing.Size(104, 21);
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
            this.label8.Size = new System.Drawing.Size(202, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chọn nguyên liệu hoặc vật liệu";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(277, 210);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(227, 22);
            this.txt_Gia.TabIndex = 11;
            // 
            // btn_Thempn
            // 
            this.btn_Thempn.Location = new System.Drawing.Point(66, 300);
            this.btn_Thempn.Name = "btn_Thempn";
            this.btn_Thempn.Size = new System.Drawing.Size(169, 28);
            this.btn_Thempn.TabIndex = 9;
            this.btn_Thempn.Text = "Thêm phiếu nhập";
            this.btn_Thempn.UseVisualStyleBackColor = true;
            this.btn_Thempn.Click += new System.EventHandler(this.btn_Thempn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(86, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá";
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
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_nhaphang);
            this.groupBox3.Location = new System.Drawing.Point(12, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1169, 335);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng nhập hàng";
            // 
            // dgv_nhaphang
            // 
            this.dgv_nhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhaphang.Location = new System.Drawing.Point(3, 18);
            this.dgv_nhaphang.Name = "dgv_nhaphang";
            this.dgv_nhaphang.RowTemplate.Height = 24;
            this.dgv_nhaphang.Size = new System.Drawing.Size(1160, 308);
            this.dgv_nhaphang.TabIndex = 0;
            this.dgv_nhaphang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_nhaphang_CellMouseClick);
            // 
            // btn_nhnl
            // 
            this.btn_nhnl.Location = new System.Drawing.Point(360, 369);
            this.btn_nhnl.Name = "btn_nhnl";
            this.btn_nhnl.Size = new System.Drawing.Size(222, 29);
            this.btn_nhnl.TabIndex = 11;
            this.btn_nhnl.Text = "Hiển thi nhập hàng nguyên liệu";
            this.btn_nhnl.UseVisualStyleBackColor = true;
            this.btn_nhnl.Click += new System.EventHandler(this.btn_nhnl_Click);
            // 
            // btn_nhvl
            // 
            this.btn_nhvl.Location = new System.Drawing.Point(602, 369);
            this.btn_nhvl.Name = "btn_nhvl";
            this.btn_nhvl.Size = new System.Drawing.Size(219, 29);
            this.btn_nhvl.TabIndex = 13;
            this.btn_nhvl.Text = "Hiển thị nhập hàng vật liệu";
            this.btn_nhvl.UseVisualStyleBackColor = true;
            this.btn_nhvl.Click += new System.EventHandler(this.btn_nhvl_Click);
            // 
            // frm_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 764);
            this.Controls.Add(this.btn_nhvl);
            this.Controls.Add(this.btn_nhnl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NhapKho";
            this.Text = "frm_NhapKho";
            this.Load += new System.EventHandler(this.frm_NhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mapn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaynhap;
        private System.Windows.Forms.Button btn_Taomapn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_nhacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Button btn_Thempn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_nhaphang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cb_nl_vl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_nhnl;
        private System.Windows.Forms.Button btn_nhvl;
        private System.Windows.Forms.Button btn_xoapn;
    }
}