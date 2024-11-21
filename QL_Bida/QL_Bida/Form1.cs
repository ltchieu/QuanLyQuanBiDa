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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox ptrBox = (PictureBox)sender;
            frm_BanBida frm_BanBida = new frm_BanBida();
            frm_BanBida.lb_SoBan.Text = "Bàn " + ptrBox.Name.Substring(1);
            frm_BanBida.lb_NgayVaoChoi.Text = DateTime.Now.ToShortDateString();
            frm_BanBida.txt_StartTime.Text = DateTime.Now.ToShortTimeString();
            if (int.Parse(ptrBox.Name.Substring(1)) >= 1 && int.Parse(ptrBox.Name.Substring(1)) <= 15)
                frm_BanBida.txt_LoaiBan.Text = "Bàn lỗ";
            else
                frm_BanBida.txt_LoaiBan.Text = "Bàn Carom";
            frm_BanBida.ShowDialog();
        }
    }
}
