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
    public partial class frmDSBanBida : Form
    {
        public static Dictionary<string, TrangThaiForm> dsTrangThaiBan = new Dictionary<string, TrangThaiForm>(); // Lưu trữ trạng thái của các bàn
        private PictureBox selectedPictureBox; //Lưu lại pictureBox được chọn
        public frmDSBanBida()
        {
            InitializeComponent();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox ptrBox = (PictureBox)sender;
            selectedPictureBox = ptrBox;

            frm_BanBida frm_Ban = new frm_BanBida();
            frm_Ban.lb_SoBan.Text = "Bàn " + ptrBox.Name.Substring(1);

            frm_BanBida.selectedBan = ptrBox.Name.Substring(1);

            frm_Ban.lb_NgayVaoChoi.Text = DateTime.Now.ToString("yyyy-MM-dd");
            frm_Ban.txt_StartTime.Text = DateTime.Now.ToString("T");
            if (ptrBox.Name.Substring(0, 1) == "B")
            {
                frm_Ban.txt_LoaiBan.Text = "Bàn lỗ";
                frm_Ban.maLoaiBan = 2;
            }
            else
            {
                frm_Ban.txt_LoaiBan.Text = "Bàn Carom";
                frm_Ban.maLoaiBan = 1;
            }
            ptrBox.BackColor = Color.Salmon;
            frm_Ban.DoiMauNenThanhXanh += Frm_BanBiDa_DoiMauNenThanhXanh;

            frm_Ban.ShowDialog();
        }

        private void Frm_BanBiDa_DoiMauNenThanhXanh(object sender, EventArgs e)
        {
            if (selectedPictureBox != null)
            {
                selectedPictureBox.BackColor = Color.MediumSpringGreen;
            }
        }

        private void frmDSBanBida_Load(object sender, EventArgs e)
        {
            frm_BanBida.lst = pnl_dsBanLo.Controls.OfType<PictureBox>().ToList();
            frm_BanBida.lst.AddRange(pnl_dsBanCarom.Controls.OfType<PictureBox>().ToList());
        }
    }
}
