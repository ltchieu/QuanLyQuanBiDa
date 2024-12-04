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
	public partial class frm_DichVu : Form
	{
		public frm_DichVu()
		{
			InitializeComponent();
		}
		DBConnect db = new DBConnect();
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void frm_DichVu_Load(object sender, EventArgs e)
		{
			HienthiDVU();
			HienThiLOAIDV();
			txtMADV.Visible = false;

		}
		public void HienthiDVU()
		{
			DataTable dt = db.getDataTable("select MaDV, TENDV, Gia, l.TENLOAIDV, l.MALOAIDVU from LOAIDICHVU l join DichVu d on d.MALOAIDVU=l.MALOAIDVU ");
			dgvDichVu.DataSource = dt;
			dgvDichVu.RowHeadersVisible = false;
		}
		public void HienThiLOAIDV()
		{
			DataTable dt = db.getDataTable("select * from LOAIDICHVU");
			cbLoaiDV.DataSource = dt;
			cbLoaiDV.ValueMember = "MALOAIDVU";
			cbLoaiDV.DisplayMember = "TENLOAIDV";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			int k = db.getNonquery("insert into DichVu values('" + txtTenDV.Text + "','" + float.Parse(txtGiaDV.Text) + "','" + cbLoaiDV.SelectedValue + "')");
			if (k != 0)
			{
				MessageBox.Show("Thêm dịch vụ thành công");
				HienthiDVU();
			}
			else
			{
				MessageBox.Show("Thêm thất bại");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int k = db.getNonquery("delete from DichVu where MaDV =" + txtMADV.Text + "");
			if (k != 0)
			{
				MessageBox.Show("Xóa dịch vụ thành công");
				HienthiDVU();
			}
			else
			{
				MessageBox.Show("Xóa thất bại");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			int k = db.getNonquery("update DichVu set TENDV =N'" + txtTenDV.Text + "', " +
						   "Gia = '" + float.Parse(txtGiaDV.Text) + "', " +
						   "MALOAIDVU = '" + cbLoaiDV.SelectedValue + "' where MaDV =" + txtMADV.Text + "");

			if (k != 0)
			{
				MessageBox.Show("Sửa dịch vụ thành công");
				HienthiDVU();
			}
			else
			{
				MessageBox.Show("Sửa thất bại");
			}
		}

		private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Đảm bảo hàng được chọn là hợp lệ
			{
				DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
				txtMADV.Text = row.Cells["MaDV"].Value.ToString();
				txtTenDV.Text = row.Cells["TenDV"].Value.ToString();
				txtGiaDV.Text = row.Cells["Gia"].Value.ToString();
				cbLoaiDV.SelectedValue = row.Cells["MALOAIDVU"].Value;

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string query = "select * from DICHVU where TenDV like N'%" + textBox1.Text + "%'";
			int k = db.getNonquery(query);

			if (k != 0)
			{
				DataTable dt = db.getDataTable(query);
				dgvDichVu.DataSource = dt;

			}
			else
			{
				MessageBox.Show("Không có dịch vụ này.");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frm_LoaiDV f = new frm_LoaiDV();
			f.ShowDialog();
			
		}
	}
}
