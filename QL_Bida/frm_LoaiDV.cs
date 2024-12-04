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
	public partial class frm_LoaiDV : Form
	{
		public frm_LoaiDV()
		{
			InitializeComponent();
		}
		DBConnect dB = new DBConnect();
		frm_DichVu f = new frm_DichVu();

		private void frm_LoaiDV_Load(object sender, EventArgs e)
		{
			DataTable dt = dB.getDataTable("select * from LOAIDICHVU");
			dataGridView1.DataSource = dt;
			textBox2.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dt = dB.getDataTable("select * from LOAIDICHVU");
			string dbValue = dt.Rows[0]["TENLOAIDV"].ToString().Trim();

			if (textBox1.Text.Trim().Equals(dbValue, StringComparison.OrdinalIgnoreCase))
			{
				MessageBox.Show("Đã có dịch vụ này");
			}
			else
			{
				int dt2 = dB.getNonquery("insert into LOAIDICHVU values(N'" + textBox1.Text + "')");
				if (dt2 != 0)
				{
					MessageBox.Show("Thêm thành công");
					f.HienthiDVU();

				}
				else
				{
					MessageBox.Show("Thêm thất bại");
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				textBox1.Text = row.Cells["TENLOAIDV"].Value.ToString();
				textBox2.Text= row.Cells["MALOAIDVU"].Value.ToString();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int k = dB.getNonquery("select ");
		}
	}
}
