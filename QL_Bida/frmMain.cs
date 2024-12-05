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
    public partial class frmMain : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public static string nhom, tendn, maNV;
        public frmMain()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnDanhSachBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDSBanBida());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào " + nhom);
            if (nhom == "Quản lý")
            {
                btnDanhSachBan.Enabled = true;
                btnHoaDonLS.Enabled = true;
                btnKhachHang.Enabled = true;
                btnKho.Enabled = true;
               
                btnQLDichVu.Enabled = true;
                btnNhanVien.Enabled = true;
                btnThongKe.Enabled = true;
            }
            else if (nhom == "Quản lý kho")
            {
                btnKho.Enabled = true;
              
                btnQLDichVu.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }
            else
            {
                btnDanhSachBan.Enabled = true;
                btnHoaDonLS.Enabled = true;
                btnKhachHang.Enabled = true;
                btnKho.Enabled= false;
                btnQLDichVu.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }
			DateTime ngayHT = DateTime.Now; //Lấy ra ngày hiện tại
			DateTime ngayTT = ngayHT.AddDays(1); //Lấy ra ngày tiếp theo của ngày hiện tại

			string query = "select * from DatBan where NgayDatBan Between '" + ngayHT.ToString("yyyy-MM-dd") + "' and '" + ngayTT.ToString("yyyy-MM-dd") + "'";
			List<string> dsBanDuocDat = new List<string>();
			string kq = "Danh sách bàn được đặt vào hôm nay: ";
			DataTable dt = db.getDataTable(query);
			if (dt != null || dt.Rows.Count != 0)
			{
				foreach (DataRow item in dt.Rows)
				{
					dsBanDuocDat.Add(item["MaBan"].ToString());
				}
				foreach (var s in dsBanDuocDat)
				{
					if (s == dsBanDuocDat.Last())
						kq += s.Trim();
					else
						kq += s.Trim() + ", ";
				}

				MessageBox.Show(kq);
			}
		}

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

		private void btnQLDichVu_Click(object sender, EventArgs e)
		{
            OpenChildForm(new frm_DichVu());
		}

		private void button1_Click(object sender, EventArgs e)
		{
            OpenChildForm(new frmDatBan());
		}

		private void btnKhachHang_Click(object sender, EventArgs e)
		{
            OpenChildForm(new frmThemKH());
		}

		private void btnKho_Click(object sender, EventArgs e)
		{
            OpenChildForm(new frm_QLKho());
		}

        private void btnHoaDonLS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichSu());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
		{
            OpenChildForm(new frm_ThongKe());
		}

		private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLNV());
        }
    }
}
