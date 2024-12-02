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
    public partial class frmDangNhap : Form
    {
        DBConnect db = new DBConnect();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDN.Text.Trim();
            string password = txtMK.Text.Trim();
            DBConnect db = new DBConnect();
            string query = "select * from NHANVIEN,NHOMQUYEN where NhanVien.MANHOM = NHOMQUYEN.MANHOM and TENDANGNHAP = '" + tendn + "' and MATKHAU='" + password + "'";
            DataTable dt = db.getDataTable(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Dang nhap that bai");
                txtTenDN.Clear();
                txtMK.Clear();
            }
            else
            {
                frmMain f = new frmMain();
                frmMain.nhom = dt.Rows[0]["TENNHOM"].ToString();
                frmMain.tendn = dt.Rows[0]["TENDANGNHAP"].ToString();
                frmMain.maNV = dt.Rows[0]["MANV"].ToString();
                f.Show();

                f.Logout += F_logout;
            }

        }
        private void F_logout(object sender, EventArgs e)
        {
            (sender as frmMain).isExit = false;
            (sender as frmMain).Close();
            this.Show();
        }
    }


}
