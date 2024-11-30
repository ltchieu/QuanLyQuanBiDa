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
    public partial class Frm_NguyenLieu : Form
    {
        DBConnect db = new DBConnect();
        public Frm_NguyenLieu()
        {
            InitializeComponent();
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
        private void Frm_NguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNL();
            LoadMonAn();
        }

        private bool Kiemtratrungma(string ma)
        {
            if (db.getScalar("select count * from NGUYENLIEU where MANL = '" + txt__manl.Text + "'") != 0)
            {
                return true;
            }
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
           int kq= db.getNonquery("insert into NGUYENLIEU values(N'" + txt__manl.Text + "', N'" + txt_tennl.Text + "' , N'" + rc_mota.Text + "' , 0)");
           if (kq != 0)
           {
               MessageBox.Show("Thêm nguyên liệu thành công");
               LoadNL();
           }
           else{
               if(Kiemtratrungma(txt__manl.Text)){
                   MessageBox.Show("Trung mã nguyên liệu");

               }
               else
               {
                   MessageBox.Show("Thêm nguyên liệu không thành công");
               }
           }
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

        private void dgv_nl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = dgv_nl.DataSource as DataTable;

            txt__manl.Text = dt.Rows[e.RowIndex]["MANL"].ToString();
            txt_tennl.Text = dt.Rows[e.RowIndex]["TENNL"].ToString();
            rc_mota.Text = dt.Rows[e.RowIndex]["mota"].ToString();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            dgv_nl.DataSource = db.getDataTable("select NGUYENLIEU.* from DICHVU_NGUYENLIEU , NGUYENLIEU where MADV = '" + cb_monan.SelectedValue + "' and NGUYENLIEU.MANL = DICHVU_NGUYENLIEU.MANL");
        }
    }
}
