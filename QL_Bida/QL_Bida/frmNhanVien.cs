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

		private void button1_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Form1());
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{

		}

		private void btnDanhSachBan_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Form1());
		}

		private void button6_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frm_QLNV());
		}
	}
}
