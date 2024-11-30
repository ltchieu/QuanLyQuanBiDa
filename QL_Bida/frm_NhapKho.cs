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
    public partial class frm_NhapKho : Form
    {
        DBConnect db = new DBConnect();
        public frm_NhapKho()
        {
            InitializeComponent();
        }

        private void btn_Taomapn_Click(object sender, EventArgs e)
        {
            string mapn = db.TaoMAPN();
            txt_mapn.Text = mapn;
        }

        public void Loadncc()
        {
            cb_nhacc.DataSource = db.getDataTable("select * from NHACC");
            cb_nhacc.ValueMember = "MANCC";
            cb_nhacc.DisplayMember = "TENNHACC";
        }
        private void frm_NhapKho_Load(object sender, EventArgs e)
        {
            Loadncc();
            ngaynhap.Value = DateTime.Now;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string sql1 = "select count(*) from NCC_VatLieuNguyenLieu n,NHACC,NGUYENLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVLNL = NGUYENLIEU.MANL";
                string sql = "select NGUYENLIEU.* from NCC_VatLieuNguyenLieu n,NHACC,NGUYENLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVLNL = NGUYENLIEU.MANL";
                int result = db.getScalar(sql1);
                if(result != 0){
                cb_nl_vl.DataSource = db.getDataTable(sql);
                cb_nl_vl.ValueMember = "MANL";
                cb_nl_vl.DisplayMember = "TENNL";
                }
                else {
                    cb_nl_vl.DataSource = null;
                    cb_nl_vl.Text = "Nhà cung cấp không cung cấp nguyên liệu này";
                }
            }
            else if(radioButton2.Checked)
            {
                string sql1 = "select count(*) from NCC_VatLieuNguyenLieu n,NHACC,VATLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVLNL = VATLIEU.MAVL";
                string sql = "select VATLIEU.* from NCC_VatLieuNguyenLieu n,NHACC,VATLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVLNL = VATLIEU.MAVL";
                int result = db.getScalar(sql1);
                if(result != 0){
                cb_nl_vl.DataSource = db.getDataTable(sql);
                cb_nl_vl.ValueMember = "MAVL";
                cb_nl_vl.DisplayMember = "TENVL";
                }
                else{
                    cb_nl_vl.DataSource = null;
                    cb_nl_vl.Text = "Nhà cung cấp không cung cấp vật liệu này";
                }
            }
        }

        private void btn_Thempn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_sl.Text.ToString()) || String.IsNullOrEmpty(txt_mapn.Text) || String.IsNullOrEmpty(txt_Gia.ToString()))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                if(radioButton1.Checked){
                int kq = db.getScalar("select count(*) from PHIEUNHAP where MAPN = '" + txt_mapn.Text + "'");
                if (kq != 0)
                {
                    string sql = "insert into  CHI_TIET_PHIEU_NHAP_NL values('" + txt_mapn.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text + " , " + txt_Gia.Text + ")";
                    int kq1 = db.getNonquery(sql);
                    if (kq1 != 0)
                    {
                        MessageBox.Show("Thêm vào phiếu nhập thành công");
                        LoadnhNL();
                        txt_sl.Clear();
                        txt_Gia.Clear();
                        //txt_tt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm vào phiếu nhập không thành công");
                    }
                }
                else
                {
                    string sql = "insert into PHIEUNHAP_NL values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") +"', null)";
                    int res = db.getNonquery(sql);
                    if (res != 0)
                    {
                        string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_NL values('" + txt_mapn.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text + " , " + txt_Gia.Text + ")";
                        int res1 = db.getNonquery(sql1);
                        if (res1 != 0)
                        {
                            MessageBox.Show("Thêm phiếu nhập thành công");
                            LoadnhNL();
                            txt_sl.Clear();
                            txt_Gia.Clear();
                            //txt_tt.Clear();
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
                    int kq = db.getScalar("select count(*) from PHIEUNHAP where MAPN = '" + txt_mapn.Text + "'");
                    if (kq != 0)
                    {
                        string sql = "insert into  CHI_TIET_PHIEU_NHAP_VATLIEU values('" + txt_mapn.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text + " , " + txt_Gia.Text + ")";
                        int kq1 = db.getNonquery(sql);
                        if (kq1 != 0)
                        {
                            MessageBox.Show("Thêm vào phiếu nhập thành công");
                            LoadnhVL();
                            txt_sl.Clear();
                            txt_Gia.Clear();
                            //txt_tt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm vào phiếu nhập không thành công");
                        }
                    }
                    else
                    {
                        string sql = "insert into PHIEUNHAP_VATLIEU values('" + txt_mapn.Text + "', '" + cb_nhacc.SelectedValue + "' , 'NV012','" + ngaynhap.Value.ToString("yyyy-MM-dd hh:mm:ss") +"',null)";
                        int res = db.getNonquery(sql);
                        if (res != 0)
                        {
                            string sql1 = "insert into  CHI_TIET_PHIEU_NHAP_VATLIEU values('" + txt_mapn.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text + " , " + txt_Gia.Text + ")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu nhập thành công");
                                LoadnhVL();
                                txt_sl.Clear();
                                txt_Gia.Clear();
                                //txt_tt.Clear();
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

        private void dgv_nhaphang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = dgv_nhaphang.DataSource as DataTable;
            Loadncc();
            cb_nhacc.Text = String.Empty;
            txt_mapn.Text = dt.Rows[e.RowIndex]["MAPN"].ToString();
            cb_nhacc.Text = "" +dt.Rows[e.RowIndex]["TENNHACC"].ToString();
            ngaynhap.Value =  (DateTime)dt.Rows[e.RowIndex]["NGAYNHAP"] ;
            txt_sl.Text = dt.Rows[e.RowIndex]["SOLUONG"].ToString();
            txt_Gia.Text = dt.Rows[e.RowIndex]["GIA"].ToString();
            if (dt.Columns.Contains("TENNL"))
            {
            string sql = "select NGUYENLIEU.* from NCC_VatLieuNguyenLieu n,NHACC,NGUYENLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVLNL = NGUYENLIEU.MANL";
            cb_nl_vl.DataSource = db.getDataTable(sql);
            cb_nl_vl.ValueMember = "MANL";
            cb_nl_vl.DisplayMember = "TENNL";
        }
            else
            {
                string sql = "select VATLIEU.* from NCC_VatLieuNguyenLieu n,NHACC,VATLIEU where NHACC.MANCC = '" + cb_nhacc.SelectedValue + "' and n.MANCC = NHACC.MANCC and n.MAVLNL = VATLIEU.MANL";
                cb_nl_vl.DataSource = db.getDataTable(sql);
                cb_nl_vl.ValueMember = "MAVL";
                cb_nl_vl.DisplayMember = "TENVL";
            }

            }

        private void btn_xoapn_Click(object sender, EventArgs e)
        {
            DataTable dt = dgv_nhaphang.DataSource as DataTable;
            if(dt.Columns.Contains("TENNL")){

                int kq = db.getNonquery("delete from PHIEUNHAP_NL where PHIEUNHAP_NL.MAPN = '" + txt_mapn.Text + "'");
                if (kq != 0)
                {
                    int kq1 = db.getNonquery("delete from CHI_TIET_PHIEU_NHAP_NL n where n.MAPN = '" + txt_mapn.Text + "'");
                    if (kq1 != 0)
                    {
                        MessageBox.Show("Xóa phiếu nhập thành công");
                        LoadnhNL();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập không thành công");
                }
            }
            else
            {
                int kq = db.getNonquery("delete from PHIEUNHAP_VATLIEU where PHIEUNHAP_VATLIEU.MAPN = '" + txt_mapn.Text + "'");
                if (kq != 0)
                {
                    int kq1 = db.getNonquery("delete from CHI_TIET_PHIEU_NHAP_VATLIEU n where n.MAPN = '" + txt_mapn.Text + "'");
                    if (kq1 != 0)
                    {
                        MessageBox.Show("Xóa phiếu nhập thành công");
                        LoadnhVL();
                    }

                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập không thành công");
                }
            }
        }

        
    }
}
