using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Bida
{
    public partial class frm_QLKho : Form
    {
        public DBConnect db = new DBConnect();
        public frm_QLKho()
        {
            InitializeComponent();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int kq = db.getNonquery("delete from NGUYENLIEU where MANL = '" + txt__manl.Text + "'");
            if (kq != 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadNL();
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int kq = db.getNonquery("insert into NGUYENLIEU values(N'" + txt__manl.Text + "', N'" + txt_tennl.Text + "' , N'" + rc_mota.Text + "' , 0)");
            if (kq != 0)
            {
                MessageBox.Show("Thêm nguyên liệu thành công");
                LoadNL();
            }
            else
            {
                
                    MessageBox.Show("Thêm nguyên liệu không thành công");
                
            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            dgv_nl.DataSource = db.getDataTable("select NGUYENLIEU.* from DICHVU_NGUYENLIEU , NGUYENLIEU where MADV = '" + cb_monan.SelectedValue + "' and NGUYENLIEU.MANL = DICHVU_NGUYENLIEU.MANL");
        }
        public void LoadVL()
        {
            // Tải dữ liệu vật liệu từ cơ sở dữ liệu vào DataGridView
            DataTable dt = db.getDataTable("select * from VATLIEU");
            dgv_vl.DataSource = dt;
            cb_tenvl.DataSource = dt;
            cb_tenvl.ValueMember = "MAVL";
            cb_tenvl.DisplayMember = "TENVL";
        }

      

       
        public void LoadNL()
        {
            dgv_nl.DataSource = db.getDataTable("select * from NGUYENLIEU");
        }

        public void LoadMonAn()
        {
            cb_monan.DataSource = db.getDataTable("select * from DichVu");
            cb_monan.ValueMember = "MaDV";
            cb_monan.DisplayMember = "TenDV";
        }
      
       
       
        


       
        private void frm_QLKho_Load(object sender, EventArgs e)
        {
            LoadNL();
            LoadMonAn();
            LoadVL();
            Loadncc();
            ngaynhap.Value = DateTime.Now;
        }

        

        private void btn_locvl_Click(object sender, EventArgs e)
        {

        }

        private void btn_themvl_Click(object sender, EventArgs e)
        {
           
            // Thêm một vật liệu mới vào cơ sở dữ liệu
            int kq = db.getNonquery("insert into VATLIEU values(N'" + txt__mavl.Text + "', N'" + txt_tenvl.Text + "', N'" + rc_mota.Text + "' , 0)");
            if (kq != 0)
            {
                MessageBox.Show("Thêm vật liệu thành công");
                LoadVL(); // Tải lại danh sách vật liệu
            }
            else
            {
                 MessageBox.Show("Thêm vật liệu không thành công");
                
            }
        
        }

        private void btn_xoavl_Click(object sender, EventArgs e)
        {
           
            // Xóa vật liệu theo mã vật liệu
            int kq = db.getNonquery("delete from VATLIEU where MAVL = '" + txt__mavl.Text + "'");
            if (kq != 0)
            {
                MessageBox.Show("Xóa vật liệu thành công");
                LoadVL(); // Tải lại danh sách vật liệu
            }
            else
            {
                MessageBox.Show("Không xóa được vật liệu");
            }
        }
        #region tabnhapkho
        private void btn_Taomapn_Click(object sender, EventArgs e)
        {
            string mapn = db.TaoMAPN();
            txt_mapn.Text = mapn;
        }
        private void dgv_nl_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = dgv_nl.DataSource as DataTable;

            txt__manl.Text = dt.Rows[e.RowIndex]["MANL"].ToString();
            txt_tennl.Text = dt.Rows[e.RowIndex]["TENNL"].ToString();
            rc_mota.Text = dt.Rows[e.RowIndex]["mota"].ToString();
        }
        #endregion

        #region tabxuatkho
        public void Loadncc()
        {
            cb_nhacc.DataSource = db.getDataTable("select * from NHACC");
            cb_nhacc.ValueMember = "MANCC";
            cb_nhacc.DisplayMember = "TENNHACC";
        }
       
        public void LoadnhNL()
        {
            dgv_nhaphang.DataSource = db.getDataTable("select n.MAPN, NHACC.TENNHACC , n.NGAYNHAP, NGUYENLIEU.TENNL , c.SOLUONG,c.GIA, n.THANHTIEN from PHIEUNHAP_NL n,CHI_TIET_PHIEU_NHAP_NL c,NHACC ,NHANVIEN,NGUYENLIEU where n.MANCC = NHACC.MANCC and n.MANV = NHANVIEN.MANV and c.MANL = NGUYENLIEU.MANL");
        }
        private void btn_nhnl_Click(object sender, EventArgs e)
        {
            LoadnhNL();
        }

        public void LoadnhVL()
        {
            dgv_nhaphang.DataSource = db.getDataTable("select n.MAPN, NHACC.TENNHACC , n.NGAYNHAP, VATLIEU.TENNL , c.SOLUONG,c.GIA, n.THANHTIEN from PHIEUNHAP_VATLIEU n,CHI_TIET_PHIEU_NHAP_VATLIEU c,NHACC ,NHANVIEN,VATLIEU where n.MANCC = NHACC.MANCC and n.MANV = NHANVIEN.MANV and c.MAVL = VATLIEU.MAVL");
        }
        private void btn_nhvl_Click(object sender, EventArgs e)
        {
            LoadnhVL();
        }
        private void btn_Taomapx_Click(object sender, EventArgs e)
        {
            string mapx = db.TaoMAPX();
            txt_mapx.Text = mapx;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string sql1 = "select count(*) from NCC_VatLieuNguyenLieu n,NHACC,NGUYENLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MANL = NGUYENLIEU.MANL";
                string sql = "select NGUYENLIEU.* from NCC_VatLieuNguyenLieu n,NHACC,NGUYENLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MANL = NGUYENLIEU.MANL";
                int result = db.getScalar(sql1);
                if (result != 0)
                {
                    cb_nl_vl_pn.DataSource = db.getDataTable(sql);
                    cb_nl_vl_pn.ValueMember = "MANL";
                    cb_nl_vl_pn.DisplayMember = "TENNL";
                }
                else
                {
                    cb_nl_vl_pn.DataSource = null;
                    cb_nl_vl_pn.Text = "Nhà cung cấp không cung cấp nguyên liệu này";
                }
            }
            else if (radioButton2.Checked)
            {
                string sql1 = "select count(*) from NCC_VatLieuNguyenLieu n,NHACC,VATLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVL = VATLIEU.MAVL";
                string sql = "select VATLIEU.* from NCC_VatLieuNguyenLieu n,NHACC,VATLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVL = VATLIEU.MAVL";
                int result = db.getScalar(sql1);
                if (result != 0)
                {
                    cb_nl_vl_pn.DataSource = db.getDataTable(sql);
                    cb_nl_vl_pn.ValueMember = "MAVL";
                    cb_nl_vl_pn.DisplayMember = "TENVL";
                }
                else
                {
                    cb_nl_vl_pn.DataSource = null;
                    cb_nl_vl_pn.Text = "Nhà cung cấp không cung cấp vật liệu này";
                }
            }
        }
        #endregion
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thempn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_sln.Text.ToString()) || String.IsNullOrEmpty(txt_Gian.ToString()))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã pn");
            dt.Columns.Add("Ngày nhập");
            if (radioButton1.Checked)
            {
                dt.Columns.Add("Tên nguyên liệu");
                dt.Columns.Add("Số lượng");
                dt.Columns.Add("Giá");
                dt.Columns.Add("Thành tiền");

                dt.Rows.Add(txt_mapn.Text, ngaynhap, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
            }
            else
            {
                dt.Columns.Add("Tên vật liệu");
                dt.Columns.Add("Số lượng");
                dt.Columns.Add("Giá");
                dt.Columns.Add("Thành tiền");

                dt.Rows.Add(txt_mapn.Text, ngaynhap, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
            }
            dgv_dsnhaphang.DataSource = dt;
            }
        }

        private void btn_Luunhaphang_Click(object sender, EventArgs e)
        {
           
                if (radioButton1.Checked)
                {
                   
                    
                        string sql = "insert into PHIEUNHAP_NL values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', null)";
                        int res = db.getNonquery(sql);
                DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                foreach (DataRow row in dt.Rows)
                    {
                        string mapn = row["Mã pn"].ToString();
                        string ngaynhap = row["Ngày nhập"].ToString();
                        string tennl = row["Tên nguyên liệu"].ToString();
                        string sl = row["Số lượng"].ToString();
                        string gia = row["Giá"].ToString();
                        string tt = row["Thành tiền"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_NL values('" + mapn + "', '" + cb_nl_vl_pn.SelectedValue + "' , " + sl + " , " + gia + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu nhập thành công");
                                LoadnhNL();
                                txt_sln.Clear();
                                txt_Gian.Clear();
                                txt_ttn.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Thêm phiếu nhập không thành công");
                            }
                        }

                    }
                        
                    }
                else
                {
                    
                        string sql = "insert into PHIEUNHAP_VATLIEU values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") + "',null)";
                        int res = db.getNonquery(sql);
                DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapn = row["Mã pn"].ToString();
                        string ngaynhap = row["Ngày nhập"].ToString();
                        string tenvl = row["Tên vật liệu"].ToString();
                        string sl = row["Số lượng"].ToString();
                        string gia = row["Giá"].ToString();
                        string tt = row["Thành tiền"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_VATLIEU values('" + mapn+ "', '" + cb_nl_vl_pn.SelectedValue + "' , " + txt_sln + " , " + txt_Gian + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu nhập thành công");
                                LoadnhVL();
                                txt_sln.Clear();
                                txt_Gian.Clear();
                                txt_ttn.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Thêm phiếu nhập không thành công");
                            }
                        }
                    }
            }
        }

        private void txt_Gian_Leave(object sender, EventArgs e)
        {
            if(txt_sln.Text != "")
            {
                txt_ttn.Text = (double.Parse(txt_sln.Text) * double.Parse(txt_Gian.Text)).ToString() ;
            }
            else
            {
                MessageBox.Show("Phai nhap so luong");
            }
        }
    }
}
