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
    public partial class frm_XuatKho : Form
    {
        DBConnect db = new DBConnect();
        public frm_XuatKho()
        {
            InitializeComponent();
        }

        private void frm_XuatKho_Load(object sender, EventArgs e)
        {
            ngayxuat.Value = DateTime.Now;
        }
        // Hàm load nhà cung cấp
       

        // Hàm load dữ liệu phiếu xuất
        public void LoadnhNL()
        {
            dgv_xuathang.DataSource = db.getDataTable("select n.MAPX, n.NGAYXUAT, NGUYENLIEU.TENNL , c.SOLUONG, n.THANHTIEN from PHIEUXUAT_NL n, CHI_TIET_PHIEU_XUAT_NL c, NHANVIEN, NGUYENLIEU where n.MANV = NHANVIEN.MANV and c.MANL = NGUYENLIEU.MANL");
        }

        // Hàm load dữ liệu phiếu xuất vật liệu
        public void LoadnhVL()
        {
            dgv_xuathang.DataSource = db.getDataTable("select n.MAPX, n.NGAYXUAT, VATLIEU.TENVL , c.SOLUONG, n.THANHTIEN from PHIEUXUAT_VATLIEU n, CHI_TIET_PHIEU_XUAT_VATLIEU c, NHANVIEN, VATLIEU where n.MANV = NHANVIEN.MANV and c.MAVL = VATLIEU.MAVL");
        }
        public void Loadnl()
        {
            string sql = "select NGUYENLIEU.* from NCC_VatLieuNguyenLieu n, NGUYENLIEU where n.MAVLNL = NGUYENLIEU.MANL";
            cb_nl_vl.DataSource = db.getDataTable(sql);
            cb_nl_vl.ValueMember = "MANL";
            cb_nl_vl.DisplayMember = "TENNL";
        }
        public void Loadvl()
        {
            string sql = "select VATLIEU.* from NCC_VatLieuNguyenLieu n, VATLIEU where n.MAVLNL = VATLIEU.MAVL";
            cb_nl_vl.DataSource = db.getDataTable(sql);
            cb_nl_vl.ValueMember = "MAVL";
            cb_nl_vl.DisplayMember = "TENVL";
        }
        // Tạo mã phiếu xuất
        private void btn_Taomapx_Click(object sender, EventArgs e)
        {
            string mapx = db.TaoMAPX();
            txt_mapx.Text = mapx;
        }

        // Sự kiện khi chọn nhà cung cấp và nguyên liệu/vật liệu
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Loadnl();
                
                
            }
            else if (radioButton2.Checked)
            {
                Loadvl();
            }
        }

        // Thêm phiếu xuất
        private void btn_Thempx_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mapx.Text) || String.IsNullOrEmpty(txt_sl.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    // Kiểm tra phiếu xuất đã tồn tại chưa
                    int kq = db.getScalar("select count(*) from PHIEUXUAT_NL where MAPX = '" + txt_mapx.Text + "'");
                    if (kq != 0)
                    {
                        string sql = "insert into CHI_TIET_PHIEU_XUAT_NL values('" + txt_mapx.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text +")";
                        int kq1 = db.getNonquery(sql);
                        if (kq1 != 0)
                        {
                            MessageBox.Show("Thêm vào phiếu xuất thành công");
                            LoadnhNL();
                            txt_sl.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm vào phiếu xuất không thành công");
                        }
                    }
                    else
                    {
                        string sql = "insert into PHIEUXUAT_NL values('" + txt_mapx.Text + "', 'NV012','" + ngayxuat.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', null)";
                        int res = db.getNonquery(sql);
                        if (res != 0)
                        {
                            string sql1 = "insert into CHI_TIET_PHIEU_XUAT_NL values('" + txt_mapx.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text +")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu xuất thành công");
                                LoadnhNL();
                                txt_sl.Clear();
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
                    int kq = db.getScalar("select count(*) from PHIEUXUAT_VATlIEU where MAPX = '" + txt_mapx.Text + "'");
                    if (kq != 0)
                    {
                        string sql = "insert into CHI_TIET_PHIEU_XUAT_VATLIEU values('" + txt_mapx.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text +")";
                        int kq1 = db.getNonquery(sql);
                        if (kq1 != 0)
                        {
                            MessageBox.Show("Thêm vào phiếu xuất thành công");
                            LoadnhNL();
                            txt_sl.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm vào phiếu xuất không thành công");
                        }
                    }
                    else
                    {
                        string sql = "insert into PHIEUXUAT_VATLIEU values('" + txt_mapx.Text + "', 'NV012','" + ngayxuat.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', null)";
                        int res = db.getNonquery(sql);
                        if (res != 0)
                        {
                            string sql1 = "insert into CHI_TIET_PHIEU_XUAT_VATLIEU values('" + txt_mapx.Text + "', '" + cb_nl_vl.SelectedValue + "' , " + txt_sl.Text +")";
                            int res1 = db.getNonquery(sql1);
                            if (res1 != 0)
                            {
                                MessageBox.Show("Thêm phiếu xuất thành công");
                                LoadnhNL();
                                txt_sl.Clear();
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

        // Xóa phiếu xuất
        private void btn_xoapx_Click(object sender, EventArgs e)
        {
            DataTable dt = dgv_xuathang.DataSource as DataTable;
            if (dt.Columns.Contains("TENNL"))
            {

                int kq = db.getNonquery("delete from CHI_TIET_PHIEU_XUAT_NL where MAPX = '" + txt_mapx.Text + "'");
                if (kq != 0)
                {
                    int kq1 = db.getNonquery("delete from PHIEUXUAT_NL where PHIEUXUAT_NL.MAPX = '" + txt_mapx.Text + "'");
                    if (kq1 != 0)
                    {
                        MessageBox.Show("Xóa phiếu xuất thành công");
                        LoadnhNL();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa phiếu xuất không thành công");
                }
            }
            else
            {

                int kq = db.getNonquery("delete from CHI_TIET_PHIEU_XUAT_VATLIEU where MAPX = '" + txt_mapx.Text + "'");
                if (kq != 0)
                {
                    int kq1 = db.getNonquery("delete from PHIEUXUAT_VATLIEU where PHIEUXUAT_VATLIEU.MAPX = '" + txt_mapx.Text + "'");
                    if (kq1 != 0)
                    {
                        MessageBox.Show("Xóa phiếu xuất thành công");
                        LoadnhVL();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa phiếu xuất không thành công");
                }
            }
        }

        // Sự kiện chọn dòng trong DataGridView
        private void dgv_xuathang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < (dgv_xuathang.RowCount-1))
            {
            DataTable dt = dgv_xuathang.DataSource as DataTable;
            if (dt != null)
            {

            txt_mapx.Text = dt.Rows[e.RowIndex]["MAPX"].ToString();
            ngayxuat.Value = (DateTime)dt.Rows[e.RowIndex]["NGAYXUAT"];
            txt_sl.Text = dt.Rows[e.RowIndex]["SOLUONG"].ToString();

            if (dt.Columns.Contains("TENNL"))
            {
                Loadnl();
                cb_nl_vl.Text = dt.Rows[e.RowIndex]["TENNL"].ToString();
            }
            else
            {
                Loadvl();
                cb_nl_vl.Text = dt.Rows[e.RowIndex]["TENVL"].ToString();
            }
            }
            }
        }

        private void btn_nhnl_Click(object sender, EventArgs e)
        {
            LoadnhNL();
        }

        private void btn_nhvl_Click(object sender, EventArgs e)
        {
            LoadnhVL();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
