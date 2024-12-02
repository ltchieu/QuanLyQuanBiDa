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
        private int indexrownh = -1;
        private int indexrowxh = -1;
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
            btn_xoapn.Enabled = false;
            btn_xoapx.Enabled = false;
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
            //string mapn = String.Empty;
            //if (radioButton1.Checked)
            //{
            //    mapn = db.TaoMAPN(true);
            //}
            //else
            //{
            //    mapn = db.TaoMAPN(false);
            //}
            //txt_mapn.Text = mapn;
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
            dgv_nhaphang.DataSource = db.getDataTable("select n.MAPN, NHACC.TENNHACC , n.NGAYNHAP, NGUYENLIEU.TENNL , c.SOLUONG,c.GIA, n.THANHTIEN from PHIEUNHAP_NL n,CHI_TIET_PHIEU_NHAP_NL c,NHACC ,NHANVIEN,NGUYENLIEU where n.MANCC = NHACC.MANCC and n.MANV = NHANVIEN.MANV and c.MANL = NGUYENLIEU.MANL and n.MAPN = c.MAPN");
        }
        private void btn_nhnl_Click(object sender, EventArgs e)
        {
            LoadnhNL();
        }

        public void LoadnhVL()
        {
            dgv_nhaphang.DataSource = db.getDataTable("select n.MAPN, NHACC.TENNHACC , n.NGAYNHAP, VATLIEU.TENVL , c.SOLUONG,c.GIA, n.THANHTIEN from PHIEUNHAP_VATLIEU n,CHI_TIET_PHIEU_NHAP_VATLIEU c,NHACC ,NHANVIEN,VATLIEU where n.MANCC = NHACC.MANCC and n.MANV = NHANVIEN.MANV and c.MAVL = VATLIEU.MAVL and n.MAPN = c.MAPN");
        }
        private void btn_nhvl_Click(object sender, EventArgs e)
        {
            LoadnhVL();
        }
        private void btn_Taomapx_Click(object sender, EventArgs e)
        {
            //string mapx = db.TaoMAPX();
            //txt_mapx.Text = mapx;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lb_nv_vl.Text = "Thêm nguyên liệu";
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
                    cb_nl_vl_pn.Text = "Nhà cung cấp không cung cấp nguyên liệu";
                }
                txt_mapn.Text = db.TaoMAPN(true);
            }
            else if (radioButton2.Checked)
            {
                lb_nv_vl.Text = "Thêm vật liệu";
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
                    cb_nl_vl_pn.Text = "Nhà cung cấp không cung cấp vật liệu";
                }
                txt_mapn.Text = db.TaoMAPN(false);
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
               
                if (cb_nl_vl_pn.SelectedValue != "")
                {
                    MessageBox.Show("Tên nguyên liệu không tồn tại");
                }
                else
                {
                    dt.Columns.Add("Tên nguyên liệu");
                    dt.Columns.Add("Số lượng");
                    dt.Columns.Add("Giá");
                    dt.Columns.Add("Thành tiền");
                dt.Rows.Add(txt_mapn.Text, ngaynhap.Value, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
                txt_Gian.Clear();
                txt_sln.Clear();
                txt_ttn.Clear();
                }
            }
            else
            {

                if (cb_nl_vl_pn.SelectedValue != "")
                {
                    MessageBox.Show("Tên vật liệu không tồn tại");
                }
                else
                {
                    dt.Columns.Add("Tên vật liệu");
                    dt.Columns.Add("Số lượng");
                    dt.Columns.Add("Giá");
                    dt.Columns.Add("Thành tiền");
                dt.Rows.Add(txt_mapn.Text, ngaynhap.Value, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
                txt_Gian.Clear();
                txt_sln.Clear();
                txt_ttn.Clear();
                }
            }
            dgv_dsnhaphang.DataSource = dt;
            }
        }

        private void btn_Luunhaphang_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_sln.Text.ToString()) || String.IsNullOrEmpty(txt_Gian.ToString()))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                if (radioButton1.Checked)
                {


                    string sql = "insert into PHIEUNHAP_NL values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + txt_ttn.Text + "')";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapn = row["Mã pn"].ToString();
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
                                txt_mapn.Clear();
                                txt_sln.Clear();
                                txt_Gian.Clear();
                                txt_ttn.Clear();
                                radioButton1.Checked = false;
                                radioButton2.Checked = false;

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

                    string sql = "insert into PHIEUNHAP_VATLIEU values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + txt_ttn.Text + "')";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapn = row["Mã pn"].ToString();
                        string tenvl = row["Tên vật liệu"].ToString();
                        string sl = row["Số lượng"].ToString();
                        string gia = row["Giá"].ToString();
                        string tt = row["Thành tiền"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_VATLIEU values('" + mapn + "', '" + cb_nl_vl_pn.SelectedValue + "' , " + sl + " , " + gia + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu nhập thành công");
                                LoadnhVL();
                                txt_mapn.Clear();
                                txt_sln.Clear();
                                txt_Gian.Clear();
                                txt_ttn.Clear();
                                radioButton1.Checked = false;
                                radioButton2.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("Thêm phiếu nhập không thành công");
                            }
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
                MessageBox.Show("Phải nhập số lượng");
            }
        }
     
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                string sql = "select NGUYENLIEU.* from NCC_VatLieuNguyenLieu n, NGUYENLIEU where n.MANL = NGUYENLIEU.MANL";
                cb_nh_vl_px.DataSource = db.getDataTable(sql);
                cb_nh_vl_px.ValueMember = "MANL";
                cb_nh_vl_px.DisplayMember = "TENNL";
                lb_themtxt.Text = "Thêm nguyên liệu";
                txt_mapx.Text = db.TaoMAPX(true);
            }
            else
            {
                string sql = "select VATLIEU.* from NCC_VatLieuNguyenLieu n, VATLIEU where n.MAVL = VATLIEU.MAVL";
                cb_nh_vl_px.DataSource = db.getDataTable(sql);
                cb_nh_vl_px.ValueMember = "MAVL";
                cb_nh_vl_px.DisplayMember = "TENVL";
                lb_themtxt.Text = "Thêm vật liệu";
                txt_mapx.Text = db.TaoMAPX(false);
            }
        }

        private void btn_Thempx_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapx.Text) || String.IsNullOrEmpty(txt_slx.Text.ToString()))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã px");
                dt.Columns.Add("Ngày xuất");
                if (radioButton4.Checked)
                {
                    if (cb_nh_vl_px.SelectedValue != "")
                    {
                    dt.Columns.Add("Tên nguyên liệu");
                    dt.Columns.Add("Số lượng");

                    dt.Rows.Add(txt_mapx.Text, ngayxuat.Value, cb_nh_vl_px.Text, txt_slx.Text);
                    txt_slx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tên nguyên liệu không tồn tại");
                    }
                }
                else
                {
                    if (cb_nh_vl_px.SelectedValue != "")
                    {
                        dt.Columns.Add("Tên vật liệu");
                        dt.Columns.Add("Số lượng");

                        dt.Rows.Add(txt_mapx.Text, ngayxuat.Value, cb_nh_vl_px.Text, txt_slx.Text);
                        txt_slx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tên vật liệu không tồn tại");
                    }
                }
                dgv_dsxuathang.DataSource = dt;
            }
        }

        private void btn_luuxuathang_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapx.Text) || String.IsNullOrEmpty(txt_slx.Text.ToString()))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                if (radioButton4.Checked)
                {


                    string sql = "insert into PHIEUXUAT_NL values('" + txt_mapx.Text + "' , 'NV012','" + ngayxuat.Value.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsxuathang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapx = row["Mã px"].ToString();
                        string tennl = row["Tên nguyên liệu"].ToString();
                        string sl = row["Số lượng"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_XUAT_NL values('" + mapx + "', '" + cb_nh_vl_px.SelectedValue + "' , " + sl + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu xuất thành công");
                                LoadnhNL();
                                txt_slx.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Thêm phiếu xuất không thành công");
                            }
                        }

                    }

                }
                else
                {

                    string sql = "insert into PHIEUXUAT_VATLIEU values('" + txt_mapx.Text + "' , 'NV012','" + ngayxuat.Value.ToString("yyyy-MM-dd hh:mm:ss")  + ")";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsxuathang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapx = row["Mã px"].ToString();
                        string tenvl = row["Tên vật liệu"].ToString();
                        string sl = row["Số lượng"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_XUAT_VATLIEU values('" + mapx + "', '" + cb_nh_vl_px.SelectedValue + "' , " + sl +")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu xuất thành công");
                                LoadnhVL();
                                txt_slx.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Thêm phiếu xuất không thành công");
                            }
                        }
                    }
                }
            }
        }
        public void LoadxhNL()
        {
            dgv_xuathang.DataSource = db.getDataTable("select n.MAPX, n.NGAYXUAT, NGUYENLIEU.TENNL , c.SOLUONG from PHIEUXUAT_NL n, CHI_TIET_PHIEU_XUAT_NL c, NHANVIEN, NGUYENLIEU where n.MANV = NHANVIEN.MANV and c.MANL = NGUYENLIEU.MANL and n.MAPX = c.MAPX  ");
        }

        // Hàm load dữ liệu phiếu xuất vật liệu
        public void LoadxhVL()
        {
            dgv_xuathang.DataSource = db.getDataTable("select n.MAPX, n.NGAYXUAT, VATLIEU.TENVL , c.SOLUONG from PHIEUXUAT_VATLIEU n, CHI_TIET_PHIEU_XUAT_VATLIEU c, NHANVIEN, VATLIEU where n.MANV = NHANVIEN.MANV and c.MAVL = VATLIEU.MAVL and n.MAPX = c.MAPX");
        }
        private void btn_xuahangnl_Click(object sender, EventArgs e)
        {
            LoadxhNL();
        }

        private void btn_xuathangvl_Click(object sender, EventArgs e)
        {
            LoadxhVL();
        }

        private void btn_xoapn_Click(object sender, EventArgs e)
        {
            DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
            if (dt != null)
            {
                if (indexrownh >= 0 && indexrownh < dt.Rows.Count)
                {
                    dt.Rows.RemoveAt(indexrownh);
                }
            }
            btn_xoapn.Enabled = false;
        }

        private void dgv_dsnhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrownh = e.RowIndex;
            btn_xoapn.Enabled = false;

        }

        private void dgv_dsxuathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrowxh = e.RowIndex;
            btn_xoapx.Enabled = true;
        }

        private void btn_xoapx_Click(object sender, EventArgs e)
        {
            DataTable dt = dgv_dsxuathang.DataSource as DataTable;
            if (dt != null)
            {
                if (indexrowxh >= 0 && indexrowxh < dt.Rows.Count)
                {
                    dt.Rows.RemoveAt(indexrowxh);
                }
            }
            btn_xoapx.Enabled = false;
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void cb_nh_vl_px_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
