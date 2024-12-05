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
        private int indexnl = -1;
        private int indexvl = -1;
        public frm_QLKho()
        {
            InitializeComponent();
        }

        #region NguyenLieu
        private void btn_taomanl_Click(object sender, EventArgs e)
        {
            string manl = "NL";
            string query = "select MANL from NGUYENLIEU where MANL like '" + manl + "%' order by MANL desc";
            DataTable dt = db.getDataTable(query);
            if (dt.Rows.Count == 0)
            {
                manl += "001";
            }
            else
            {
                int stt = int.Parse(dt.Rows[0][0].ToString().Substring(3));
                stt++;
                if (stt.ToString().Length == 1)
                {
                    manl += "00" + stt.ToString();
                }
                else if (stt.ToString().Length == 2)
                    manl += "0" + stt.ToString();
                else
                    manl += stt.ToString();
            }

            txt__manl.Text = manl;
            btn_taomanl.Enabled = false;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int kq = db.getNonquery("delete from DichVu_NguyenLieu where MANL = '" + txt__manl.Text + "'");
            if (kq != 0)
            {
                int kq1 = db.getNonquery("delete from NGUYENLIEU where MANL = '" + txt__manl.Text + "'");
                if (kq1 != 0)
                {
                MessageBox.Show("Xóa thành công");
                LoadNL();
                btn_xoa.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
            {
                int kq = db.getNonquery("insert into NGUYENLIEU values(N'" + txt__manl.Text + "', N'" + txt_tennl.Text + "' , N'" + rc_mota.Text + "' , "+txt_slnl.Text+")");
                if (kq != 0)
                {
                    MessageBox.Show("Thêm nguyên liệu thành công");
                    LoadNL();
                    txt__manl.Clear();
                    txt_tennl.Clear();
                    rc_mota.Clear();

                }
                else
                {
                
                        MessageBox.Show("Thêm nguyên liệu không thành công");
                
                }
                btn_taomanl.Enabled = true;
            }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            dgv_nl.DataSource = db.getDataTable("select NGUYENLIEU.* from DICHVU_NGUYENLIEU , NGUYENLIEU where MADV = '" + cb_monan.SelectedValue + "' and NGUYENLIEU.MANL = DICHVU_NGUYENLIEU.MANL");
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
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int kq =  db.getNonquery("update NGUYENLIEU set TENNL = N'" + txt_tennl.Text + "' , MOTA = N'" + rc_mota.Text + "', SOLUONGTON =" + txt_slnl.Text + " where MANL = '"+txt__manl.Text+"'");
            if (kq != 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadNL();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
            
        }
        private void dgv_nl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexnl = e.RowIndex;

            if (indexnl >= 0 && indexnl < dgv_nl.Rows.Count - 1)
            {
            DataTable dt = dgv_nl.DataSource as DataTable;
            txt__manl.Text = dt.Rows[indexnl]["MANL"].ToString();
            txt_tennl.Text = dt.Rows[indexnl]["TENNL"].ToString();
            rc_mota.Text = dt.Rows[indexnl]["MOTA"].ToString();
            txt_slnl.Text = dt.Rows[indexnl]["SOLUONGTON"].ToString();
            btn_Sua.Enabled = true;
            btn_xoa.Enabled = true;
            }
        }
        #endregion
      
       
       
        


       
        private void frm_QLKho_Load(object sender, EventArgs e)
        {
            LoadNL();
            LoadMonAn();
            LoadVL();
            Loadncc();
            ngaynhap.Value = DateTime.Now;
            btn_xoapn.Enabled = false;
            btn_xoapx.Enabled = false;
            btn_xoa.Enabled = false;
            btn_xoavl.Enabled = false;
            btn_Sua.Enabled = false;
            btn_suavl.Enabled = false;
            btn_taomanl.Enabled = true;
            btn_taomavl.Enabled = true;
            txt_slnl.Text = "0";
            txt_slvl.Text = "0";
        }



        #region VatLieu
        private void btn_taomavl_Click(object sender, EventArgs e)
        {
            string mavl = "VL";
            string query = "select MAVL from VATLIEU where MAVL like '" + mavl + "%' order by MAVL desc";
            DataTable dt = db.getDataTable(query);
            if (dt.Rows.Count == 0)
            {
                mavl += "001";
            }
            else
            {
                int stt = int.Parse(dt.Rows[0][0].ToString().Substring(3));
                stt++;
                if (stt.ToString().Length == 1)
                {
                    mavl += "00" + stt.ToString();
                }
                else if (stt.ToString().Length == 2)
                    mavl += "0" + stt.ToString();
                else
                    mavl += stt.ToString();
            }

            txt__mavl.Text = mavl;
            btn_taomavl.Enabled = false;
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
        private void btn_locvl_Click(object sender, EventArgs e)
        {
            DataTable dt = db.getDataTable("select * from VATLIEU where MAVL = '" + cb_tenvl.SelectedValue.ToString() + "'");
            dgv_vl.DataSource = dt;
        }

        private void btn_themvl_Click(object sender, EventArgs e)
        {
           
            // Thêm một vật liệu mới vào cơ sở dữ liệu
            int kq = db.getNonquery("insert into VATLIEU values(N'" + txt__mavl.Text + "', N'" + txt_tenvl.Text + "', N'" + rc_vl.Text + "' , "+txt_slvl+")");
            if (kq != 0)
            {
                MessageBox.Show("Thêm vật liệu thành công");
                LoadVL(); // Tải lại danh sách vật liệu
                txt__mavl.Clear();
                txt_tenvl.Clear();
                rc_vl.Clear();
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
                btn_xoavl.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không xóa được vật liệu");
            }
        }
        private void dgv_vl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexvl = e.RowIndex;
            if (indexvl >= 0 && indexvl < dgv_vl.Rows.Count - 1)
            {
                DataTable dt = dgv_vl.DataSource as DataTable;
                txt__mavl.Text = dt.Rows[indexvl]["MAVL"].ToString();
                txt_tenvl.Text = dt.Rows[indexvl]["TENVL"].ToString();
                rc_vl.Text = dt.Rows[indexvl]["MOTA"].ToString();
                txt_slvl.Text = dt.Rows[indexvl]["SOLUONGTON"].ToString();
                btn_suavl.Enabled = true;
                btn_xoavl.Enabled = true;
            }
        }
        private void btn_suavl_Click(object sender, EventArgs e)
        {
            int kq = db.getNonquery("update VATLIEU set TENVL = N'" + txt_tenvl.Text + "' , MOTA = N'" + rc_vl.Text + "', SOLUONGTON =" + txt_slvl.Text + " where MAVL ='"+txt__mavl.Text+"'");
            if (kq != 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadVL();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
        #endregion
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
      private void btn_Thempn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_sln.Text.ToString()) || String.IsNullOrEmpty(txt_Gian.Text.ToString()) || String.IsNullOrEmpty(txt_ttn.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {

                if (radioButton1.Checked)
                {
                    DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    if (cb_nl_vl_pn.SelectedValue == null)
                    {
                        MessageBox.Show("Tên nguyên liệu không tồn tại");
                    }
                    else
                    {
                        if (dt != null)
                        {
                            dt.Rows.Add(txt_mapn.Text, ngaynhap.Value, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
                            dgv_dsnhaphang.DataSource = dt;
                        }
                        else
                        {
                            dt = new DataTable();
                            dt.Columns.Add("Mã pn");
                            dt.Columns.Add("Ngày nhập");
                            dt.Columns.Add("Tên nguyên liệu");
                            dt.Columns.Add("Số lượng");
                            dt.Columns.Add("Giá");
                            dt.Columns.Add("Thành tiền");
                            dt.Rows.Add(txt_mapn.Text, ngaynhap.Value, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
                            dgv_dsnhaphang.DataSource = dt;
                        }
                        txt_sln.Clear();
                        txt_Gian.Clear();
                        txt_ttn.Clear();
                    }
                }
                else
                {
                    DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    if (cb_nl_vl_pn.SelectedValue == null)
                    {
                        MessageBox.Show("Tên vật liệu không tồn tại");
                    }
                    else
                    {

                        if (dt != null)
                        {
                            dt.Rows.Add(txt_mapn.Text, ngaynhap.Value, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
                            dgv_dsnhaphang.DataSource = dt;
                        }
                        else
                        {
                            dt = new DataTable();
                            dt.Columns.Add("Mã pn");
                            dt.Columns.Add("Ngày nhập");
                            dt.Columns.Add("Tên vật liệu");
                            dt.Columns.Add("Số lượng");
                            dt.Columns.Add("Giá");
                            dt.Columns.Add("Thành tiền");
                            dt.Rows.Add(txt_mapn.Text, ngaynhap.Value, cb_nl_vl_pn.Text, txt_sln.Text, txt_Gian.Text, txt_ttn.Text);
                            dgv_dsnhaphang.DataSource = dt;
                        }
                        txt_sln.Clear();
                        txt_Gian.Clear();
                        txt_ttn.Clear();
                    }

                }

            }
        }

       private void btn_Luunhaphang_Click(object sender, EventArgs e)
        {
            bool nhaptc = false;
            if (dgv_dsnhaphang.DataSource == null)
            {
                MessageBox.Show("Bạn cần thêm phiếu nhập");
            }
            else
            {
                if (radioButton1.Checked)
                {


                    string sql = "insert into PHIEUNHAP_NL values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapn = row["Mã pn"].ToString();
                        string tennl = row["Tên nguyên liệu"].ToString();
                        string manl = db.getScalar("select MANL from NGUYENLIEU where TENNL = N'" + tennl + "'").ToString();
                        string sl = row["Số lượng"].ToString();
                        string gia = row["Giá"].ToString();
                        string tt = row["Thành tiền"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_NL values('" + mapn + "', '" + manl + "' , " + sl + " , " + gia + " , " + tt + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                nhaptc = true;
                               
                                LoadnhNL();
                                dgv_dsnhaphang.DataSource = null;
                                txt_mapn.Clear();
                                txt_sln.Clear();
                                txt_Gian.Clear();
                                txt_ttn.Clear();
                                radioButton1.Checked = false;
                                radioButton2.Checked = false;
                                radioButton1.Enabled = true;
                                radioButton2.Enabled = true;
                            }
                            else
                            {
                                nhaptc = false;
                                
                            }
                        }

                    }
                    if (nhaptc)
                    {
                        MessageBox.Show("Thêm phiếu nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu nhập không thành công");
                    }
                    nhaptc = false;
                }
                else
                {

                    string sql = "insert into PHIEUNHAP_VATLIEU values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsnhaphang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapn = row["Mã pn"].ToString();
                        string tenvl = row["Tên vật liệu"].ToString();
                        string mavl = db.getScalar("select MAVL from VATLIEU where TENVL = N'" + tenvl + "'").ToString();
                        string sl = row["Số lượng"].ToString();
                        string gia = row["Giá"].ToString();
                        string tt = row["Thành tiền"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_VATLIEU values('" + mapn + "', '" + mavl + "' , " + sl + " , " + gia + ","+tt+")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                nhaptc = true;
                                LoadnhVL();
                                dgv_dsnhaphang.DataSource = null;
                                txt_mapn.Clear();
                                txt_sln.Clear();
                                txt_Gian.Clear();
                                txt_ttn.Clear();
                                radioButton1.Checked = false;
                                radioButton2.Checked = false;
                                radioButton1.Enabled = true;
                                radioButton2.Enabled = true;
                            }
                            else
                            {
                                nhaptc = false;
                            }
                           
                        }
                    }
                    if (nhaptc)
                    {
                        MessageBox.Show("Thêm phiếu nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu nhập không thành công");
                    }
                    nhaptc = false;
                }
            }

        }

        private void txt_Gian_Leave(object sender, EventArgs e)
        {
            if (txt_sln.Text != "" && txt_Gian.Text != "")
            {
                txt_ttn.Text = (double.Parse(txt_sln.Text) * double.Parse(txt_Gian.Text)).ToString();
            }
            else if(txt_sln.Text == "")
            {
                MessageBox.Show("Phải nhập số lượng");
            }
            else
            {
                MessageBox.Show("Phải nhập giá");
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
             radioButton4.Enabled = false;
            radioButton3.Enabled = false;
        }
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
        private void dgv_dsnhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                indexrownh = e.RowIndex;
                if (indexrownh >= 0 && indexrownh < dgv_dsnhaphang.Rows.Count - 1)
            {
                btn_xoapn.Enabled = true;
            }
        }
        #endregion

        #region tabxuatkho
        
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
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
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
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
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

                if (radioButton4.Checked)
                {
                    DataTable dt = dgv_dsxuathang.DataSource as DataTable;
                    if (cb_nh_vl_px.SelectedValue != null)
                    {

                        if (dt != null)
                        {
                            dt.Rows.Add(txt_mapx.Text, ngayxuat.Value, cb_nh_vl_px.Text, txt_slx.Text);
                            dgv_dsxuathang.DataSource = dt;
                        }
                        else
                        {
                            dt = new DataTable();
                            dt.Columns.Add("Mã px");
                            dt.Columns.Add("Ngày xuất");
                            dt.Columns.Add("Tên nguyên liệu");
                            dt.Columns.Add("Số lượng");
                            dt.Rows.Add(txt_mapx.Text, ngayxuat.Value, cb_nh_vl_px.Text, txt_slx.Text);
                            dgv_dsxuathang.DataSource = dt;
                        }

                        txt_slx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tên nguyên liệu không tồn tại");
                    }
                }
                else
                {
                    DataTable dt = dgv_dsxuathang.DataSource as DataTable;
                    if (cb_nh_vl_px.SelectedValue != null)
                    {
                        if (dt != null)
                        {
                            dt.Rows.Add(txt_mapx.Text, ngayxuat.Value, cb_nh_vl_px.Text, txt_slx.Text);
                            dgv_dsxuathang.DataSource = dt;
                        }
                        else
                        {
                            dt = new DataTable();
                            dt.Columns.Add("Mã px");
                            dt.Columns.Add("Ngày xuất");
                            dt.Columns.Add("Tên vật liệu");
                            dt.Columns.Add("Số lượng");
                            dt.Rows.Add(txt_mapx.Text, ngayxuat.Value, cb_nh_vl_px.Text, txt_slx.Text);
                            dgv_dsxuathang.DataSource = dt;
                        }
                        txt_slx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tên vật liệu không tồn tại");
                    }
                }

            }
        }
        private void dgv_dsxuathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrowxh = e.RowIndex;
            if (indexrowxh >= 0 && indexrowxh < dgv_dsxuathang.Rows.Count - 1)
            {
                btn_xoapx.Enabled = true;
            }
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
                if (dt.Rows.Count == 0)
                {
                    dgv_dsxuathang.DataSource = null;
                    txt_slx.Clear();
                }
            }
            btn_xoapx.Enabled = false;
        }
        private void btn_luuxuathang_Click(object sender, EventArgs e)
        {
            bool xuattc = false;
            if (dgv_dsxuathang.DataSource == null)
            {
                MessageBox.Show("Bạn cần thêm phiếu xuất");
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
                        string manl = db.getScalar("select MANL from NGUYENLIEU where TENNL = N'" + tennl + "'").ToString();
                        string sl = row["Số lượng"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_XUAT_NL values('" + mapx + "', '" + manl + "' , " + sl + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                xuattc = true;
                               
                                LoadxhNL();
                                dgv_dsxuathang.DataSource = null;
                                txt_slx.Clear();
                            }
                            else
                            {
                                xuattc = false;
                               
                            }
                        }

                    }
                    radioButton4.Enabled = true;
                    radioButton3.Enabled = true;
                    if (xuattc)
                    {
                        MessageBox.Show("Thêm phiếu xuất thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu xuất không thành công");
                    }
                    xuattc = false;
                }
                else
                {

                    string sql = "insert into PHIEUXUAT_VATLIEU values('" + txt_mapx.Text + "' , 'NV012','" + ngayxuat.Value.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                    int res = db.getNonquery(sql);
                    DataTable dt = dgv_dsxuathang.DataSource as DataTable;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mapx = row["Mã px"].ToString();
                        string tenvl = row["Tên vật liệu"].ToString();
                        string mavl = db.getScalar("select MAVL from VATLIEU where TENVL = N'" + tenvl + "'").ToString();
                        string sl = row["Số lượng"].ToString();
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_XUAT_VATLIEU values('" + mapx + "', '" + mavl + "' , " + sl + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                xuattc = true;
                                LoadxhVL();
                                dgv_dsxuathang.DataSource = null;
                                txt_slx.Clear();
                            }
                            else
                            {
                                xuattc = false;
                            }
                        }
                    }
                    radioButton4.Enabled = true;
                    radioButton3.Enabled = true;
                    if (xuattc)
                    {
                        MessageBox.Show("Thêm phiếu xuất thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu xuất không thành công");
                    }
                    xuattc = false;
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

                if (dt.Rows.Count == 0)
                {
                    dgv_dsnhaphang.DataSource = null;
                    txt_mapn.Clear();
                    txt_sln.Clear();
                    txt_Gian.Clear();
                    txt_ttn.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
            }
            btn_xoapn.Enabled = false;
        }
        #endregion
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

       

       

        

       

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void cb_nh_vl_px_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        

       

       

       

      
    }
}
