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
    public partial class Frm_VatLieu : Form
    {
        DBConnect db = new DBConnect(); // Đảm bảo bạn có một kết nối đến cơ sở dữ liệu

        public Frm_VatLieu()
        {
            InitializeComponent();
        }

        public void LoadVL()
        {
            // Tải dữ liệu vật liệu từ cơ sở dữ liệu vào DataGridView
            dgv_nl.DataSource = db.getDataTable("select * from VATLIEU");
        }

        private bool Kiemtratrungma(string ma)
        {
            // Kiểm tra xem mã vật liệu có bị trùng trong cơ sở dữ liệu không
            if (db.getScalar("select count(*) from VATLIEU where MAVL = '" + ma + "'") != 0)
            {
                return true;
            }
            return false;
        }

        private void Frm_VatLieu_Load(object sender, EventArgs e)
        {
            LoadVL(); // Gọi hàm LoadVL khi form được tải
        }

        private void btn_them_Click(object sender, EventArgs e)
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
                // Kiểm tra nếu mã vật liệu bị trùng
                if (Kiemtratrungma(txt__mavl.Text))
                {
                    MessageBox.Show("Trung mã vật liệu");
                }
                else
                {
                    MessageBox.Show("Thêm vật liệu không thành công");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
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

        private void dgv_nl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Khi người dùng click vào một dòng trong DataGridView, hiển thị thông tin vật liệu lên các textbox
            DataTable dt = dgv_nl.DataSource as DataTable;

            txt__mavl.Text = dt.Rows[e.RowIndex]["MAVL"].ToString();
            txt_tenvl.Text = dt.Rows[e.RowIndex]["TENVL"].ToString();
            rc_mota.Text = dt.Rows[e.RowIndex]["mota"].ToString();
        }
    }
}
