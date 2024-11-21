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
        public static string nhom, tendn;
        public frmMain()
        {
            InitializeComponent();
        }

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
                btnKhuyenMai.Enabled = true;
                btnQLDichVu.Enabled = true;
                btnNhanVien.Enabled = true;
                btnThongKe.Enabled = true;
            }
            else if (nhom == "Quản lý kho")
            {
                btnKho.Enabled = true;
                btnKhuyenMai.Enabled = false;
                btnQLDichVu.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }
            else
            {
                btnDanhSachBan.Enabled = true;
                btnHoaDonLS.Enabled = true;
                btnKhachHang.Enabled = true;
                btnKhuyenMai.Enabled = false;
                btnQLDichVu.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
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

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLNV());
        }
    }
}
