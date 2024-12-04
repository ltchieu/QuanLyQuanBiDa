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
    public partial class frmThemKH : Form
    {
		DBConnect db = new DBConnect();
		int selectedRow = -1;
		public frmThemKH()
		{
			InitializeComponent();
		}

		//Tạo mã khách hàng
		private void btn_TaoMaKH_Click(object sender, EventArgs e)
		{
			string makh = "KH";
			string query = "select MAKH from KHACHHANG order by MAKH desc";
			DataTable dt = db.getDataTable(query);
			int stt = int.Parse(dt.Rows[0][0].ToString().Substring(2));
			stt++;
			if (stt.ToString().Length == 1)
				makh += "00" + stt;
			else if (stt.ToString().Length == 2)
				makh += "0" + stt;
			else
				makh += stt.ToString();

			txt_MaKH.Text = makh;
			btn_ThemKH.Enabled = IsEnable();
		}

		private void btn_ThemKH_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dtgv_dsKH.DataSource;
			foreach (DataRow item in dt.Rows)
			{
				if (string.Compare(item["MaKH"].ToString(), txt_MaKH.Text) == 0)
				{
					MessageBox.Show("Đã có khách hàng này!");
					return;
				}
			}
			string query =
				"insert into KHACHHANG values('" + txt_MaKH.Text + "', '" + txt_TenKH.Text + "' , 'TV', '" + txt_SDT.Text + "' , 0, '" + txt_DiaChi.Text + "')";
			int k = db.getNonquery(query);
			if (k == 1)
			{
				MessageBox.Show("Thêm mới một khách hàng thành công");
				HienThiDSKH();
			}
			else
				MessageBox.Show("Thêm không thành công");

		}

		private void frmThemKH_Load(object sender, EventArgs e)
		{
			btn_ThemKH.Enabled = false;
			btnSua.Enabled = false;

			HienThiDSKH();
		}

		private void txt_DiaChi_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (txt.Text.Length > 0 && txt.Text.All(char.IsDigit) == false)
			{
				errorProvider1.SetError(txt, "Chỉ chứa các kí tự số");
			}
			else
			{
				errorProvider1.Clear();
			}
			btn_ThemKH.Enabled = IsEnable();
		}

		private void txt_TenKH_Leave(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (string.IsNullOrEmpty(txt.Text))
			{
				errorProvider1.SetError(txt, "Không được bỏ trống!");
			}
			else
			{
				errorProvider1.Clear();
			}

			btn_ThemKH.Enabled = IsEnable();
		}


		private bool IsEnable()
		{
			List<TextBox> lst = this.groupBox1.Controls.OfType<TextBox>().ToList();
			foreach (TextBox tb in lst)
			{
				if (string.IsNullOrEmpty(tb.Text))
					return false;
			}

			return true;
		}

		private void dtgv_dsKH_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if (selectedRow != -1)
			{
				DataTable dt = (DataTable)dtgv_dsKH.DataSource;
				txt_MaKH.Text = dt.Rows[selectedRow]["makh"].ToString();
				txt_TenKH.Text = dt.Rows[selectedRow]["tenKh"].ToString();
				txt_DiaChi.Text = dt.Rows[selectedRow]["diaChi"].ToString();
				txt_SDT.Text = dt.Rows[selectedRow]["SDT"].ToString();
				txt_SoDiemThuong.Text = dt.Rows[selectedRow]["sodiemthuong"].ToString();
				txt_LoaiKH.Text = dt.Rows[selectedRow]["TenLoaiKH"].ToString();
				btnSua.Enabled = true;
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{

			string makh = txt_MaKH.Text;
			string tenkh = txt_TenKH.Text;
			string diachi = txt_DiaChi.Text;
			string sdt = txt_SDT.Text;

			string query =
				"update KHACHHANG set TenKH = N'" + tenkh + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "' where MaKH = '" + makh + "'";
			int k = db.getNonquery(query);
			if (k == 1)
				MessageBox.Show("Sửa thành công!");
			else
				MessageBox.Show("Sửa không thành công!");

			List<TextBox> list = this.groupBox1.Controls.OfType<TextBox>().ToList();
			foreach (TextBox tb in list)
			{
				if (string.Compare(tb.Name, "txt_SoDiemThuong") == 0)
					tb.Text = "0";
				else
				{
					tb.Clear();
				}
			}
			btnSua.Enabled = false;
			btn_ThemKH.Enabled = IsEnable();
			HienThiDSKH();
		}

		private void HienThiDSKH()
		{
			string query = "select MaKH, TenKH, TENLOAIKH, SDT, SODIEMTHUONG, DiaChi from KhachHang k join LoaiKH l on l.Maloai = k.MALOAI";
			dtgv_dsKH.DataSource = db.getDataTable(query);
		}


	}
}
