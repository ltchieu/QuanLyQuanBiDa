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
    public partial class frmLichSu : Form
    {
        DBConnect db = new DBConnect();
        int selectedRow = -1;
        public frmLichSu()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void LoadDataGridView(string query)
        {
            DataTable dt = db.getDataTable(query);
            dtgv_DSHD.DataSource = dt;
        }

        private void frmLichSu_Load(object sender, EventArgs e)
        {
            string query = "select MaHD, TenKH, SDT ,NgayLap, GIAMGIA, NgayDat, TENNV from dsHD";
            LoadDataGridView(query);
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            string query = "select MaHD, TenKH,NgayLap, GIAMGIA, NgayDat, TENNV from dsHD where ";
            string ngayBD = dtp_ngayBD.Value.ToString("yyyy-MM-dd");
            string ngayKT = dtp_NgayKT.Value.ToString("yyyy-MM-dd");
            string sdtkh = "";
            string maNV = "";
            if (ck_locTheoNgay.Checked)
            {
                query += "NgayLap between '" + ngayBD + "' and '" + ngayKT + "'";
                if (rdb_locTheoKH.Checked)
                {
                    sdtkh = txt_sdtKH.Text;
                    query += " and SDT = '" + sdtkh + "'";
                }
                else
                {
                    maNV = txt_maNV.Text;
                    query += " and MANV = '" + maNV + "'";
                }
            }
            else
            {
                if (rdb_locTheoKH.Checked)
                {
                    sdtkh = txt_sdtKH.Text;
                    query += "SDT = '" + sdtkh + "'";
                }
                else
                {
                    maNV = txt_maNV.Text;
                    query += "MANV = '" + maNV + "'";
                }
            }

            LoadDataGridView(query);

        }

        private void rdb_locTheoKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_locTheoKH.Checked)
            {
                txt_maNV.Enabled = false;
                txt_sdtKH.Enabled = true;
            }
            else
            {
                txt_maNV.Enabled = true;
                txt_sdtKH.Enabled = false;
            }
        }

        //Load lại datagridview
        private void frmLichSu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadDataGridView("select MaHD, TenKH, SDT ,NgayLap, GIAMGIA, NgayDat, TENNV from dsHD");
            }
        }

        //Xem chi tiết một hóa đơn
        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtgv_DSHD.DataSource;
            string maHD = dt.Rows[selectedRow]["MaHD"].ToString();
            frm_CTHD.maHD = maHD;

            frm_CTHD frm = new frm_CTHD();
            frm.ShowDialog();
        }

        private void dtgv_DSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
    }
}
